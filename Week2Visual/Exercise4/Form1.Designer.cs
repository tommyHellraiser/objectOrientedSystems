namespace Exercise4
{
	partial class Form1
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
			this.startButton = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.outputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(140, 224);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(165, 67);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start!";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLabel.Location = new System.Drawing.Point(71, 179);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(322, 67);
			this.errorLabel.TabIndex = 1;
			this.errorLabel.Text = "Error in execution. Please close the app";
			this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.errorLabel.Visible = false;
			// 
			// outputLabel
			// 
			this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputLabel.Location = new System.Drawing.Point(71, 154);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(322, 67);
			this.outputLabel.TabIndex = 2;
			this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.outputLabel.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 450);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.errorLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.Label outputLabel;
	}
}

