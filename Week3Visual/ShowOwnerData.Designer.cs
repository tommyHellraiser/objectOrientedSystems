namespace TVController
{
	partial class ShowOwnerData
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
			this.btnAddOwnerConfirm = new System.Windows.Forms.Button();
			this.lblOwnerAge = new System.Windows.Forms.Label();
			this.lblOwnerLastName = new System.Windows.Forms.Label();
			this.lblOwnerName = new System.Windows.Forms.Label();
			this.lblOwnerNameOutput = new System.Windows.Forms.Label();
			this.lblOwnerLastNameOutput = new System.Windows.Forms.Label();
			this.lblOwnerAgeOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAddOwnerConfirm
			// 
			this.btnAddOwnerConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddOwnerConfirm.Location = new System.Drawing.Point(46, 228);
			this.btnAddOwnerConfirm.Name = "btnAddOwnerConfirm";
			this.btnAddOwnerConfirm.Size = new System.Drawing.Size(142, 50);
			this.btnAddOwnerConfirm.TabIndex = 13;
			this.btnAddOwnerConfirm.Text = "OK";
			this.btnAddOwnerConfirm.UseVisualStyleBackColor = true;
			this.btnAddOwnerConfirm.Click += new System.EventHandler(this.btnAddOwnerConfirm_Click);
			// 
			// lblOwnerAge
			// 
			this.lblOwnerAge.AutoSize = true;
			this.lblOwnerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerAge.Location = new System.Drawing.Point(28, 160);
			this.lblOwnerAge.Name = "lblOwnerAge";
			this.lblOwnerAge.Size = new System.Drawing.Size(50, 25);
			this.lblOwnerAge.TabIndex = 9;
			this.lblOwnerAge.Text = "Age";
			// 
			// lblOwnerLastName
			// 
			this.lblOwnerLastName.AutoSize = true;
			this.lblOwnerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerLastName.Location = new System.Drawing.Point(28, 95);
			this.lblOwnerLastName.Name = "lblOwnerLastName";
			this.lblOwnerLastName.Size = new System.Drawing.Size(115, 25);
			this.lblOwnerLastName.TabIndex = 8;
			this.lblOwnerLastName.Text = "Last Name";
			// 
			// lblOwnerName
			// 
			this.lblOwnerName.AutoSize = true;
			this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerName.Location = new System.Drawing.Point(28, 25);
			this.lblOwnerName.Name = "lblOwnerName";
			this.lblOwnerName.Size = new System.Drawing.Size(68, 25);
			this.lblOwnerName.TabIndex = 7;
			this.lblOwnerName.Text = "Name";
			// 
			// lblOwnerNameOutput
			// 
			this.lblOwnerNameOutput.AutoSize = true;
			this.lblOwnerNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOwnerNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerNameOutput.Location = new System.Drawing.Point(26, 50);
			this.lblOwnerNameOutput.Name = "lblOwnerNameOutput";
			this.lblOwnerNameOutput.Size = new System.Drawing.Size(70, 27);
			this.lblOwnerNameOutput.TabIndex = 14;
			this.lblOwnerNameOutput.Text = "Name";
			// 
			// lblOwnerLastNameOutput
			// 
			this.lblOwnerLastNameOutput.AutoSize = true;
			this.lblOwnerLastNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOwnerLastNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerLastNameOutput.Location = new System.Drawing.Point(26, 120);
			this.lblOwnerLastNameOutput.Name = "lblOwnerLastNameOutput";
			this.lblOwnerLastNameOutput.Size = new System.Drawing.Size(70, 27);
			this.lblOwnerLastNameOutput.TabIndex = 15;
			this.lblOwnerLastNameOutput.Text = "Name";
			// 
			// lblOwnerAgeOutput
			// 
			this.lblOwnerAgeOutput.AutoSize = true;
			this.lblOwnerAgeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOwnerAgeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerAgeOutput.Location = new System.Drawing.Point(26, 185);
			this.lblOwnerAgeOutput.Name = "lblOwnerAgeOutput";
			this.lblOwnerAgeOutput.Size = new System.Drawing.Size(70, 27);
			this.lblOwnerAgeOutput.TabIndex = 16;
			this.lblOwnerAgeOutput.Text = "Name";
			// 
			// ShowOwnerData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(222, 297);
			this.Controls.Add(this.lblOwnerAgeOutput);
			this.Controls.Add(this.lblOwnerLastNameOutput);
			this.Controls.Add(this.lblOwnerNameOutput);
			this.Controls.Add(this.btnAddOwnerConfirm);
			this.Controls.Add(this.lblOwnerAge);
			this.Controls.Add(this.lblOwnerLastName);
			this.Controls.Add(this.lblOwnerName);
			this.Name = "ShowOwnerData";
			this.Text = "ShowOwnerData";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddOwnerConfirm;
		private System.Windows.Forms.Label lblOwnerAge;
		private System.Windows.Forms.Label lblOwnerLastName;
		private System.Windows.Forms.Label lblOwnerName;
		private System.Windows.Forms.Label lblOwnerNameOutput;
		private System.Windows.Forms.Label lblOwnerLastNameOutput;
		private System.Windows.Forms.Label lblOwnerAgeOutput;
	}
}