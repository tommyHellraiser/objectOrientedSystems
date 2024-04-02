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
	public partial class Person : Form
	{
		internal string name { get; set; }
		internal string last_name { get; set; }
		internal int age { get; set; }


		public Person()
		{
			InitializeComponent();
		}

		private void txtOwnerName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtOwnerLastName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAge_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnAddOwnerConfirm_Click(object sender, EventArgs e)
		{
			name = txtOwnerName.Text;
			last_name = txtOwnerLastName.Text;
			
			try
			{
				age = int.Parse(txtAge.Text);
				if (age < 0 || age > 150)
				{
					throw new ArgumentOutOfRangeException();
				}

				this.Hide();
			}
			catch
			{
				MessageBox.Show(
					"Please enter a valid age",
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}
	}
}
