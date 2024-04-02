namespace TVController
{
	partial class Person
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person));
			this.lblOwnerName = new System.Windows.Forms.Label();
			this.lblOwnerLastName = new System.Windows.Forms.Label();
			this.lblOwnerAge = new System.Windows.Forms.Label();
			this.txtOwnerName = new System.Windows.Forms.TextBox();
			this.txtOwnerLastName = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.btnAddOwnerConfirm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblOwnerName
			// 
			this.lblOwnerName.AutoSize = true;
			this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerName.Location = new System.Drawing.Point(35, 24);
			this.lblOwnerName.Name = "lblOwnerName";
			this.lblOwnerName.Size = new System.Drawing.Size(68, 25);
			this.lblOwnerName.TabIndex = 0;
			this.lblOwnerName.Text = "Name";
			// 
			// lblOwnerLastName
			// 
			this.lblOwnerLastName.AutoSize = true;
			this.lblOwnerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerLastName.Location = new System.Drawing.Point(35, 105);
			this.lblOwnerLastName.Name = "lblOwnerLastName";
			this.lblOwnerLastName.Size = new System.Drawing.Size(115, 25);
			this.lblOwnerLastName.TabIndex = 1;
			this.lblOwnerLastName.Text = "Last Name";
			// 
			// lblOwnerAge
			// 
			this.lblOwnerAge.AutoSize = true;
			this.lblOwnerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwnerAge.Location = new System.Drawing.Point(35, 187);
			this.lblOwnerAge.Name = "lblOwnerAge";
			this.lblOwnerAge.Size = new System.Drawing.Size(50, 25);
			this.lblOwnerAge.TabIndex = 2;
			this.lblOwnerAge.Text = "Age";
			// 
			// txtOwnerName
			// 
			this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOwnerName.Location = new System.Drawing.Point(40, 52);
			this.txtOwnerName.Name = "txtOwnerName";
			this.txtOwnerName.Size = new System.Drawing.Size(200, 31);
			this.txtOwnerName.TabIndex = 3;
			this.txtOwnerName.TextChanged += new System.EventHandler(this.txtOwnerName_TextChanged);
			// 
			// txtOwnerLastName
			// 
			this.txtOwnerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOwnerLastName.Location = new System.Drawing.Point(40, 133);
			this.txtOwnerLastName.Name = "txtOwnerLastName";
			this.txtOwnerLastName.Size = new System.Drawing.Size(200, 31);
			this.txtOwnerLastName.TabIndex = 4;
			this.txtOwnerLastName.TextChanged += new System.EventHandler(this.txtOwnerLastName_TextChanged);
			// 
			// txtAge
			// 
			this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAge.Location = new System.Drawing.Point(40, 215);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(200, 31);
			this.txtAge.TabIndex = 5;
			this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
			// 
			// btnAddOwnerConfirm
			// 
			this.btnAddOwnerConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddOwnerConfirm.Location = new System.Drawing.Point(66, 278);
			this.btnAddOwnerConfirm.Name = "btnAddOwnerConfirm";
			this.btnAddOwnerConfirm.Size = new System.Drawing.Size(142, 50);
			this.btnAddOwnerConfirm.TabIndex = 6;
			this.btnAddOwnerConfirm.Text = "Confirm!";
			this.btnAddOwnerConfirm.UseVisualStyleBackColor = true;
			this.btnAddOwnerConfirm.Click += new System.EventHandler(this.btnAddOwnerConfirm_Click);
			// 
			// Person
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(280, 354);
			this.Controls.Add(this.btnAddOwnerConfirm);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtOwnerLastName);
			this.Controls.Add(this.txtOwnerName);
			this.Controls.Add(this.lblOwnerAge);
			this.Controls.Add(this.lblOwnerLastName);
			this.Controls.Add(this.lblOwnerName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Person";
			this.Text = "Owner";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOwnerName;
		private System.Windows.Forms.Label lblOwnerLastName;
		private System.Windows.Forms.Label lblOwnerAge;
		private System.Windows.Forms.TextBox txtOwnerName;
		private System.Windows.Forms.TextBox txtOwnerLastName;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Button btnAddOwnerConfirm;
	}
}