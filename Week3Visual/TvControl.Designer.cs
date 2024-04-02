namespace TVController
{
	partial class TVController
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Hola");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Que onda");
			this.btnPower = new System.Windows.Forms.Button();
			this.btnZapChannel = new System.Windows.Forms.Button();
			this.btnChangeChannel = new System.Windows.Forms.Button();
			this.btnCurrentChannel = new System.Windows.Forms.Button();
			this.lblCurrentChannelText = new System.Windows.Forms.Label();
			this.lblCurrentChannel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lvwOwners = new System.Windows.Forms.ListView();
			this.lblOwners = new System.Windows.Forms.Label();
			this.btnOwnerDetails = new System.Windows.Forms.Button();
			this.lblAddressText = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPower
			// 
			this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPower.Location = new System.Drawing.Point(288, 12);
			this.btnPower.Name = "btnPower";
			this.btnPower.Size = new System.Drawing.Size(215, 53);
			this.btnPower.TabIndex = 0;
			this.btnPower.Text = "Power";
			this.btnPower.UseVisualStyleBackColor = false;
			this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
			// 
			// btnZapChannel
			// 
			this.btnZapChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnZapChannel.Location = new System.Drawing.Point(288, 71);
			this.btnZapChannel.Name = "btnZapChannel";
			this.btnZapChannel.Size = new System.Drawing.Size(215, 53);
			this.btnZapChannel.TabIndex = 1;
			this.btnZapChannel.Text = "Zap Channel";
			this.btnZapChannel.UseVisualStyleBackColor = true;
			this.btnZapChannel.Click += new System.EventHandler(this.btnZapChannel_Click);
			// 
			// btnChangeChannel
			// 
			this.btnChangeChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangeChannel.Location = new System.Drawing.Point(288, 130);
			this.btnChangeChannel.Name = "btnChangeChannel";
			this.btnChangeChannel.Size = new System.Drawing.Size(215, 53);
			this.btnChangeChannel.TabIndex = 2;
			this.btnChangeChannel.Text = "Change Channel To";
			this.btnChangeChannel.UseVisualStyleBackColor = true;
			this.btnChangeChannel.Click += new System.EventHandler(this.btnChangeChannel_Click);
			// 
			// btnCurrentChannel
			// 
			this.btnCurrentChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCurrentChannel.Location = new System.Drawing.Point(288, 189);
			this.btnCurrentChannel.Name = "btnCurrentChannel";
			this.btnCurrentChannel.Size = new System.Drawing.Size(215, 53);
			this.btnCurrentChannel.TabIndex = 3;
			this.btnCurrentChannel.Text = "Current Channel";
			this.btnCurrentChannel.UseVisualStyleBackColor = true;
			this.btnCurrentChannel.Click += new System.EventHandler(this.btnCurrentChannel_Click);
			// 
			// lblCurrentChannelText
			// 
			this.lblCurrentChannelText.AutoSize = true;
			this.lblCurrentChannelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentChannelText.Location = new System.Drawing.Point(21, 23);
			this.lblCurrentChannelText.Name = "lblCurrentChannelText";
			this.lblCurrentChannelText.Size = new System.Drawing.Size(193, 29);
			this.lblCurrentChannelText.TabIndex = 4;
			this.lblCurrentChannelText.Text = "Current Channel:";
			// 
			// lblCurrentChannel
			// 
			this.lblCurrentChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCurrentChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentChannel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblCurrentChannel.Location = new System.Drawing.Point(58, 71);
			this.lblCurrentChannel.Name = "lblCurrentChannel";
			this.lblCurrentChannel.Size = new System.Drawing.Size(107, 57);
			this.lblCurrentChannel.TabIndex = 5;
			this.lblCurrentChannel.Text = "120";
			this.lblCurrentChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(7, 254);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(503, 2);
			this.label1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 29);
			this.label2.TabIndex = 7;
			this.label2.Text = "Home details";
			// 
			// lvwOwners
			// 
			this.lvwOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvwOwners.HideSelection = false;
			this.lvwOwners.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lvwOwners.Location = new System.Drawing.Point(12, 322);
			this.lvwOwners.Name = "lvwOwners";
			this.lvwOwners.Size = new System.Drawing.Size(139, 83);
			this.lvwOwners.TabIndex = 9;
			this.lvwOwners.UseCompatibleStateImageBehavior = false;
			this.lvwOwners.View = System.Windows.Forms.View.List;
			// 
			// lblOwners
			// 
			this.lblOwners.AutoSize = true;
			this.lblOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOwners.Location = new System.Drawing.Point(12, 294);
			this.lblOwners.Name = "lblOwners";
			this.lblOwners.Size = new System.Drawing.Size(85, 25);
			this.lblOwners.TabIndex = 10;
			this.lblOwners.Text = "Owners";
			// 
			// btnOwnerDetails
			// 
			this.btnOwnerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOwnerDetails.Location = new System.Drawing.Point(12, 415);
			this.btnOwnerDetails.Name = "btnOwnerDetails";
			this.btnOwnerDetails.Size = new System.Drawing.Size(139, 23);
			this.btnOwnerDetails.TabIndex = 11;
			this.btnOwnerDetails.Text = "View owner details";
			this.btnOwnerDetails.UseVisualStyleBackColor = true;
			this.btnOwnerDetails.Click += new System.EventHandler(this.btnOwnerDetails_Click);
			// 
			// lblAddressText
			// 
			this.lblAddressText.AutoSize = true;
			this.lblAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddressText.Location = new System.Drawing.Point(283, 294);
			this.lblAddressText.Name = "lblAddressText";
			this.lblAddressText.Size = new System.Drawing.Size(91, 25);
			this.lblAddressText.TabIndex = 12;
			this.lblAddressText.Text = "Address";
			// 
			// lblAddress
			// 
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(283, 322);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(220, 83);
			this.lblAddress.TabIndex = 13;
			this.lblAddress.Text = "Address example..";
			// 
			// TVController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(522, 450);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblAddressText);
			this.Controls.Add(this.btnOwnerDetails);
			this.Controls.Add(this.lblOwners);
			this.Controls.Add(this.lvwOwners);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblCurrentChannel);
			this.Controls.Add(this.lblCurrentChannelText);
			this.Controls.Add(this.btnCurrentChannel);
			this.Controls.Add(this.btnChangeChannel);
			this.Controls.Add(this.btnZapChannel);
			this.Controls.Add(this.btnPower);
			this.Name = "TVController";
			this.Text = "TVController";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TVController_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPower;
		private System.Windows.Forms.Button btnZapChannel;
		private System.Windows.Forms.Button btnChangeChannel;
		private System.Windows.Forms.Button btnCurrentChannel;
		private System.Windows.Forms.Label lblCurrentChannelText;
		private System.Windows.Forms.Label lblCurrentChannel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lvwOwners;
		private System.Windows.Forms.Label lblOwners;
		private System.Windows.Forms.Button btnOwnerDetails;
		private System.Windows.Forms.Label lblAddressText;
		private System.Windows.Forms.Label lblAddress;
	}
}

