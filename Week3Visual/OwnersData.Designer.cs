namespace TVController
{
	partial class OwnersData
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
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Hola");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Que onda");
			this.lvwOwners = new System.Windows.Forms.ListView();
			this.lblOwners = new System.Windows.Forms.Label();
			this.btnAddOwner = new System.Windows.Forms.Button();
			this.btnOwnersReady = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvwOwners
			// 
			this.lvwOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvwOwners.HideSelection = false;
			this.lvwOwners.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
			listViewItem3,
			listViewItem4});
			this.lvwOwners.Location = new System.Drawing.Point(31, 51);
			this.lvwOwners.Name = "lvwOwners";
			this.lvwOwners.Size = new System.Drawing.Size(139, 83);
			this.lvwOwners.TabIndex = 10;
			this.lvwOwners.UseCompatibleStateImageBehavior = false;
			this.lvwOwners.View = System.Windows.Forms.View.List;
			// 
			// lblOwners
			// 
			this.lblOwners.AutoSize = true;
			this.lblOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwners.Location = new System.Drawing.Point(53, 9);
			this.lblOwners.Name = "lblOwners";
			this.lblOwners.Size = new System.Drawing.Size(85, 25);
			this.lblOwners.TabIndex = 11;
			this.lblOwners.Text = "Owners";
			// 
			// btnAddOwner
			// 
			this.btnAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddOwner.Location = new System.Drawing.Point(31, 152);
			this.btnAddOwner.Name = "btnAddOwner";
			this.btnAddOwner.Size = new System.Drawing.Size(139, 44);
			this.btnAddOwner.TabIndex = 12;
			this.btnAddOwner.Text = "Add owner";
			this.btnAddOwner.UseVisualStyleBackColor = true;
			this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
			// 
			// btnOwnersReady
			// 
			this.btnOwnersReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOwnersReady.Location = new System.Drawing.Point(31, 202);
			this.btnOwnersReady.Name = "btnOwnersReady";
			this.btnOwnersReady.Size = new System.Drawing.Size(139, 44);
			this.btnOwnersReady.TabIndex = 13;
			this.btnOwnersReady.Text = "Ready!";
			this.btnOwnersReady.UseVisualStyleBackColor = true;
			this.btnOwnersReady.Click += new System.EventHandler(this.btnOwnersReady_Click);
			// 
			// OwnersData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(195, 270);
			this.Controls.Add(this.btnOwnersReady);
			this.Controls.Add(this.btnAddOwner);
			this.Controls.Add(this.lblOwners);
			this.Controls.Add(this.lvwOwners);
			this.Name = "OwnersData";
			this.Text = "Owners Data";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvwOwners;
		private System.Windows.Forms.Label lblOwners;
		private System.Windows.Forms.Button btnAddOwner;
		private System.Windows.Forms.Button btnOwnersReady;
	}
}