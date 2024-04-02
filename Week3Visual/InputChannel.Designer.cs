namespace TVController
{
	partial class InputChannel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputChannel));
			this.lblEnterChannelText = new System.Windows.Forms.Label();
			this.txtEnterChannel = new System.Windows.Forms.TextBox();
			this.btnOkButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblEnterChannelText
			// 
			this.lblEnterChannelText.AutoSize = true;
			this.lblEnterChannelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnterChannelText.Location = new System.Drawing.Point(36, 9);
			this.lblEnterChannelText.Name = "lblEnterChannelText";
			this.lblEnterChannelText.Size = new System.Drawing.Size(145, 25);
			this.lblEnterChannelText.TabIndex = 0;
			this.lblEnterChannelText.Text = "Enter channel";
			// 
			// txtEnterChannel
			// 
			this.txtEnterChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnterChannel.Location = new System.Drawing.Point(32, 50);
			this.txtEnterChannel.Name = "txtEnterChannel";
			this.txtEnterChannel.Size = new System.Drawing.Size(158, 31);
			this.txtEnterChannel.TabIndex = 1;
			this.txtEnterChannel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnterChannel_KeyDown);
			// 
			// btnOkButton
			// 
			this.btnOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOkButton.Location = new System.Drawing.Point(70, 96);
			this.btnOkButton.Name = "btnOkButton";
			this.btnOkButton.Size = new System.Drawing.Size(75, 23);
			this.btnOkButton.TabIndex = 2;
			this.btnOkButton.Text = "OK";
			this.btnOkButton.UseVisualStyleBackColor = true;
			this.btnOkButton.Click += new System.EventHandler(this.btnOkButton_Click);
			// 
			// InputChannel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 140);
			this.Controls.Add(this.btnOkButton);
			this.Controls.Add(this.txtEnterChannel);
			this.Controls.Add(this.lblEnterChannelText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InputChannel";
			this.Text = "InputChannel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnterChannelText;
		private System.Windows.Forms.TextBox txtEnterChannel;
		private System.Windows.Forms.Button btnOkButton;
	}
}