using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

delegate void SetchannelCallback(int channel);
delegate void SetPowerButtonColorCallback((int, int, int) color);
delegate void SetButtonsAvailabilityCallback(Button button, bool status);

namespace TVController
{
	public partial class TVController : Form
	{
		private const int interface_updater_refresh_rate = 60;

		(int, int, int) power_off_color = (255, 153, 153);
		(int, int, int) power_on_process_color = (255, 0, 0);
		(int, int, int) power_on_color = (204, 255, 153);
		Television tv_instance;
		List<Thread> cron_threads;

		public TVController()
		{
			InitializeComponent();
			List<Person> owners = initOwnersData();
			HomeData home_data = initHomeData();

			//Person tommy = new Person("Tommy", "Ponce", 29);
			//List<Person> owners = new List<Person>();
			//owners.Add(tommy);
			Television tv = new Television("Samsumg", "LmaoTv69", 69, owners, home_data);
			this.tv_instance = tv;

			initInterface();

			this.cron_threads = new List<Thread>();
			try
			{
				initializeCrons();
			}
			catch (Exception e)
			{
				showErrorAndClose(e);
			}
		}

		#region Crons Methods

		/// <summary>
		/// Executes periodic visual updates following the set values in each class
		/// </summary>
		private void updateInterfaceCron()
		{
			while (true)
			{
				try
				{
					Thread.Sleep(interface_updater_refresh_rate);
				}
				catch (ThreadAbortException)
				{
					//	If a thread is being aborted, we'll just ignore the exception, it's normal behaviour
				}
				catch (Exception e)
				{
					showErrorAndClose(e);
				}

				//	Tv power update
				if (tv_instance.isTvOn())
				{
					setPowerButtonOn();
					setButtonAvailability(btnZapChannel, true);
					setButtonAvailability(btnChangeChannel, true);
					setButtonAvailability(btnCurrentChannel, true);
				} else
				{
					setPowerButtonOff();
					setButtonAvailability(btnZapChannel, false);
					setButtonAvailability(btnChangeChannel, false);
					setButtonAvailability(btnCurrentChannel, false);
				}

				//	Channel update
				setChannel(tv_instance.getCurrentChannel());
			}
		}

		#endregion

		#region Functional Methods

		private void btnPower_Click(object sender, EventArgs e)
		{
			tv_instance.togglePower();
		}

		private void btnZapChannel_Click(object sender, EventArgs e)
		{
			if (!tv_instance.isTvOn())
			{
				showTvOffMessage();
				return;
			}

			tv_instance.incrementChannel();
		}

		private void btnChangeChannel_Click(object sender, EventArgs e)
		{
			if (!tv_instance.isTvOn())
			{
				showTvOffMessage();
				return;
			}

			while(true)
			{
				try
				{
					InputChannel input_channel = new InputChannel();
					input_channel.ShowDialog();
					tv_instance.changeToChannel(input_channel.channel_number);
					break;
				}
				catch
				{
					return;
				}
			}
			
		}

		private void btnCurrentChannel_Click(object sender, EventArgs e)
		{
			if (!tv_instance.isTvOn())
			{
				showTvOffMessage();
				return;
			}

			MessageBox.Show(
				$"Current channel: {tv_instance.getCurrentChannel()}",
				"Info",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
				);
		}

		private void btnOwnerDetails_Click(object sender, EventArgs e)
		{
			try
			{
				Person owner = tv_instance.getPersonByName(lvwOwners.SelectedItems[0].Text);
				ShowOwnerData data = new ShowOwnerData(owner);
				data.Show();
			}
			catch (Exception)
			{
				MessageBox.Show(
					$"Please select an owner from the list:",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region System Methods

		/// <summary>
		/// Initializes all data in TV Controller visual interface
		/// </summary>
		private void initInterface()
		{
			//	Initialize power button as Off
			this.setPowerButtonOff();
			//lblAddress.Text = "";

			//	Initialize owners list
			lvwOwners.Items.Clear();
			foreach (Person person in tv_instance.owners)
			{
				lvwOwners.Items.Add(person.name);
			}

			lblAddress.Text = tv_instance.home_data.displayInfo();
		}

		private List<Person> initOwnersData()
		{
			OwnersData new_owners = new OwnersData();
			new_owners.ShowDialog();

			while (new_owners.isNull())
			{
				DialogResult result = MessageBox.Show(
					"Please enter owners data or press cancel to exit",
					"Input required",
					MessageBoxButtons.OKCancel);
				if (result == DialogResult.Cancel)
				{
					Environment.Exit(0);
				}
				new_owners.ShowDialog();
			}

			return new_owners.owners;
		}

		private HomeData initHomeData()
		{

			HomeData home_data = new HomeData();
			home_data.ShowDialog();

			while (home_data.isNull())
			{
				DialogResult result = MessageBox.Show(
					"Please enter home data or press cancel to exit",
					"Input required",
					MessageBoxButtons.OKCancel);
				if (result == DialogResult.Cancel)
				{
					Environment.Exit(0);
				}
				home_data.ShowDialog();
			}

			return home_data;

		}

		private void setPowerButtonOn()
		{

			this.setPowerButtonColor(power_on_color);
		}

		private void setPowerButtonOff()
		{
			this.setPowerButtonColor(power_off_color);
		}

		private void initializeCrons()
		{
			Thread interface_updater_cron = new Thread(() => updateInterfaceCron());
			this.cron_threads.Add(interface_updater_cron);
			foreach (Thread cron in this.cron_threads)
			{
				cron.Start();
			}
		}


		private void showErrorAndClose(Exception e)
		{
			string error = e.Message;

			MessageBox.Show(
				$"There was an error executing the application:\n{error}\n\nProgram will exit now...",
				"Fatal error",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error
				);
			Environment.Exit(-1);
		}

		private void showTvOffMessage()
		{
			MessageBox.Show(
				"Please turn on the TV to perform this operation",
				"Warning!",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning
				);
		}

		private void TVController_FormClosing(object sender, FormClosingEventArgs e)
		{
			exitApplication();
		}

		private void exitApplication()
		{
			try
			{
				foreach (Thread cron in this.cron_threads)
				{
					cron.Abort();
					Thread.Sleep(50);
				}
				Application.Exit();
			}
			catch
			{
				foreach (Thread cron in this.cron_threads)
				{
					cron.Abort();
				}
				Environment.Exit(0);
			}
		}

		#endregion

		#region System Callbacks

		private void setPowerButtonColor((int, int, int) color)
		{
			if (this.btnPower.InvokeRequired)
			{
				SetPowerButtonColorCallback call = new SetPowerButtonColorCallback(setPowerButtonColor);
				this.Invoke(call, new object[] { color });
			}
			else
			{
				btnPower.BackColor = Color.FromArgb(color.Item1, color.Item2, color.Item3);
			}
		}

		public void setChannel(int channel)
		{
			if (this.lblCurrentChannel.InvokeRequired)
			{
				SetchannelCallback call = new SetchannelCallback(setChannel);
				this.Invoke(call, new object[] { channel });
			}
			else
			{
				if (!tv_instance.isTvOn())
				{
					this.lblCurrentChannel.Text = "-";
				}
				else
				{
					this.lblCurrentChannel.Text = channel.ToString();
				}
			}
		}

		public void setButtonAvailability(Button button, bool status)
		{
			if (button.InvokeRequired)
			{
				SetButtonsAvailabilityCallback call = new SetButtonsAvailabilityCallback(setButtonAvailability);
				button.Invoke(call, new object[] { button, status } );
			}
			else
			{
				button.Enabled = status;
			}
		}

		#endregion

	}
}
