namespace Exercise4
{
	partial class inputNumber
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.inputBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputBox1
			// 
			this.inputBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputBox1.Location = new System.Drawing.Point(38, 70);
			this.inputBox1.Name = "inputBox1";
			this.inputBox1.Size = new System.Drawing.Size(199, 40);
			this.inputBox1.TabIndex = 0;
			this.inputBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox1_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter a number";
			// 
			// inputNumber
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 132);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputBox1);
			this.Name = "inputNumber";
			this.Text = "inputNumber";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inputNumber_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputBox1;
		private System.Windows.Forms.Label label1;
	}
}