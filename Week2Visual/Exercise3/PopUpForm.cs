using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
	public partial class PopUpForm : Form
	{
		private string inputUpper;
		private string inputLower;

		private const string defaultText = "No input provided";

		public PopUpForm(string inputUpper, string inputLower)
		{
			InitializeComponent();
			//this.inputUpper = inputUpper;
			//this.inputLower = inputLower;

			if (inputUpper == null)
			{
				inputUpper = defaultText;
			}
			if (inputLower == null)
			{
				inputLower = defaultText;
			}

			this.labelUpper.Text = inputUpper;
			this.labelLower.Text = inputLower;

			this.Show();
		}

	}
}
