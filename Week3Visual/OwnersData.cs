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
	public partial class OwnersData : Form
	{
		internal List<Person> owners { get; set; }

		public OwnersData()
		{
			InitializeComponent();
			lvwOwners.Items.Clear();
			owners = new List<Person>();
		}

		public bool isNull()
		{
			return owners.Count == 0;
		}

		private void btnAddOwner_Click(object sender, EventArgs e)
		{
			while (true)
			{
				try
				{
					Person new_owner = new Person();
					new_owner.ShowDialog();
					Person new_person = new_owner;

					if (new_person.name == null)
					{
						return;
					}

					owners.Add(new_person);
					lvwOwners.Items.Add(new_person.name.ToString());

					return;
				}
				catch
				{
					MessageBox.Show(
						"Please enter required owners",
						"Warning",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
			}
		}

		private void btnOwnersReady_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
