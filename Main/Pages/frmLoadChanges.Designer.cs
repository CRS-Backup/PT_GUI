
namespace PtGui
{
	partial class frmLoadChanges
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadChanges));
			this.lblLABEL1 = new System.Windows.Forms.Label();
			this.pnlCANCEL = new System.Windows.Forms.Panel();
			this.lblCANCEL = new System.Windows.Forms.Label();
			this.pnl800kW = new System.Windows.Forms.Panel();
			this.lbl800kWb = new System.Windows.Forms.Label();
			this.lbl800kWa = new System.Windows.Forms.Label();
			this.pnl1000kW = new System.Windows.Forms.Panel();
			this.lbl1000kW = new System.Windows.Forms.Label();
			this.pnl1200kW = new System.Windows.Forms.Panel();
			this.lbl1200kW = new System.Windows.Forms.Label();
			this.pnl1400kW = new System.Windows.Forms.Panel();
			this.lbl1400kW = new System.Windows.Forms.Label();
			this.pnlCANCEL.SuspendLayout();
			this.pnl800kW.SuspendLayout();
			this.pnl1000kW.SuspendLayout();
			this.pnl1200kW.SuspendLayout();
			this.pnl1400kW.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLABEL1
			// 
			this.lblLABEL1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLABEL1.ForeColor = System.Drawing.Color.White;
			this.lblLABEL1.Location = new System.Drawing.Point(43, 51);
			this.lblLABEL1.Name = "lblLABEL1";
			this.lblLABEL1.Size = new System.Drawing.Size(167, 114);
			this.lblLABEL1.TabIndex = 0;
			this.lblLABEL1.Text = "Electrical Block Load Changes";
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
			// pnl800kW
			// 
			this.pnl800kW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl800kW.BackgroundImage")));
			this.pnl800kW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnl800kW.Controls.Add(this.lbl800kWb);
			this.pnl800kW.Controls.Add(this.lbl800kWa);
			this.pnl800kW.Location = new System.Drawing.Point(262, 36);
			this.pnl800kW.Name = "pnl800kW";
			this.pnl800kW.Size = new System.Drawing.Size(150, 149);
			this.pnl800kW.TabIndex = 4;
			this.pnl800kW.Click += new System.EventHandler(this.lbl800kW_Click);
			// 
			// lbl800kWb
			// 
			this.lbl800kWb.AutoSize = true;
			this.lbl800kWb.BackColor = System.Drawing.Color.Transparent;
			this.lbl800kWb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl800kWb.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl800kWb.Location = new System.Drawing.Point(53, 90);
			this.lbl800kWb.Name = "lbl800kWb";
			this.lbl800kWb.Size = new System.Drawing.Size(46, 20);
			this.lbl800kWb.TabIndex = 1;
			this.lbl800kWb.Text = "Base";
			this.lbl800kWb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl800kWa
			// 
			this.lbl800kWa.AutoSize = true;
			this.lbl800kWa.BackColor = System.Drawing.Color.Transparent;
			this.lbl800kWa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl800kWa.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl800kWa.Location = new System.Drawing.Point(32, 59);
			this.lbl800kWa.Name = "lbl800kWa";
			this.lbl800kWa.Size = new System.Drawing.Size(92, 29);
			this.lbl800kWa.TabIndex = 0;
			this.lbl800kWa.Text = "800 kW";
			this.lbl800kWa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl800kWa.Click += new System.EventHandler(this.lbl800kW_Click);
			// 
			// pnl1000kW
			// 
			this.pnl1000kW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1000kW.BackgroundImage")));
			this.pnl1000kW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnl1000kW.Controls.Add(this.lbl1000kW);
			this.pnl1000kW.Location = new System.Drawing.Point(450, 36);
			this.pnl1000kW.Name = "pnl1000kW";
			this.pnl1000kW.Size = new System.Drawing.Size(150, 149);
			this.pnl1000kW.TabIndex = 5;
			this.pnl1000kW.Click += new System.EventHandler(this.lbl1000kW_Click);
			// 
			// lbl1000kW
			// 
			this.lbl1000kW.AutoSize = true;
			this.lbl1000kW.BackColor = System.Drawing.Color.Transparent;
			this.lbl1000kW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1000kW.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl1000kW.Location = new System.Drawing.Point(25, 59);
			this.lbl1000kW.Name = "lbl1000kW";
			this.lbl1000kW.Size = new System.Drawing.Size(105, 29);
			this.lbl1000kW.TabIndex = 0;
			this.lbl1000kW.Text = "1000 kW";
			this.lbl1000kW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl1000kW.Click += new System.EventHandler(this.lbl1000kW_Click);
			// 
			// pnl1200kW
			// 
			this.pnl1200kW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1200kW.BackgroundImage")));
			this.pnl1200kW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnl1200kW.Controls.Add(this.lbl1200kW);
			this.pnl1200kW.Location = new System.Drawing.Point(638, 36);
			this.pnl1200kW.Name = "pnl1200kW";
			this.pnl1200kW.Size = new System.Drawing.Size(150, 149);
			this.pnl1200kW.TabIndex = 6;
			this.pnl1200kW.Click += new System.EventHandler(this.lbl1200kW_Click);
			// 
			// lbl1200kW
			// 
			this.lbl1200kW.AutoSize = true;
			this.lbl1200kW.BackColor = System.Drawing.Color.Transparent;
			this.lbl1200kW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1200kW.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl1200kW.Location = new System.Drawing.Point(25, 59);
			this.lbl1200kW.Name = "lbl1200kW";
			this.lbl1200kW.Size = new System.Drawing.Size(105, 29);
			this.lbl1200kW.TabIndex = 0;
			this.lbl1200kW.Text = "1200 kW";
			this.lbl1200kW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl1200kW.Click += new System.EventHandler(this.lbl1200kW_Click);
			// 
			// pnl1400kW
			// 
			this.pnl1400kW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1400kW.BackgroundImage")));
			this.pnl1400kW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnl1400kW.Controls.Add(this.lbl1400kW);
			this.pnl1400kW.Location = new System.Drawing.Point(826, 36);
			this.pnl1400kW.Name = "pnl1400kW";
			this.pnl1400kW.Size = new System.Drawing.Size(150, 149);
			this.pnl1400kW.TabIndex = 7;
			this.pnl1400kW.Click += new System.EventHandler(this.lbl1400kW_Click);
			// 
			// lbl1400kW
			// 
			this.lbl1400kW.AutoSize = true;
			this.lbl1400kW.BackColor = System.Drawing.Color.Transparent;
			this.lbl1400kW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1400kW.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl1400kW.Location = new System.Drawing.Point(26, 59);
			this.lbl1400kW.Name = "lbl1400kW";
			this.lbl1400kW.Size = new System.Drawing.Size(105, 29);
			this.lbl1400kW.TabIndex = 0;
			this.lbl1400kW.Text = "1400 kW";
			this.lbl1400kW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl1400kW.Click += new System.EventHandler(this.lbl1400kW_Click);
			// 
			// frmLoadChanges
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1280, 229);
			this.Controls.Add(this.pnl1400kW);
			this.Controls.Add(this.pnl1200kW);
			this.Controls.Add(this.pnl1000kW);
			this.Controls.Add(this.pnl800kW);
			this.Controls.Add(this.pnlCANCEL);
			this.Controls.Add(this.lblLABEL1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLoadChanges";
			this.pnlCANCEL.ResumeLayout(false);
			this.pnl800kW.ResumeLayout(false);
			this.pnl800kW.PerformLayout();
			this.pnl1000kW.ResumeLayout(false);
			this.pnl1000kW.PerformLayout();
			this.pnl1200kW.ResumeLayout(false);
			this.pnl1200kW.PerformLayout();
			this.pnl1400kW.ResumeLayout(false);
			this.pnl1400kW.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblLABEL1;
		private System.Windows.Forms.Panel pnlCANCEL;
		private System.Windows.Forms.Label lblCANCEL;
		private System.Windows.Forms.Panel pnl800kW;
		private System.Windows.Forms.Label lbl800kWb;
		private System.Windows.Forms.Label lbl800kWa;
		private System.Windows.Forms.Panel pnl1000kW;
		private System.Windows.Forms.Label lbl1000kW;
		private System.Windows.Forms.Panel pnl1200kW;
		private System.Windows.Forms.Label lbl1200kW;
		private System.Windows.Forms.Panel pnl1400kW;
		private System.Windows.Forms.Label lbl1400kW;
    }
}