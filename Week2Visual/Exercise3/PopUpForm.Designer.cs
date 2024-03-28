namespace Exercise3
{
	partial class PopUpForm
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
			this.labelUpper = new System.Windows.Forms.Label();
			this.labelLower = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelUpper
			// 
			this.labelUpper.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUpper.Location = new System.Drawing.Point(54, 59);
			this.labelUpper.Name = "labelUpper";
			this.labelUpper.Size = new System.Drawing.Size(274, 37);
			this.labelUpper.TabIndex = 0;
			this.labelUpper.Text = "example text";
			this.labelUpper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelLower
			// 
			this.labelLower.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLower.Location = new System.Drawing.Point(54, 150);
			this.labelLower.Name = "labelLower";
			this.labelLower.Size = new System.Drawing.Size(274, 37);
			this.labelLower.TabIndex = 0;
			this.labelLower.Text = "example text";
			this.labelLower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PopUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 281);
			this.Controls.Add(this.labelLower);
			this.Controls.Add(this.labelUpper);
			this.Name = "PopUpForm";
			this.Text = "PopUpForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelUpper;
		private System.Windows.Forms.Label labelLower;
	}
}