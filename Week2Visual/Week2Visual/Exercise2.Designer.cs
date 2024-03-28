namespace Week2Visual
{
	partial class Exercise2
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.documentLabel = new System.Windows.Forms.Label();
			this.nameInputBox = new System.Windows.Forms.TextBox();
			this.lastNameInputBox = new System.Windows.Forms.TextBox();
			this.documentInputBox = new System.Windows.Forms.TextBox();
			this.enterButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.Location = new System.Drawing.Point(67, 68);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(103, 37);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameLabel.Location = new System.Drawing.Point(67, 179);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(173, 37);
			this.lastNameLabel.TabIndex = 1;
			this.lastNameLabel.Text = "Last Name";
			// 
			// documentLabel
			// 
			this.documentLabel.AutoSize = true;
			this.documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.documentLabel.Location = new System.Drawing.Point(67, 288);
			this.documentLabel.Name = "documentLabel";
			this.documentLabel.Size = new System.Drawing.Size(163, 37);
			this.documentLabel.TabIndex = 2;
			this.documentLabel.Text = "Document";
			// 
			// nameInputBox
			// 
			this.nameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameInputBox.Location = new System.Drawing.Point(297, 65);
			this.nameInputBox.Name = "nameInputBox";
			this.nameInputBox.Size = new System.Drawing.Size(217, 44);
			this.nameInputBox.TabIndex = 3;
			// 
			// lastNameInputBox
			// 
			this.lastNameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameInputBox.Location = new System.Drawing.Point(297, 176);
			this.lastNameInputBox.Name = "lastNameInputBox";
			this.lastNameInputBox.Size = new System.Drawing.Size(217, 44);
			this.lastNameInputBox.TabIndex = 4;
			// 
			// documentInputBox
			// 
			this.documentInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.documentInputBox.Location = new System.Drawing.Point(297, 285);
			this.documentInputBox.Name = "documentInputBox";
			this.documentInputBox.Size = new System.Drawing.Size(217, 44);
			this.documentInputBox.TabIndex = 5;
			// 
			// enterButton
			// 
			this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterButton.Location = new System.Drawing.Point(574, 57);
			this.enterButton.Name = "enterButton";
			this.enterButton.Size = new System.Drawing.Size(177, 59);
			this.enterButton.TabIndex = 6;
			this.enterButton.Text = "Enter";
			this.enterButton.UseVisualStyleBackColor = true;
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(574, 168);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(177, 59);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			// 
			// InputData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.documentInputBox);
			this.Controls.Add(this.lastNameInputBox);
			this.Controls.Add(this.nameInputBox);
			this.Controls.Add(this.documentLabel);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.nameLabel);
			this.Name = "InputData";
			this.Text = "InputData";
			this.Load += new System.EventHandler(this.InputData_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label documentLabel;
		private System.Windows.Forms.TextBox nameInputBox;
		private System.Windows.Forms.TextBox lastNameInputBox;
		private System.Windows.Forms.TextBox documentInputBox;
		private System.Windows.Forms.Button enterButton;
		private System.Windows.Forms.Button resetButton;
	}
}