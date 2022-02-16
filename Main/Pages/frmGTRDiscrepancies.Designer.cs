
namespace PtGui
{
	partial class frmGTRDiscrepancies
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGTRDiscrepancies));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pnlTopInner = new System.Windows.Forms.Panel();
			this.lblPageName = new System.Windows.Forms.Label();
			this.PageBack = new System.Windows.Forms.PictureBox();
			this.PageFwd = new System.Windows.Forms.PictureBox();
			this.pnlPanelTest = new System.Windows.Forms.Panel();
			this.pnlBackground = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlAccept = new System.Windows.Forms.Panel();
			this.lblAccept = new System.Windows.Forms.Label();
			this.pnlTop.SuspendLayout();
			this.pnlTopInner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PageBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PageFwd)).BeginInit();
			this.pnlPanelTest.SuspendLayout();
			this.pnlBackground.SuspendLayout();
			this.pnlAccept.SuspendLayout();
			this.SuspendLayout();
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
			this.pnlTop.TabIndex = 1;
			// 
			// pnlTopInner
			// 
			this.pnlTopInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTopInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
			this.pnlTopInner.Controls.Add(this.lblPageName);
			this.pnlTopInner.Controls.Add(this.PageBack);
			this.pnlTopInner.Controls.Add(this.PageFwd);
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
			this.lblPageName.Location = new System.Drawing.Point(175, 19);
			this.lblPageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPageName.Name = "lblPageName";
			this.lblPageName.Size = new System.Drawing.Size(868, 49);
			this.lblPageName.TabIndex = 2;
			this.lblPageName.Text = "GTR Hardware Discrepancies";
			this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PageBack
			// 
			this.PageBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
			this.PageBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageBack.BackgroundImage")));
			this.PageBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PageBack.Location = new System.Drawing.Point(1103, 0);
			this.PageBack.Name = "PageBack";
			this.PageBack.Size = new System.Drawing.Size(116, 87);
			this.PageBack.TabIndex = 0;
			this.PageBack.TabStop = false;
			this.PageBack.Click += new System.EventHandler(this.PageFwd_Click);
			// 
			// PageFwd
			// 
			this.PageFwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
			this.PageFwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageFwd.BackgroundImage")));
			this.PageFwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PageFwd.Location = new System.Drawing.Point(0, 0);
			this.PageFwd.Name = "PageFwd";
			this.PageFwd.Size = new System.Drawing.Size(116, 87);
			this.PageFwd.TabIndex = 1;
			this.PageFwd.TabStop = false;
			this.PageFwd.Click += new System.EventHandler(this.PageBack_Click);
			// 
			// pnlPanelTest
			// 
			this.pnlPanelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.pnlPanelTest.Controls.Add(this.pnlTop);
			this.pnlPanelTest.Cursor = System.Windows.Forms.Cursors.Default;
			this.pnlPanelTest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pnlPanelTest.Location = new System.Drawing.Point(0, 0);
			this.pnlPanelTest.Name = "pnlPanelTest";
			this.pnlPanelTest.Size = new System.Drawing.Size(1280, 791);
			this.pnlPanelTest.TabIndex = 0;
			// 
			// pnlBackground
			// 
			this.pnlBackground.BackColor = System.Drawing.Color.LightGray;
			this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlBackground.Controls.Add(this.label10);
			this.pnlBackground.Controls.Add(this.label9);
			this.pnlBackground.Controls.Add(this.label8);
			this.pnlBackground.Controls.Add(this.label7);
			this.pnlBackground.Controls.Add(this.label6);
			this.pnlBackground.Controls.Add(this.label2);
			this.pnlBackground.Controls.Add(this.label4);
			this.pnlBackground.Controls.Add(this.label3);
			this.pnlBackground.Controls.Add(this.label5);
			this.pnlBackground.Controls.Add(this.label1);
			this.pnlBackground.Controls.Add(this.pnlAccept);
			this.pnlBackground.Location = new System.Drawing.Point(371, 143);
			this.pnlBackground.Name = "pnlBackground";
			this.pnlBackground.Size = new System.Drawing.Size(520, 558);
			this.pnlBackground.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label10.Location = new System.Drawing.Point(27, 245);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(309, 22);
			this.label10.TabIndex = 10;
			this.label10.Text = "MANUAL CONTROL INCORRECT";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label9.Location = new System.Drawing.Point(27, 220);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(400, 22);
			this.label9.TabIndex = 9;
			this.label9.Text = "EMERGENCY TRIP LEVER SHOULD BE UP";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label8.Location = new System.Drawing.Point(27, 195);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(433, 22);
			this.label8.TabIndex = 8;
			this.label8.Text = "EMERGENCY TRIP LEVER SHOULD BE DOWN";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(27, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(305, 22);
			this.label7.TabIndex = 7;
			this.label7.Text = "REMOTE INSTRUMENT SWITCH";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(27, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(484, 22);
			this.label6.TabIndex = 6;
			this.label6.Text = "IGNITION ISOLATE SWITCH SHOULD BE AT IGN ISO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(27, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "LOCAL/REMOTE SWITCH";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(27, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(467, 22);
			this.label4.TabIndex = 4;
			this.label4.Text = "IGNITION ISOLATE SWITCH SHOULD BE NORMAL";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(27, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "START/STOP SWITCH";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(27, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(466, 22);
			this.label5.TabIndex = 2;
			this.label5.Text = "IGNITION ISOLATE SWITCH SHOULD BE TRIP O/R";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(27, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "24V POWER SWITCH";
			// 
			// pnlAccept
			// 
			this.pnlAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAccept.BackgroundImage")));
			this.pnlAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlAccept.Controls.Add(this.lblAccept);
			this.pnlAccept.Location = new System.Drawing.Point(72, 472);
			this.pnlAccept.Name = "pnlAccept";
			this.pnlAccept.Size = new System.Drawing.Size(377, 75);
			this.pnlAccept.TabIndex = 0;
			// 
			// lblAccept
			// 
			this.lblAccept.AutoSize = true;
			this.lblAccept.BackColor = System.Drawing.Color.Transparent;
			this.lblAccept.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccept.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblAccept.Location = new System.Drawing.Point(33, 27);
			this.lblAccept.Name = "lblAccept";
			this.lblAccept.Size = new System.Drawing.Size(318, 22);
			this.lblAccept.TabIndex = 0;
			this.lblAccept.Text = "Accept Hardware Discrepancies?";
			// 
			// frmGTRDiscrepancies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 791);
			this.ControlBox = false;
			this.Controls.Add(this.pnlBackground);
			this.Controls.Add(this.pnlPanelTest);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmGTRDiscrepancies";
			this.Text = "GTR Discrepancies";
			this.pnlTop.ResumeLayout(false);
			this.pnlTopInner.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PageBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PageFwd)).EndInit();
			this.pnlPanelTest.ResumeLayout(false);
			this.pnlBackground.ResumeLayout(false);
			this.pnlBackground.PerformLayout();
			this.pnlAccept.ResumeLayout(false);
			this.pnlAccept.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox PageBack;
		private System.Windows.Forms.PictureBox PageFwd;
		private System.Windows.Forms.Panel pnlPanelTest;
		private System.Windows.Forms.Panel pnlTopInner;
		private System.Windows.Forms.Label lblPageName;
		private System.Windows.Forms.Panel pnlBackground;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlAccept;
		private System.Windows.Forms.Label lblAccept;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
	}
}