using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVController
{
	public partial class InputChannel : Form
	{
		public int channel_number { get; set; }
		public InputChannel()
		{
			InitializeComponent();
		}

		private void txtEnterChannel_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				attemptChangeChannel();
			}
		}

		private void btnOkButton_Click(object sender, EventArgs e)
		{
			attemptChangeChannel();
		}

		private void attemptChangeChannel()
		{
			try
			{
				if (txtEnterChannel.Text == "")
				{
					throw new NoNullAllowedException();
				}
				int input = int.Parse(txtEnterChannel.Text);
				if (input < 1 || input > 150)
				{
					throw new ArgumentOutOfRangeException();
				}

				this.channel_number = int.Parse(txtEnterChannel.Text);
				this.Hide();
			}
			catch (NoNullAllowedException)
			{
				MessageBox.Show(
					"Please enter a channel",
					"Channel Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
					);
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show(
					"Invalid cahnnel entered",
					"Channel Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
					);
			}
			catch
			{
				MessageBox.Show(
					"Invalid datatype entered",
					"Type Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
					);
			}
		}
	}
}
