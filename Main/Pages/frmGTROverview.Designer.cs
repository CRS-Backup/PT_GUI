
namespace PtGui
{
	partial class frmGTROverview
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGTROverview));
			this.pnlFuelBoost = new System.Windows.Forms.Panel();
			this.lblFuelBoost = new System.Windows.Forms.Label();
			this.pnlPanelTest = new System.Windows.Forms.Panel();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pnlTopInner = new System.Windows.Forms.Panel();
			this.lblPageName = new System.Windows.Forms.Label();
			this.PageFwd = new System.Windows.Forms.PictureBox();
			this.PageBack = new System.Windows.Forms.PictureBox();
			this.pnlFuelTransfer = new System.Windows.Forms.Panel();
			this.lblFuelTransfer = new System.Windows.Forms.Label();
			this.pnlGTLCPPort = new System.Windows.Forms.Panel();
			this.lblGTLCPPort = new System.Windows.Forms.Label();
			this.pnlGTLCPStbd = new System.Windows.Forms.Panel();
			this.lblGTLCPStbd = new System.Windows.Forms.Label();
			this.pnlLubOil = new System.Windows.Forms.Panel();
			this.lblLubOil = new System.Windows.Forms.Label();
			this.pnlLPSW1 = new System.Windows.Forms.Panel();
			this.lbLPSW1 = new System.Windows.Forms.Label();
			this.pnlFuelBoost.SuspendLayout();
			this.pnlPanelTest.SuspendLayout();
			this.pnlTop.SuspendLayout();
			this.pnlTopInner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PageFwd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PageBack)).BeginInit();
			this.pnlFuelTransfer.SuspendLayout();
			this.pnlGTLCPPort.SuspendLayout();
			this.pnlGTLCPStbd.SuspendLayout();
			this.pnlLubOil.SuspendLayout();
			this.pnlLPSW1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFuelBoost
			// 
			this.pnlFuelBoost.BackColor = System.Drawing.Color.Silver;
			this.pnlFuelBoost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFuelBoost.BackgroundImage")));
			this.pnlFuelBoost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlFuelBoost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFuelBoost.Controls.Add(this.lblFuelBoost);
			this.pnlFuelBoost.Location = new System.Drawing.Point(126, 202);
			this.pnlFuelBoost.Name = "pnlFuelBoost";
			this.pnlFuelBoost.Size = new System.Drawing.Size(218, 177);
			this.pnlFuelBoost.TabIndex = 20;
			this.pnlFuelBoost.Click += new System.EventHandler(this.pnlFuelBoost_Click);
			this.pnlFuelBoost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFuelBoost_MouseDown);
			this.pnlFuelBoost.MouseLeave += new System.EventHandler(this.pnlFuelBoost_MouseLeave);
			// 
			// lblFuelBoost
			// 
			this.lblFuelBoost.BackColor = System.Drawing.Color.Transparent;
			this.lblFuelBoost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFuelBoost.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblFuelBoost.Location = new System.Drawing.Point(6, 52);
			this.lblFuelBoost.Name = "lblFuelBoost";
			this.lblFuelBoost.Size = new System.Drawing.Size(199, 64);
			this.lblFuelBoost.TabIndex = 1;
			this.lblFuelBoost.Text = "FUEL BOOST SYSTEM";
			this.lblFuelBoost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFuelBoost.Click += new System.EventHandler(this.pnlFuelBoost_Click);
			this.lblFuelBoost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFuelBoost_MouseDown);
			this.lblFuelBoost.MouseLeave += new System.EventHandler(this.pnlFuelBoost_MouseLeave);
			// 
			// pnlPanelTest
			// 
			this.pnlPanelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.pnlPanelTest.Controls.Add(this.pnlTop);
			this.pnlPanelTest.Controls.Add(this.pnlFuelTransfer);
			this.pnlPanelTest.Controls.Add(this.pnlGTLCPPort);
			this.pnlPanelTest.Controls.Add(this.pnlGTLCPStbd);
			this.pnlPanelTest.Controls.Add(this.pnlLubOil);
			this.pnlPanelTest.Controls.Add(this.pnlLPSW1);
			this.pnlPanelTest.Controls.Add(this.pnlFuelBoost);
			this.pnlPanelTest.Cursor = System.Windows.Forms.Cursors.Default;
			this.pnlPanelTest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pnlPanelTest.Location = new System.Drawing.Point(0, 0);
			this.pnlPanelTest.Name = "pnlPanelTest";
			this.pnlPanelTest.Size = new System.Drawing.Size(1280, 791);
			this.pnlPanelTest.TabIndex = 0;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.White;
			this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlTop.Controls.Add(this.pnlTopInner);
			this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlTop.Location = new System.Drawing.Point(25, 5);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(1229, 96);
			this.pnlTop.TabIndex = 25;
			// 
			// pnlTopInner
			// 
			this.pnlTopInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTopInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
			this.pnlTopInner.Controls.Add(this.lblPageName);
			this.pnlTopInner.Controls.Add(this.PageFwd);
			this.pnlTopInner.Controls.Add(this.PageBack);
			this.pnlTopInner.Location = new System.Drawing.Point(5, 3);
			this.pnlTopInner.Name = "pnlTopInner";
			this.pnlTopInner.Size = new System.Drawing.Size(1219, 87);
			this.pnlTopInner.TabIndex = 0;
			// 
			// lblPageName
			// 
			this.lblPageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPageName.ForeColor = System.Drawing.Color.White;
			this.lblPageName.Location = new System.Drawing.Point(175, 15);
			this.lblPageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPageName.Name = "lblPageName";
			this.lblPageName.Size = new System.Drawing.Size(868, 49);
			this.lblPageName.TabIndex = 2;
			this.lblPageName.Text = "Gas Turbine Room";
			this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PageFwd
			// 
			this.PageFwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
			this.PageFwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageFwd.BackgroundImage")));
			this.PageFwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PageFwd.Location = new System.Drawing.Point(1103, 0);
			this.PageFwd.Name = "PageFwd";
			this.PageFwd.Size = new System.Drawing.Size(116, 87);
			this.PageFwd.TabIndex = 0;
			this.PageFwd.TabStop = false;
			this.PageFwd.Click += new System.EventHandler(this.PageFwd_Click);
			// 
			// PageBack
			// 
			this.PageBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
			this.PageBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageBack.BackgroundImage")));
			this.PageBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PageBack.Location = new System.Drawing.Point(0, 0);
			this.PageBack.Name = "PageBack";
			this.PageBack.Size = new System.Drawing.Size(116, 87);
			this.PageBack.TabIndex = 1;
			this.PageBack.TabStop = false;
			this.PageBack.Click += new System.EventHandler(this.PageBack_Click);
			// 
			// pnlFuelTransfer
			// 
			this.pnlFuelTransfer.BackColor = System.Drawing.Color.Silver;
			this.pnlFuelTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFuelTransfer.BackgroundImage")));
			this.pnlFuelTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlFuelTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFuelTransfer.Controls.Add(this.lblFuelTransfer);
			this.pnlFuelTransfer.Location = new System.Drawing.Point(391, 202);
			this.pnlFuelTransfer.Name = "pnlFuelTransfer";
			this.pnlFuelTransfer.Size = new System.Drawing.Size(218, 177);
			this.pnlFuelTransfer.TabIndex = 24;
			this.pnlFuelTransfer.Click += new System.EventHandler(this.pnlFuelTransfer_Click);
			this.pnlFuelTransfer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFuelTransfer_MouseDown);
			this.pnlFuelTransfer.MouseLeave += new System.EventHandler(this.pnlFuelTransfer_MouseLeave);
			// 
			// lblFuelTransfer
			// 
			this.lblFuelTransfer.BackColor = System.Drawing.Color.Transparent;
			this.lblFuelTransfer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFuelTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblFuelTransfer.Location = new System.Drawing.Point(8, 52);
			this.lblFuelTransfer.Name = "lblFuelTransfer";
			this.lblFuelTransfer.Size = new System.Drawing.Size(199, 64);
			this.lblFuelTransfer.TabIndex = 1;
			this.lblFuelTransfer.Text = "FUEL TRANSFER SYSTEM";
			this.lblFuelTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFuelTransfer.Click += new System.EventHandler(this.pnlFuelTransfer_Click);
			this.lblFuelTransfer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFuelTransfer_MouseDown);
			this.lblFuelTransfer.MouseLeave += new System.EventHandler(this.pnlFuelTransfer_MouseLeave);
			// 
			// pnlGTLCPPort
			// 
			this.pnlGTLCPPort.BackColor = System.Drawing.Color.Silver;
			this.pnlGTLCPPort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGTLCPPort.BackgroundImage")));
			this.pnlGTLCPPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlGTLCPPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlGTLCPPort.Controls.Add(this.lblGTLCPPort);
			this.pnlGTLCPPort.Location = new System.Drawing.Point(391, 434);
			this.pnlGTLCPPort.Name = "pnlGTLCPPort";
			this.pnlGTLCPPort.Size = new System.Drawing.Size(218, 177);
			this.pnlGTLCPPort.TabIndex = 21;
			// 
			// lblGTLCPPort
			// 
			this.lblGTLCPPort.BackColor = System.Drawing.Color.Transparent;
			this.lblGTLCPPort.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGTLCPPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblGTLCPPort.Location = new System.Drawing.Point(23, 52);
			this.lblGTLCPPort.Name = "lblGTLCPPort";
			this.lblGTLCPPort.Size = new System.Drawing.Size(169, 64);
			this.lblGTLCPPort.TabIndex = 1;
			this.lblGTLCPPort.Text = "GAS TURBINE LCP PORT";
			this.lblGTLCPPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlGTLCPStbd
			// 
			this.pnlGTLCPStbd.BackColor = System.Drawing.Color.Silver;
			this.pnlGTLCPStbd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGTLCPStbd.BackgroundImage")));
			this.pnlGTLCPStbd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlGTLCPStbd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlGTLCPStbd.Controls.Add(this.lblGTLCPStbd);
			this.pnlGTLCPStbd.Location = new System.Drawing.Point(656, 434);
			this.pnlGTLCPStbd.Name = "pnlGTLCPStbd";
			this.pnlGTLCPStbd.Size = new System.Drawing.Size(218, 177);
			this.pnlGTLCPStbd.TabIndex = 21;
			// 
			// lblGTLCPStbd
			// 
			this.lblGTLCPStbd.BackColor = System.Drawing.Color.Transparent;
			this.lblGTLCPStbd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGTLCPStbd.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblGTLCPStbd.Location = new System.Drawing.Point(19, 52);
			this.lblGTLCPStbd.Name = "lblGTLCPStbd";
			this.lblGTLCPStbd.Size = new System.Drawing.Size(175, 64);
			this.lblGTLCPStbd.TabIndex = 1;
			this.lblGTLCPStbd.Text = "GAS TURBINE LCP STBD";
			this.lblGTLCPStbd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlLubOil
			// 
			this.pnlLubOil.BackColor = System.Drawing.Color.Silver;
			this.pnlLubOil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLubOil.BackgroundImage")));
			this.pnlLubOil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlLubOil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLubOil.Controls.Add(this.lblLubOil);
			this.pnlLubOil.Location = new System.Drawing.Point(656, 202);
			this.pnlLubOil.Name = "pnlLubOil";
			this.pnlLubOil.Size = new System.Drawing.Size(218, 177);
			this.pnlLubOil.TabIndex = 21;
			this.pnlLubOil.Click += new System.EventHandler(this.pnlLubOil_Click);
			this.pnlLubOil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLubOil_MouseDown);
			this.pnlLubOil.MouseLeave += new System.EventHandler(this.pnlLubOil_MouseLeave);
			// 
			// lblLubOil
			// 
			this.lblLubOil.BackColor = System.Drawing.Color.Transparent;
			this.lblLubOil.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLubOil.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblLubOil.Location = new System.Drawing.Point(8, 52);
			this.lblLubOil.Name = "lblLubOil";
			this.lblLubOil.Size = new System.Drawing.Size(199, 64);
			this.lblLubOil.TabIndex = 1;
			this.lblLubOil.Text = "MAIN LUB OIL SYSTEM";
			this.lblLubOil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLubOil.Click += new System.EventHandler(this.pnlLubOil_Click);
			this.lblLubOil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLubOil_MouseDown);
			this.lblLubOil.MouseLeave += new System.EventHandler(this.pnlLubOil_MouseLeave);
			// 
			// pnlLPSW1
			// 
			this.pnlLPSW1.BackColor = System.Drawing.Color.Silver;
			this.pnlLPSW1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLPSW1.BackgroundImage")));
			this.pnlLPSW1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlLPSW1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLPSW1.Controls.Add(this.lbLPSW1);
			this.pnlLPSW1.Location = new System.Drawing.Point(921, 202);
			this.pnlLPSW1.Name = "pnlLPSW1";
			this.pnlLPSW1.Size = new System.Drawing.Size(218, 177);
			this.pnlLPSW1.TabIndex = 21;
			this.pnlLPSW1.Click += new System.EventHandler(this.pnlLPSW1_Click);
			this.pnlLPSW1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLPSW1_MouseDown);
			this.pnlLPSW1.MouseLeave += new System.EventHandler(this.pnlLPSW1_MouseLeave);
			// 
			// lbLPSW1
			// 
			this.lbLPSW1.BackColor = System.Drawing.Color.Transparent;
			this.lbLPSW1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLPSW1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbLPSW1.Location = new System.Drawing.Point(33, 52);
			this.lbLPSW1.Name = "lbLPSW1";
			this.lbLPSW1.Size = new System.Drawing.Size(146, 64);
			this.lbLPSW1.TabIndex = 1;
			this.lbLPSW1.Text = "LPSW1 SYSTEM";
			this.lbLPSW1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbLPSW1.Click += new System.EventHandler(this.pnlLPSW1_Click);
			this.lbLPSW1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLPSW1_MouseDown);
			this.lbLPSW1.MouseLeave += new System.EventHandler(this.pnlLPSW1_MouseLeave);
			// 
			// frmGTROverview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 791);
			this.ControlBox = false;
			this.Controls.Add(this.pnlPanelTest);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmGTROverview";
			this.Text = "GTR Overview";
			this.pnlFuelBoost.ResumeLayout(false);
			this.pnlPanelTest.ResumeLayout(false);
			this.pnlTop.ResumeLayout(false);
			this.pnlTopInner.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PageFwd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PageBack)).EndInit();
			this.pnlFuelTransfer.ResumeLayout(false);
			this.pnlGTLCPPort.ResumeLayout(false);
			this.pnlGTLCPStbd.ResumeLayout(false);
			this.pnlLubOil.ResumeLayout(false);
			this.pnlLPSW1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlFuelBoost;
		private System.Windows.Forms.Label lblFuelBoost;
		private System.Windows.Forms.Panel pnlPanelTest;
		private System.Windows.Forms.Panel pnlGTLCPPort;
		private System.Windows.Forms.Label lblGTLCPPort;
		private System.Windows.Forms.Panel pnlGTLCPStbd;
		private System.Windows.Forms.Label lblGTLCPStbd;
		private System.Windows.Forms.Panel pnlLubOil;
		private System.Windows.Forms.Label lblLubOil;
		private System.Windows.Forms.Panel pnlLPSW1;
		private System.Windows.Forms.Label lbLPSW1;
		private System.Windows.Forms.Panel pnlFuelTransfer;
		private System.Windows.Forms.Label lblFuelTransfer;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlTopInner;
		private System.Windows.Forms.Label lblPageName;
		private System.Windows.Forms.PictureBox PageFwd;
		private System.Windows.Forms.PictureBox PageBack;
	}
}