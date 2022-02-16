
namespace PtGui
{
	partial class frmActiveMalfunctions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActiveMalfunctions));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pnlTopInner = new System.Windows.Forms.Panel();
			this.lblPageName = new System.Windows.Forms.Label();
			this.PageBack = new System.Windows.Forms.PictureBox();
			this.PageFwd = new System.Windows.Forms.PictureBox();
			this.pnlPanelTest = new System.Windows.Forms.Panel();
			this.pnlTop.SuspendLayout();
			this.pnlTopInner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PageBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PageFwd)).BeginInit();
			this.pnlPanelTest.SuspendLayout();
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
			this.lblPageName.Text = "Active Malfunctions";
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
			// frmActiveMalfunctions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 791);
			this.ControlBox = false;
			this.Controls.Add(this.pnlPanelTest);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmActiveMalfunctions";
			this.Text = "Active Malfunctions";
			this.pnlTop.ResumeLayout(false);
			this.pnlTopInner.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PageBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PageFwd)).EndInit();
			this.pnlPanelTest.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox PageBack;
		private System.Windows.Forms.PictureBox PageFwd;
		private System.Windows.Forms.Panel pnlPanelTest;
		private System.Windows.Forms.Panel pnlTopInner;
		private System.Windows.Forms.Label lblPageName;
	}
}