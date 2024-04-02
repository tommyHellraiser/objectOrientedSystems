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
	public partial class ShowOwnerData : Form
	{
		Person owner_to_show;

		public ShowOwnerData(Person owner)
		{
			InitializeComponent();

			owner_to_show = owner;
			lblOwnerNameOutput.Text = owner_to_show.name;
			lblOwnerLastNameOutput.Text = owner_to_show.last_name;
			lblOwnerAgeOutput.Text = owner_to_show.age.ToString();
		}

		private void btnAddOwnerConfirm_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
