
namespace PtGui
{
	partial class frmNumberKeypad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumberKeypad));
            this.pnlCANCEL = new System.Windows.Forms.Panel();
            this.lblCANCEL = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMin = new System.Windows.Forms.Panel();
            this.lblCrsFrmNumKeyMin = new CRSControlsLib.CrsLabel();
            this.lblMin = new System.Windows.Forms.Label();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.lblCrsFrmNumKeyVal = new CRSControlsLib.CrsLabel();
            this.lblValueText = new System.Windows.Forms.Label();
            this.pnlMax = new System.Windows.Forms.Panel();
            this.lblCrsFrmNumKeyMax = new CRSControlsLib.CrsLabel();
            this.lblMax = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblCrsFrmNumKeyTitle = new CRSControlsLib.CrsLabel();
            this.pnlEnter = new System.Windows.Forms.Panel();
            this.lblEnter = new System.Windows.Forms.Label();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.lblDelete = new System.Windows.Forms.Label();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.lblClear = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.lbl4 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.lbl5 = new System.Windows.Forms.Label();
            this.pnlPlusMinus = new System.Windows.Forms.Panel();
            this.lblPlusMinus = new System.Windows.Forms.Label();
            this.pnlPoint = new System.Windows.Forms.Panel();
            this.lbPoint = new System.Windows.Forms.Label();
            this.pnl0 = new System.Windows.Forms.Panel();
            this.lbl0 = new System.Windows.Forms.Label();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.lbl9 = new System.Windows.Forms.Label();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.lbl7 = new System.Windows.Forms.Label();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.lbl6 = new System.Windows.Forms.Label();
            this.pnlCANCEL.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMin.SuspendLayout();
            this.pnlValue.SuspendLayout();
            this.pnlMax.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlEnter.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlClear.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.pnl5.SuspendLayout();
            this.pnlPlusMinus.SuspendLayout();
            this.pnlPoint.SuspendLayout();
            this.pnl0.SuspendLayout();
            this.pnl9.SuspendLayout();
            this.pnl8.SuspendLayout();
            this.pnl7.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCANCEL
            // 
            this.pnlCANCEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCANCEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCANCEL.Controls.Add(this.lblCANCEL);
            this.pnlCANCEL.Location = new System.Drawing.Point(825, 115);
            this.pnlCANCEL.Name = "pnlCANCEL";
            this.pnlCANCEL.Size = new System.Drawing.Size(142, 114);
            this.pnlCANCEL.TabIndex = 3;
            this.pnlCANCEL.Click += new System.EventHandler(this.pnlCANCEL_Click);
            // 
            // lblCANCEL
            // 
            this.lblCANCEL.BackColor = System.Drawing.Color.Transparent;
            this.lblCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCANCEL.ForeColor = System.Drawing.Color.White;
            this.lblCANCEL.Location = new System.Drawing.Point(30, 38);
            this.lblCANCEL.Name = "lblCANCEL";
            this.lblCANCEL.Size = new System.Drawing.Size(78, 37);
            this.lblCANCEL.TabIndex = 4;
            this.lblCANCEL.Text = "Cancel";
            this.lblCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCANCEL.Click += new System.EventHandler(this.pnlCANCEL_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.pnlMin);
            this.pnlMain.Controls.Add(this.pnlValue);
            this.pnlMain.Controls.Add(this.pnlMax);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Location = new System.Drawing.Point(967, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(312, 228);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlMin
            // 
            this.pnlMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMin.Controls.Add(this.lblCrsFrmNumKeyMin);
            this.pnlMin.Controls.Add(this.lblMin);
            this.pnlMin.Location = new System.Drawing.Point(11, 118);
            this.pnlMin.Name = "pnlMin";
            this.pnlMin.Size = new System.Drawing.Size(286, 42);
            this.pnlMin.TabIndex = 2;
            // 
            // lblCrsFrmNumKeyMin
            // 
            this.lblCrsFrmNumKeyMin.BackColor = System.Drawing.Color.Silver;
            this.lblCrsFrmNumKeyMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrsFrmNumKeyMin.CrsChanNumOrAlias = "t_frmNumKeyMin";
            this.lblCrsFrmNumKeyMin.CrsChanValue = "\"<none>\"";
            this.lblCrsFrmNumKeyMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrsFrmNumKeyMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrsFrmNumKeyMin.Location = new System.Drawing.Point(199, 1);
            this.lblCrsFrmNumKeyMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrsFrmNumKeyMin.Name = "lblCrsFrmNumKeyMin";
            this.lblCrsFrmNumKeyMin.Size = new System.Drawing.Size(79, 37);
            this.lblCrsFrmNumKeyMin.TabIndex = 47;
            this.lblCrsFrmNumKeyMin.Text = "-20\'C";
            this.lblCrsFrmNumKeyMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMin.Location = new System.Drawing.Point(8, 7);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(95, 24);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minimum";
            // 
            // pnlValue
            // 
            this.pnlValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlValue.Controls.Add(this.lblCrsFrmNumKeyVal);
            this.pnlValue.Controls.Add(this.lblValueText);
            this.pnlValue.Location = new System.Drawing.Point(11, 171);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Size = new System.Drawing.Size(286, 42);
            this.pnlValue.TabIndex = 2;
            // 
            // lblCrsFrmNumKeyVal
            // 
            this.lblCrsFrmNumKeyVal.BackColor = System.Drawing.Color.Silver;
            this.lblCrsFrmNumKeyVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrsFrmNumKeyVal.CrsChanNumOrAlias = "t_frmNumKeyVal";
            this.lblCrsFrmNumKeyVal.CrsChanValue = "\"<none>\"";
            this.lblCrsFrmNumKeyVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrsFrmNumKeyVal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrsFrmNumKeyVal.Location = new System.Drawing.Point(199, 1);
            this.lblCrsFrmNumKeyVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrsFrmNumKeyVal.Name = "lblCrsFrmNumKeyVal";
            this.lblCrsFrmNumKeyVal.Size = new System.Drawing.Size(79, 37);
            this.lblCrsFrmNumKeyVal.TabIndex = 47;
            this.lblCrsFrmNumKeyVal.Text = "0\'C";
            this.lblCrsFrmNumKeyVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValueText
            // 
            this.lblValueText.AutoSize = true;
            this.lblValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValueText.Location = new System.Drawing.Point(8, 7);
            this.lblValueText.Name = "lblValueText";
            this.lblValueText.Size = new System.Drawing.Size(64, 24);
            this.lblValueText.TabIndex = 3;
            this.lblValueText.Text = "Value";
            // 
            // pnlMax
            // 
            this.pnlMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMax.Controls.Add(this.lblCrsFrmNumKeyMax);
            this.pnlMax.Controls.Add(this.lblMax);
            this.pnlMax.Location = new System.Drawing.Point(11, 65);
            this.pnlMax.Name = "pnlMax";
            this.pnlMax.Size = new System.Drawing.Size(286, 42);
            this.pnlMax.TabIndex = 1;
            // 
            // lblCrsFrmNumKeyMax
            // 
            this.lblCrsFrmNumKeyMax.BackColor = System.Drawing.Color.Silver;
            this.lblCrsFrmNumKeyMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrsFrmNumKeyMax.CrsChanNumOrAlias = "t_frmNumKeyMax";
            this.lblCrsFrmNumKeyMax.CrsChanValue = "\"<none>\"";
            this.lblCrsFrmNumKeyMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrsFrmNumKeyMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrsFrmNumKeyMax.Location = new System.Drawing.Point(199, 1);
            this.lblCrsFrmNumKeyMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrsFrmNumKeyMax.Name = "lblCrsFrmNumKeyMax";
            this.lblCrsFrmNumKeyMax.Size = new System.Drawing.Size(79, 37);
            this.lblCrsFrmNumKeyMax.TabIndex = 46;
            this.lblCrsFrmNumKeyMax.Text = "60\'C";
            this.lblCrsFrmNumKeyMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMax.Location = new System.Drawing.Point(8, 7);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 24);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Maximum";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblCrsFrmNumKeyTitle);
            this.pnlTitle.Location = new System.Drawing.Point(11, 9);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(286, 126);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblCrsFrmNumKeyTitle
            // 
            this.lblCrsFrmNumKeyTitle.BackColor = System.Drawing.Color.Silver;
            this.lblCrsFrmNumKeyTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrsFrmNumKeyTitle.CrsChanNumOrAlias = "t_frmNumKeyTitle";
            this.lblCrsFrmNumKeyTitle.CrsChanValue = "\"<none>\"";
            this.lblCrsFrmNumKeyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrsFrmNumKeyTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrsFrmNumKeyTitle.Location = new System.Drawing.Point(6, 9);
            this.lblCrsFrmNumKeyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrsFrmNumKeyTitle.Name = "lblCrsFrmNumKeyTitle";
            this.lblCrsFrmNumKeyTitle.Size = new System.Drawing.Size(273, 37);
            this.lblCrsFrmNumKeyTitle.TabIndex = 45;
            this.lblCrsFrmNumKeyTitle.Text = "Title";
            this.lblCrsFrmNumKeyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEnter
            // 
            this.pnlEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnter.Controls.Add(this.lblEnter);
            this.pnlEnter.Location = new System.Drawing.Point(825, 1);
            this.pnlEnter.Name = "pnlEnter";
            this.pnlEnter.Size = new System.Drawing.Size(142, 114);
            this.pnlEnter.TabIndex = 5;
            this.pnlEnter.Click += new System.EventHandler(this.pnlEnter_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.BackColor = System.Drawing.Color.Transparent;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(30, 38);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(78, 37);
            this.lblEnter.TabIndex = 4;
            this.lblEnter.Text = "Enter";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnter.Click += new System.EventHandler(this.pnlEnter_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.Cyan;
            this.pnlDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDelete.Controls.Add(this.lblDelete);
            this.pnlDelete.Location = new System.Drawing.Point(696, 1);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(128, 114);
            this.pnlDelete.TabIndex = 7;
            this.pnlDelete.Click += new System.EventHandler(this.pnlDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Black;
            this.lblDelete.Location = new System.Drawing.Point(24, 38);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(78, 37);
            this.lblDelete.TabIndex = 4;
            this.lblDelete.Text = "Delete";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Click += new System.EventHandler(this.pnlDelete_Click);
            // 
            // pnlClear
            // 
            this.pnlClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Controls.Add(this.lblClear);
            this.pnlClear.Location = new System.Drawing.Point(696, 115);
            this.pnlClear.Name = "pnlClear";
            this.pnlClear.Size = new System.Drawing.Size(128, 114);
            this.pnlClear.TabIndex = 6;
            this.pnlClear.Click += new System.EventHandler(this.pnlClear_Click);
            // 
            // lblClear
            // 
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Black;
            this.lblClear.Location = new System.Drawing.Point(24, 38);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(78, 37);
            this.lblClear.TabIndex = 4;
            this.lblClear.Text = "Clear";
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClear.Click += new System.EventHandler(this.pnlClear_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1.BackgroundImage")));
            this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Location = new System.Drawing.Point(0, 1);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(114, 114);
            this.pnl1.TabIndex = 9;
            this.pnl1.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(41, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(26, 29);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl2
            // 
            this.pnl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl2.BackgroundImage")));
            this.pnl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl2.Controls.Add(this.lbl2);
            this.pnl2.Location = new System.Drawing.Point(116, 1);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(114, 114);
            this.pnl2.TabIndex = 10;
            this.pnl2.Click += new System.EventHandler(this.pnl2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(43, 42);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(26, 29);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "2";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.pnl2_Click);
            // 
            // pnl3
            // 
            this.pnl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl3.BackgroundImage")));
            this.pnl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl3.Controls.Add(this.lbl3);
            this.pnl3.Location = new System.Drawing.Point(232, 1);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(114, 114);
            this.pnl3.TabIndex = 11;
            this.pnl3.Click += new System.EventHandler(this.pnl3_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(41, 42);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(26, 29);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "3";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Click += new System.EventHandler(this.pnl3_Click);
            // 
            // pnl4
            // 
            this.pnl4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl4.BackgroundImage")));
            this.pnl4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl4.Controls.Add(this.lbl4);
            this.pnl4.Location = new System.Drawing.Point(348, 1);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(114, 114);
            this.pnl4.TabIndex = 12;
            this.pnl4.Click += new System.EventHandler(this.pnl4_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(44, 42);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(26, 29);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "4";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Click += new System.EventHandler(this.pnl4_Click);
            // 
            // pnl5
            // 
            this.pnl5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl5.BackgroundImage")));
            this.pnl5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl5.Controls.Add(this.lbl5);
            this.pnl5.Location = new System.Drawing.Point(464, 1);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(114, 114);
            this.pnl5.TabIndex = 13;
            this.pnl5.Click += new System.EventHandler(this.pnl5_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(43, 42);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(26, 29);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "5";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5.Click += new System.EventHandler(this.pnl5_Click);
            // 
            // pnlPlusMinus
            // 
            this.pnlPlusMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPlusMinus.BackgroundImage")));
            this.pnlPlusMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlusMinus.Controls.Add(this.lblPlusMinus);
            this.pnlPlusMinus.Location = new System.Drawing.Point(580, 1);
            this.pnlPlusMinus.Name = "pnlPlusMinus";
            this.pnlPlusMinus.Size = new System.Drawing.Size(114, 114);
            this.pnlPlusMinus.TabIndex = 14;
            this.pnlPlusMinus.Click += new System.EventHandler(this.pnlPlusMinus_Click);
            // 
            // lblPlusMinus
            // 
            this.lblPlusMinus.AutoSize = true;
            this.lblPlusMinus.BackColor = System.Drawing.Color.Transparent;
            this.lblPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusMinus.ForeColor = System.Drawing.Color.White;
            this.lblPlusMinus.Location = new System.Drawing.Point(38, 42);
            this.lblPlusMinus.Name = "lblPlusMinus";
            this.lblPlusMinus.Size = new System.Drawing.Size(42, 29);
            this.lblPlusMinus.TabIndex = 4;
            this.lblPlusMinus.Text = "+/-";
            this.lblPlusMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlusMinus.Click += new System.EventHandler(this.pnlPlusMinus_Click);
            // 
            // pnlPoint
            // 
            this.pnlPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPoint.BackgroundImage")));
            this.pnlPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPoint.Controls.Add(this.lbPoint);
            this.pnlPoint.Location = new System.Drawing.Point(580, 115);
            this.pnlPoint.Name = "pnlPoint";
            this.pnlPoint.Size = new System.Drawing.Size(114, 114);
            this.pnlPoint.TabIndex = 20;
            this.pnlPoint.Click += new System.EventHandler(this.pnlPoint_Click);
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.BackColor = System.Drawing.Color.Transparent;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.ForeColor = System.Drawing.Color.White;
            this.lbPoint.Location = new System.Drawing.Point(49, 42);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(19, 29);
            this.lbPoint.TabIndex = 4;
            this.lbPoint.Text = ".";
            this.lbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPoint.Click += new System.EventHandler(this.pnlPoint_Click);
            // 
            // pnl0
            // 
            this.pnl0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl0.BackgroundImage")));
            this.pnl0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl0.Controls.Add(this.lbl0);
            this.pnl0.Location = new System.Drawing.Point(464, 115);
            this.pnl0.Name = "pnl0";
            this.pnl0.Size = new System.Drawing.Size(114, 114);
            this.pnl0.TabIndex = 19;
            this.pnl0.Click += new System.EventHandler(this.pnl0_Click);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.Color.White;
            this.lbl0.Location = new System.Drawing.Point(43, 42);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(26, 29);
            this.lbl0.TabIndex = 4;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl0.Click += new System.EventHandler(this.pnl0_Click);
            // 
            // pnl9
            // 
            this.pnl9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl9.BackgroundImage")));
            this.pnl9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl9.Controls.Add(this.lbl9);
            this.pnl9.Location = new System.Drawing.Point(348, 115);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(114, 114);
            this.pnl9.TabIndex = 18;
            this.pnl9.Click += new System.EventHandler(this.pnl9_Click);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.Transparent;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.Color.White;
            this.lbl9.Location = new System.Drawing.Point(44, 42);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(26, 29);
            this.lbl9.TabIndex = 4;
            this.lbl9.Text = "9";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl9.Click += new System.EventHandler(this.pnl9_Click);
            // 
            // pnl8
            // 
            this.pnl8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl8.BackgroundImage")));
            this.pnl8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl8.Controls.Add(this.lbl8);
            this.pnl8.Location = new System.Drawing.Point(232, 115);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(114, 114);
            this.pnl8.TabIndex = 17;
            this.pnl8.Click += new System.EventHandler(this.pnl8_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(41, 42);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(26, 29);
            this.lbl8.TabIndex = 4;
            this.lbl8.Text = "8";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl8.Click += new System.EventHandler(this.pnl8_Click);
            // 
            // pnl7
            // 
            this.pnl7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl7.BackgroundImage")));
            this.pnl7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl7.Controls.Add(this.lbl7);
            this.pnl7.Location = new System.Drawing.Point(116, 115);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(114, 114);
            this.pnl7.TabIndex = 16;
            this.pnl7.Click += new System.EventHandler(this.pnl7_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(43, 42);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(26, 29);
            this.lbl7.TabIndex = 4;
            this.lbl7.Text = "7";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl7.Click += new System.EventHandler(this.pnl7_Click);
            // 
            // pnl6
            // 
            this.pnl6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl6.BackgroundImage")));
            this.pnl6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl6.Controls.Add(this.lbl6);
            this.pnl6.Location = new System.Drawing.Point(0, 115);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(114, 114);
            this.pnl6.TabIndex = 15;
            this.pnl6.Click += new System.EventHandler(this.pnl6_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(41, 42);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(26, 29);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "6";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl6.Click += new System.EventHandler(this.pnl6_Click);
            // 
            // frmNumberKeypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1280, 229);
            this.Controls.Add(this.pnlPoint);
            this.Controls.Add(this.pnl0);
            this.Controls.Add(this.pnl9);
            this.Controls.Add(this.pnl8);
            this.Controls.Add(this.pnl7);
            this.Controls.Add(this.pnl6);
            this.Controls.Add(this.pnlPlusMinus);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlClear);
            this.Controls.Add(this.pnlEnter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCANCEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNumberKeypad";
            this.Text = "Number Keypad";
            this.Activated += new System.EventHandler(this.frmNumberKeypad_Activated);
            this.Enter += new System.EventHandler(this.frmNumberKeypad_Enter);
            this.pnlCANCEL.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMin.ResumeLayout(false);
            this.pnlMin.PerformLayout();
            this.pnlValue.ResumeLayout(false);
            this.pnlValue.PerformLayout();
            this.pnlMax.ResumeLayout(false);
            this.pnlMax.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlEnter.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlClear.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.pnl5.ResumeLayout(false);
            this.pnl5.PerformLayout();
            this.pnlPlusMinus.ResumeLayout(false);
            this.pnlPlusMinus.PerformLayout();
            this.pnlPoint.ResumeLayout(false);
            this.pnlPoint.PerformLayout();
            this.pnl0.ResumeLayout(false);
            this.pnl0.PerformLayout();
            this.pnl9.ResumeLayout(false);
            this.pnl9.PerformLayout();
            this.pnl8.ResumeLayout(false);
            this.pnl8.PerformLayout();
            this.pnl7.ResumeLayout(false);
            this.pnl7.PerformLayout();
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlCANCEL;
		private System.Windows.Forms.Label lblCANCEL;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Panel pnlMin;
		private System.Windows.Forms.Panel pnlMax;
		private System.Windows.Forms.Panel pnlValue;
		private System.Windows.Forms.Label lblMax;
		private System.Windows.Forms.Label lblMin;
		private System.Windows.Forms.Label lblValueText;
		private System.Windows.Forms.Panel pnlEnter;
		private System.Windows.Forms.Label lblEnter;
		private System.Windows.Forms.Panel pnlDelete;
		private System.Windows.Forms.Label lblDelete;
		private System.Windows.Forms.Panel pnlClear;
		private System.Windows.Forms.Label lblClear;
		private System.Windows.Forms.Panel pnl1;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Panel pnl2;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Panel pnl3;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Panel pnl4;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Panel pnl5;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.Panel pnlPlusMinus;
		private System.Windows.Forms.Label lblPlusMinus;
		private System.Windows.Forms.Panel pnlPoint;
		private System.Windows.Forms.Label lbPoint;
		private System.Windows.Forms.Panel pnl0;
		private System.Windows.Forms.Label lbl0;
		private System.Windows.Forms.Panel pnl9;
		private System.Windows.Forms.Label lbl9;
		private System.Windows.Forms.Panel pnl8;
		private System.Windows.Forms.Label lbl8;
		private System.Windows.Forms.Panel pnl7;
		private System.Windows.Forms.Label lbl7;
		private System.Windows.Forms.Panel pnl6;
		private System.Windows.Forms.Label lbl6;
        private CRSControlsLib.CrsLabel lblCrsFrmNumKeyTitle;
        private CRSControlsLib.CrsLabel lblCrsFrmNumKeyMin;
        private CRSControlsLib.CrsLabel lblCrsFrmNumKeyVal;
        private CRSControlsLib.CrsLabel lblCrsFrmNumKeyMax;
    }
}