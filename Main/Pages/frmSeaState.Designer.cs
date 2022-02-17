
namespace PtGui
{
	partial class frmSeaState
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeaState));
			this.lblLABEL1 = new System.Windows.Forms.Label();
			this.pnlCANCEL = new System.Windows.Forms.Panel();
			this.lblCANCEL = new System.Windows.Forms.Label();
			this.pnlCalm = new System.Windows.Forms.Panel();
			this.lblCalm = new System.Windows.Forms.Label();
			this.pnlAverage = new System.Windows.Forms.Panel();
			this.lblAverage = new System.Windows.Forms.Label();
			this.pnlRough = new System.Windows.Forms.Panel();
			this.lblRough = new System.Windows.Forms.Label();
			this.lbl800kWb = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlCANCEL.SuspendLayout();
			this.pnlCalm.SuspendLayout();
			this.pnlAverage.SuspendLayout();
			this.pnlRough.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLABEL1
			// 
			this.lblLABEL1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLABEL1.ForeColor = System.Drawing.Color.White;
			this.lblLABEL1.Location = new System.Drawing.Point(73, 51);
			this.lblLABEL1.Name = "lblLABEL1";
			this.lblLABEL1.Size = new System.Drawing.Size(84, 114);
			this.lblLABEL1.TabIndex = 0;
			this.lblLABEL1.Text = "Set Sea State";
			this.lblLABEL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlCANCEL
			// 
			this.pnlCANCEL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCANCEL.BackgroundImage")));
			this.pnlCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlCANCEL.Controls.Add(this.lblCANCEL);
			this.pnlCANCEL.Location = new System.Drawing.Point(1119, 19);
			this.pnlCANCEL.Name = "pnlCANCEL";
			this.pnlCANCEL.Size = new System.Drawing.Size(102, 185);
			this.pnlCANCEL.TabIndex = 3;
			this.pnlCANCEL.Click += new System.EventHandler(this.pnlCANCEL_Click);
			// 
			// lblCANCEL
			// 
			this.lblCANCEL.BackColor = System.Drawing.Color.Transparent;
			this.lblCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCANCEL.ForeColor = System.Drawing.Color.White;
			this.lblCANCEL.Location = new System.Drawing.Point(11, 74);
			this.lblCANCEL.Name = "lblCANCEL";
			this.lblCANCEL.Size = new System.Drawing.Size(78, 37);
			this.lblCANCEL.TabIndex = 4;
			this.lblCANCEL.Text = "Cancel";
			this.lblCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCANCEL.Click += new System.EventHandler(this.pnlCANCEL_Click);
			// 
			// pnlCalm
			// 
			this.pnlCalm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCalm.BackgroundImage")));
			this.pnlCalm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlCalm.Controls.Add(this.lbl800kWb);
			this.pnlCalm.Controls.Add(this.lblCalm);
			this.pnlCalm.Location = new System.Drawing.Point(335, 36);
			this.pnlCalm.Name = "pnlCalm";
			this.pnlCalm.Size = new System.Drawing.Size(150, 149);
			this.pnlCalm.TabIndex = 4;
			this.pnlCalm.Click += new System.EventHandler(this.pnlCalm_Click);
			// 
			// lblCalm
			// 
			this.lblCalm.AutoSize = true;
			this.lblCalm.BackColor = System.Drawing.Color.Transparent;
			this.lblCalm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalm.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblCalm.Location = new System.Drawing.Point(42, 51);
			this.lblCalm.Name = "lblCalm";
			this.lblCalm.Size = new System.Drawing.Size(69, 29);
			this.lblCalm.TabIndex = 0;
			this.lblCalm.Text = "Calm";
			this.lblCalm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCalm.Click += new System.EventHandler(this.pnlCalm_Click);
			// 
			// pnlAverage
			// 
			this.pnlAverage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAverage.BackgroundImage")));
			this.pnlAverage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlAverage.Controls.Add(this.label1);
			this.pnlAverage.Controls.Add(this.lblAverage);
			this.pnlAverage.Location = new System.Drawing.Point(523, 36);
			this.pnlAverage.Name = "pnlAverage";
			this.pnlAverage.Size = new System.Drawing.Size(150, 149);
			this.pnlAverage.TabIndex = 5;
			this.pnlAverage.Click += new System.EventHandler(this.pnlAverage_Click);
			// 
			// lblAverage
			// 
			this.lblAverage.AutoSize = true;
			this.lblAverage.BackColor = System.Drawing.Color.Transparent;
			this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAverage.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblAverage.Location = new System.Drawing.Point(25, 51);
			this.lblAverage.Name = "lblAverage";
			this.lblAverage.Size = new System.Drawing.Size(102, 29);
			this.lblAverage.TabIndex = 0;
			this.lblAverage.Text = "Average";
			this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAverage.Click += new System.EventHandler(this.pnlAverage_Click);
			// 
			// pnlRough
			// 
			this.pnlRough.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRough.BackgroundImage")));
			this.pnlRough.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlRough.Controls.Add(this.label2);
			this.pnlRough.Controls.Add(this.lblRough);
			this.pnlRough.Location = new System.Drawing.Point(711, 36);
			this.pnlRough.Name = "pnlRough";
			this.pnlRough.Size = new System.Drawing.Size(150, 149);
			this.pnlRough.TabIndex = 6;
			this.pnlRough.Click += new System.EventHandler(this.pnlRough_Click);
			// 
			// lblRough
			// 
			this.lblRough.AutoSize = true;
			this.lblRough.BackColor = System.Drawing.Color.Transparent;
			this.lblRough.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRough.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblRough.Location = new System.Drawing.Point(33, 51);
			this.lblRough.Name = "lblRough";
			this.lblRough.Size = new System.Drawing.Size(84, 29);
			this.lblRough.TabIndex = 0;
			this.lblRough.Text = "Rough";
			this.lblRough.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRough.Click += new System.EventHandler(this.pnlRough_Click);
			// 
			// lbl800kWb
			// 
			this.lbl800kWb.AutoSize = true;
			this.lbl800kWb.BackColor = System.Drawing.Color.Transparent;
			this.lbl800kWb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl800kWb.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl800kWb.Location = new System.Drawing.Point(56, 90);
			this.lbl800kWb.Name = "lbl800kWb";
			this.lbl800kWb.Size = new System.Drawing.Size(40, 20);
			this.lbl800kWb.TabIndex = 1;
			this.lbl800kWb.Text = "0 - 2";
			this.lbl800kWb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl800kWb.Click += new System.EventHandler(this.pnlCalm_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(56, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "3 - 5";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.pnlAverage_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(55, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "6 - 8";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.pnlRough_Click);
			// 
			// frmSeaState
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1280, 229);
			this.Controls.Add(this.pnlRough);
			this.Controls.Add(this.pnlAverage);
			this.Controls.Add(this.pnlCalm);
			this.Controls.Add(this.pnlCANCEL);
			this.Controls.Add(this.lblLABEL1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSeaState";
			this.pnlCANCEL.ResumeLayout(false);
			this.pnlCalm.ResumeLayout(false);
			this.pnlCalm.PerformLayout();
			this.pnlAverage.ResumeLayout(false);
			this.pnlAverage.PerformLayout();
			this.pnlRough.ResumeLayout(false);
			this.pnlRough.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblLABEL1;
		private System.Windows.Forms.Panel pnlCANCEL;
		private System.Windows.Forms.Label lblCANCEL;
		private System.Windows.Forms.Panel pnlCalm;
		private System.Windows.Forms.Label lblCalm;
		private System.Windows.Forms.Panel pnlAverage;
		private System.Windows.Forms.Label lblAverage;
		private System.Windows.Forms.Panel pnlRough;
		private System.Windows.Forms.Label lblRough;
		private System.Windows.Forms.Label lbl800kWb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}