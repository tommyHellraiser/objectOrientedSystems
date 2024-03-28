using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Exercise4
{
	public partial class inputNumber : Form
	{
		private bool inputReady;
		public int? number;
		public inputNumber()
		{
			InitializeComponent();
			inputReady = false;
		}

		public int? getNumber()
		{
			int? temp = number;
			number = null;
			inputReady = false;
			return temp;
		}

		public int getThreadId()
		{
			return Thread.CurrentThread.ManagedThreadId;
		}

		public bool isInputReady()
		{
			return inputReady;
		}

		private void inputBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					number = int.Parse(inputBox1.Text);
				}
				catch
				{
					number = null;
				}

				inputReady = true;
				inputBox1.Clear();
				this.Hide();
			}
		}

		private void inputNumber_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();

			if (e.CloseReason == CloseReason.UserClosing)
			{
				Environment.Exit(-1);

			}
		}
	}
}
