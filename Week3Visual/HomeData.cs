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
	public partial class HomeData : Form
	{
		string street_name;
		string street_number;
		string city;
		string province;
		string country;
		int? floor_number;
		int? apt_number;

		public bool isNull()
		{
			return this.street_name == null;
		}

		public HomeData()
		{
			InitializeComponent();
		}

		internal string displayInfo()
		{
			string info = $"{street_name} st, n° {street_number}\n";

			if (floor_number != null)
			{
				info += $"Floor {floor_number}";
			}

			if (apt_number != null)
			{
				info += $", apt. {apt_number}\n";
			}

			info += $"{city}, {province}, {country}";

			//return $"{street_name} st, n° {street_number}\nFloor {floor_number}, apt. {apt_number}\n{city}, {province}, {country}";
			return info;
		}

		private void btnHomeDataConfirm_Click(object sender, EventArgs e)
		{
			
			if (!inputFieldsValid())
			{
				return;
			}

			this.street_name = txtStreetName.Text;
			this.street_number = txtStreetNumber.Text;
			this.city = txtCity.Text;
			this.province = txtProvince.Text;
			this.country = txtCountry.Text;
			
			if (txtFloorNumber.Text != "")
			try
			{
				this.floor_number = int.Parse(txtFloorNumber.Text);
			}
			catch
			{
				MessageBox.Show(
					"Please enter a valid input",
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}

			if (txtApartmentNumber.Text != "")
			try
			{
				this.apt_number = int.Parse(txtApartmentNumber.Text);
			}
			catch
			{
				MessageBox.Show(
					"Please enter a valid input",
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}

			this.Hide();
		}

		private bool inputFieldsValid()
		{
			if (txtStreetName.Text == "" || txtStreetNumber.Text == "" || txtCity.Text == "" || txtProvince.Text == "" || txtCountry.Text == "")
			{
				MessageBox.Show(
					"Please enter required fields",
					"Warning",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				return false;
			}

			return true;
		}
	}
}
