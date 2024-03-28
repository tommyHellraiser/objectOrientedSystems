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
	public partial class Form1 : Form
	{
		private string inputUpper;
		private string inputLower;

		public Form1()
		{
			InitializeComponent();
		}

		private void inputBox1_TextChanged(object sender, EventArgs e)
		{
			this.inputUpper = inputBox1.Text;
		}

		private void inputBox2_TextChanged(object sender, EventArgs e)
		{
			this.inputLower = inputBox2.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form popUpForm = new PopUpForm(inputUpper, inputLower);
			inputBox1.Clear();
			inputBox2.Clear();
		}
	}
}
