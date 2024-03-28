namespace Exercise3
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
			this.label1 = new System.Windows.Forms.Label();
			this.inputBox1 = new System.Windows.Forms.TextBox();
			this.inputBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(102, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter stuff down here";
			// 
			// inputBox1
			// 
			this.inputBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.inputBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputBox1.Location = new System.Drawing.Point(138, 130);
			this.inputBox1.Name = "inputBox1";
			this.inputBox1.Size = new System.Drawing.Size(200, 40);
			this.inputBox1.TabIndex = 1;
			this.inputBox1.TextChanged += new System.EventHandler(this.inputBox1_TextChanged);
			// 
			// inputBox2
			// 
			this.inputBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.inputBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputBox2.Location = new System.Drawing.Point(138, 204);
			this.inputBox2.Name = "inputBox2";
			this.inputBox2.Size = new System.Drawing.Size(200, 40);
			this.inputBox2.TabIndex = 2;
			this.inputBox2.TextChanged += new System.EventHandler(this.inputBox2_TextChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(151, 293);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 62);
			this.button1.TabIndex = 3;
			this.button1.Text = "Show!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 449);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inputBox2);
			this.Controls.Add(this.inputBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputBox1;
		private System.Windows.Forms.TextBox inputBox2;
		private System.Windows.Forms.Button button1;
	}
}

