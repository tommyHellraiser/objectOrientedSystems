using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Exercise4
{
	public partial class Form1 : Form
	{
		public int number;
		public void setInputNumber(int input)
		{
			this.number = input;
		}
		public Form1()
		{
			InitializeComponent();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			outputLabel.Hide();
			calculate();
		}

		private void calculate()
		{
			//	Show dialog, wait for input to be ready and 
			inputNumber inputBox = new inputNumber();
			new Thread(() => inputBox.ShowDialog()).Start();
			
			//inputBox.ShowDialog();
			startButton.Hide();

			while (!inputBox.isInputReady())
			{
				Thread.Sleep(200);
			}

			int? num1 = inputBox.getNumber();
			if (num1 == null)
			{
				errorLabel.Show();
				return;
			}

			//	Wait for second number to be ready, and run the same thing
			new Thread(() => inputBox.ShowDialog()).Start();

			while (!inputBox.isInputReady())
			{
				Thread.Sleep(200);
			}

			int? num2 = inputBox.getNumber();
			if (num2 == null)
			{
				errorLabel.Show();
				return;
			}

			outputLabel.Show();

			if (num1 > num2)
			{
				outputLabel.Text = $"First number: {num1}\nIs bigger!";
			} 
			else if (num1 < num2)
			{
				outputLabel.Text = $"Second number: {num2}\nIs bigger!";
			}
			else
			{
				outputLabel.Text = $"{num1} = {num2}\nBoth numbers are equal!";
			}
			startButton.Show();
		}
	}
}
