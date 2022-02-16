namespace PtGui
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdPage1Next = new System.Windows.Forms.Button();
            this.lblPage1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.cmdStartLive = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdPage2Prev = new System.Windows.Forms.Button();
            this.lblPage2 = new System.Windows.Forms.Label();
            this.pnlBannerBorder = new System.Windows.Forms.Panel();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblPageName = new System.Windows.Forms.Label();
            this.pnlCW_LCP_3 = new System.Windows.Forms.Panel();
            this.lblCrsOutsideAirTemp = new CRSControlsLib.CrsLabel();
            this.lblCrsScrollDisplay = new CRSControlsLib.CrsLabel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.cmdCrsToggleInternal = new CRSControlsLib.CrsButton();
            this.cmdCrsTestToggle = new CRSControlsLib.CrsButton();
            this.cmdCrsTestZero = new CRSControlsLib.CrsButton();
            this.lblCrsTest2 = new CRSControlsLib.CrsLabel();
            this.lblCrsBadLink = new CRSControlsLib.CrsLabel();
            this.lblCrsTest = new CRSControlsLib.CrsLabel();
            this.cmdCrsTest = new CRSControlsLib.CrsButton();
            this.pnlPlantControlStart = new System.Windows.Forms.Panel();
            this.txtTextBox1 = new System.Windows.Forms.TextBox();
            this.cmdPadFailsetReset = new System.Windows.Forms.Button();
            this.pnlLampPlantRunning = new System.Windows.Forms.Panel();
            this.pnlLampPlantStopped = new System.Windows.Forms.Panel();
            this.pnlPlantControlStop = new System.Windows.Forms.Panel();
            this.pnlLocalControlRed = new System.Windows.Forms.Panel();
            this.pnlLocalControlGreen = new System.Windows.Forms.Panel();
            this.lblLocalControlAvailable = new System.Windows.Forms.Label();
            this.lblLocalRemoteControlSelect = new System.Windows.Forms.Label();
            this.pnlLocalRemoteLeft = new System.Windows.Forms.Panel();
            this.pnlLocalRemoteRight = new System.Windows.Forms.Panel();
            this.cmdLoadFormTest = new System.Windows.Forms.Button();
            this.crsLabel1 = new CRSControlsLib.CrsLabel();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlBannerBorder.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            this.pnlCW_LCP_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 250;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabMain);
            this.panel1.Location = new System.Drawing.Point(4, 648);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 146);
            this.panel1.TabIndex = 16;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(5, 9);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(938, 124);
            this.tabMain.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.cmdPage1Next);
            this.tabPage1.Controls.Add(this.lblPage1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtMain);
            this.tabPage1.Controls.Add(this.cmdStartLive);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(930, 98);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // cmdPage1Next
            // 
            this.cmdPage1Next.Location = new System.Drawing.Point(547, -31);
            this.cmdPage1Next.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPage1Next.Name = "cmdPage1Next";
            this.cmdPage1Next.Size = new System.Drawing.Size(100, 75);
            this.cmdPage1Next.TabIndex = 26;
            this.cmdPage1Next.Text = ">";
            this.cmdPage1Next.UseVisualStyleBackColor = true;
            this.cmdPage1Next.Click += new System.EventHandler(this.cmdPage1Next_Click_1);
            // 
            // lblPage1
            // 
            this.lblPage1.AutoSize = true;
            this.lblPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPage1.Location = new System.Drawing.Point(580, 16);
            this.lblPage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPage1.Name = "lblPage1";
            this.lblPage1.Size = new System.Drawing.Size(41, 13);
            this.lblPage1.TabIndex = 25;
            this.lblPage1.Text = "Page 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(220, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 37);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(60, 408);
            this.txtMain.Margin = new System.Windows.Forms.Padding(2);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(396, 20);
            this.txtMain.TabIndex = 21;
            // 
            // cmdStartLive
            // 
            this.cmdStartLive.Location = new System.Drawing.Point(10, 4);
            this.cmdStartLive.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStartLive.Name = "cmdStartLive";
            this.cmdStartLive.Size = new System.Drawing.Size(135, 37);
            this.cmdStartLive.TabIndex = 20;
            this.cmdStartLive.Text = "Start Live Updates";
            this.cmdStartLive.UseVisualStyleBackColor = true;
            this.cmdStartLive.Click += new System.EventHandler(this.cmdStartLive_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.cmdPage2Prev);
            this.tabPage2.Controls.Add(this.lblPage2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(930, 98);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Propulsion";
            // 
            // cmdPage2Prev
            // 
            this.cmdPage2Prev.Location = new System.Drawing.Point(561, 16);
            this.cmdPage2Prev.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPage2Prev.Name = "cmdPage2Prev";
            this.cmdPage2Prev.Size = new System.Drawing.Size(23, 28);
            this.cmdPage2Prev.TabIndex = 27;
            this.cmdPage2Prev.Text = "<";
            this.cmdPage2Prev.UseVisualStyleBackColor = true;
            // 
            // lblPage2
            // 
            this.lblPage2.AutoSize = true;
            this.lblPage2.ForeColor = System.Drawing.Color.Yellow;
            this.lblPage2.Location = new System.Drawing.Point(589, 24);
            this.lblPage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPage2.Name = "lblPage2";
            this.lblPage2.Size = new System.Drawing.Size(41, 13);
            this.lblPage2.TabIndex = 26;
            this.lblPage2.Text = "Page 2";
            // 
            // pnlBannerBorder
            // 
            this.pnlBannerBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.pnlBannerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBannerBorder.Controls.Add(this.pnlBanner);
            this.pnlBannerBorder.Location = new System.Drawing.Point(196, 16);
            this.pnlBannerBorder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBannerBorder.Name = "pnlBannerBorder";
            this.pnlBannerBorder.Size = new System.Drawing.Size(880, 70);
            this.pnlBannerBorder.TabIndex = 17;
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.pnlBanner.Controls.Add(this.lblPageName);
            this.pnlBanner.Location = new System.Drawing.Point(3, 3);
            this.pnlBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(872, 63);
            this.pnlBanner.TabIndex = 0;
            // 
            // lblPageName
            // 
            this.lblPageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(233)))));
            this.lblPageName.Location = new System.Drawing.Point(2, 7);
            this.lblPageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(868, 49);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.Text = "CW LCP No 3";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCW_LCP_3
            // 
            this.pnlCW_LCP_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCW_LCP_3.BackgroundImage")));
            this.pnlCW_LCP_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCW_LCP_3.Controls.Add(this.crsLabel1);
            this.pnlCW_LCP_3.Controls.Add(this.cmdLoadFormTest);
            this.pnlCW_LCP_3.Controls.Add(this.lblCrsOutsideAirTemp);
            this.pnlCW_LCP_3.Controls.Add(this.lblCrsScrollDisplay);
            this.pnlCW_LCP_3.Controls.Add(this.hScrollBar1);
            this.pnlCW_LCP_3.Controls.Add(this.cmdCrsToggleInternal);
            this.pnlCW_LCP_3.Controls.Add(this.cmdCrsTestToggle);
            this.pnlCW_LCP_3.Controls.Add(this.cmdCrsTestZero);
            this.pnlCW_LCP_3.Controls.Add(this.lblCrsTest2);
            this.pnlCW_LCP_3.Controls.Add(this.lblCrsBadLink);
            this.pnlCW_LCP_3.Controls.Add(this.lblCrsTest);
            this.pnlCW_LCP_3.Controls.Add(this.cmdCrsTest);
            this.pnlCW_LCP_3.Controls.Add(this.pnlPlantControlStart);
            this.pnlCW_LCP_3.Controls.Add(this.txtTextBox1);
            this.pnlCW_LCP_3.Controls.Add(this.cmdPadFailsetReset);
            this.pnlCW_LCP_3.Controls.Add(this.pnlLampPlantRunning);
            this.pnlCW_LCP_3.Controls.Add(this.pnlLampPlantStopped);
            this.pnlCW_LCP_3.Controls.Add(this.pnlPlantControlStop);
            this.pnlCW_LCP_3.Controls.Add(this.pnlLocalControlRed);
            this.pnlCW_LCP_3.Controls.Add(this.pnlLocalControlGreen);
            this.pnlCW_LCP_3.Controls.Add(this.lblLocalControlAvailable);
            this.pnlCW_LCP_3.Controls.Add(this.lblLocalRemoteControlSelect);
            this.pnlCW_LCP_3.Controls.Add(this.pnlLocalRemoteLeft);
            this.pnlCW_LCP_3.Controls.Add(this.pnlLocalRemoteRight);
            this.pnlCW_LCP_3.Controls.Add(this.pnlBannerBorder);
            this.pnlCW_LCP_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCW_LCP_3.Location = new System.Drawing.Point(0, 0);
            this.pnlCW_LCP_3.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCW_LCP_3.Name = "pnlCW_LCP_3";
            this.pnlCW_LCP_3.Size = new System.Drawing.Size(1280, 791);
            this.pnlCW_LCP_3.TabIndex = 0;
            this.pnlCW_LCP_3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCW_LCP_3_Paint);
            // 
            // lblCrsOutsideAirTemp
            // 
            this.lblCrsOutsideAirTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.lblCrsOutsideAirTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrsOutsideAirTemp.CrsChanNumOrAlias = "t_outside_air_temp";
            this.lblCrsOutsideAirTemp.CrsChanValue = "\"<none>\"";
            this.lblCrsOutsideAirTemp.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblCrsOutsideAirTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCrsOutsideAirTemp.Location = new System.Drawing.Point(346, 204);
            this.lblCrsOutsideAirTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrsOutsideAirTemp.Name = "lblCrsOutsideAirTemp";
            this.lblCrsOutsideAirTemp.Size = new System.Drawing.Size(128, 44);
            this.lblCrsOutsideAirTemp.TabIndex = 44;
            this.lblCrsOutsideAirTemp.Text = "oat";
            this.lblCrsOutsideAirTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrsOutsideAirTemp.TextChanged += new System.EventHandler(this.lblCrsOutsideAirTemp_TextChanged);
            // 
            // lblCrsScrollDisplay
            // 
            this.lblCrsScrollDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCrsScrollDisplay.CrsChanNumOrAlias = "2001";
            this.lblCrsScrollDisplay.CrsChanValue = null;
            this.lblCrsScrollDisplay.Location = new System.Drawing.Point(716, 149);
            this.lblCrsScrollDisplay.Name = "lblCrsScrollDisplay";
            this.lblCrsScrollDisplay.Size = new System.Drawing.Size(72, 35);
            this.lblCrsScrollDisplay.TabIndex = 39;
            this.lblCrsScrollDisplay.Text = "CRS Label Scroll";
            this.lblCrsScrollDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrsScrollDisplay.TextChanged += new System.EventHandler(this.lblCrsScrollDisplay_TextChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(465, 149);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(248, 35);
            this.hScrollBar1.TabIndex = 38;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // cmdCrsToggleInternal
            // 
            this.cmdCrsToggleInternal.CrsChanNumOrAlias = "t_tog_test";
            this.cmdCrsToggleInternal.CrsChanValue = null;
            this.cmdCrsToggleInternal.CrsGotoPage = "frmFAMROverview";
            this.cmdCrsToggleInternal.Location = new System.Drawing.Point(158, 204);
            this.cmdCrsToggleInternal.Name = "cmdCrsToggleInternal";
            this.cmdCrsToggleInternal.Size = new System.Drawing.Size(79, 35);
            this.cmdCrsToggleInternal.TabIndex = 37;
            this.cmdCrsToggleInternal.Text = "CRS Butt Tog Internal";
            this.cmdCrsToggleInternal.UseVisualStyleBackColor = true;
            this.cmdCrsToggleInternal.Click += new System.EventHandler(this.cmdCrsToggleInternal_Click);
            // 
            // cmdCrsTestToggle
            // 
            this.cmdCrsTestToggle.CrsChanNumOrAlias = "chan3002";
            this.cmdCrsTestToggle.CrsChanValue = null;
            this.cmdCrsTestToggle.CrsGotoPage = "frmFAMROverview";
            this.cmdCrsTestToggle.Location = new System.Drawing.Point(62, 204);
            this.cmdCrsTestToggle.Name = "cmdCrsTestToggle";
            this.cmdCrsTestToggle.Size = new System.Drawing.Size(79, 35);
            this.cmdCrsTestToggle.TabIndex = 36;
            this.cmdCrsTestToggle.Text = "CRS Butt Tog Output";
            this.cmdCrsTestToggle.UseVisualStyleBackColor = true;
            this.cmdCrsTestToggle.Click += new System.EventHandler(this.cmdCrsTestToggle_Click);
            // 
            // cmdCrsTestZero
            // 
            this.cmdCrsTestZero.CrsChanNumOrAlias = "chan3000";
            this.cmdCrsTestZero.CrsChanValue = null;
            this.cmdCrsTestZero.CrsGotoPage = "frmFAMROverview";
            this.cmdCrsTestZero.Location = new System.Drawing.Point(158, 149);
            this.cmdCrsTestZero.Name = "cmdCrsTestZero";
            this.cmdCrsTestZero.Size = new System.Drawing.Size(79, 35);
            this.cmdCrsTestZero.TabIndex = 35;
            this.cmdCrsTestZero.Text = "CRS Button Set Off";
            this.cmdCrsTestZero.UseVisualStyleBackColor = true;
            this.cmdCrsTestZero.Click += new System.EventHandler(this.cmdCrsTestZero_Click);
            // 
            // lblCrsTest2
            // 
            this.lblCrsTest2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCrsTest2.CrsChanNumOrAlias = "t_tog_test";
            this.lblCrsTest2.CrsChanValue = null;
            this.lblCrsTest2.Location = new System.Drawing.Point(256, 204);
            this.lblCrsTest2.Name = "lblCrsTest2";
            this.lblCrsTest2.Size = new System.Drawing.Size(72, 35);
            this.lblCrsTest2.TabIndex = 34;
            this.lblCrsTest2.Text = "CRS Label Test";
            this.lblCrsTest2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrsTest2.TextChanged += new System.EventHandler(this.lblCrsTest2_TextChanged);
            this.lblCrsTest2.Click += new System.EventHandler(this.lblCrsTest2_Click);
            // 
            // lblCrsBadLink
            // 
            this.lblCrsBadLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(101)))), ((int)(((byte)(51)))));
            this.lblCrsBadLink.CrsChanNumOrAlias = null;
            this.lblCrsBadLink.CrsChanValue = null;
            this.lblCrsBadLink.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCrsBadLink.Location = new System.Drawing.Point(343, 149);
            this.lblCrsBadLink.Name = "lblCrsBadLink";
            this.lblCrsBadLink.Size = new System.Drawing.Size(101, 35);
            this.lblCrsBadLink.TabIndex = 33;
            this.lblCrsBadLink.Text = "CRS Label Bad link";
            this.lblCrsBadLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrsTest
            // 
            this.lblCrsTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCrsTest.CrsChanNumOrAlias = "chan1000";
            this.lblCrsTest.CrsChanValue = null;
            this.lblCrsTest.Location = new System.Drawing.Point(256, 149);
            this.lblCrsTest.Name = "lblCrsTest";
            this.lblCrsTest.Size = new System.Drawing.Size(72, 35);
            this.lblCrsTest.TabIndex = 32;
            this.lblCrsTest.Text = "CRS Label Test";
            this.lblCrsTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCrsTest.CausesValidationChanged += new System.EventHandler(this.lblCrsTest_CausesValidationChanged);
            this.lblCrsTest.TextChanged += new System.EventHandler(this.lblCrsTest_TextChanged);
            // 
            // cmdCrsTest
            // 
            this.cmdCrsTest.CrsChanNumOrAlias = "3000";
            this.cmdCrsTest.CrsChanValue = null;
            this.cmdCrsTest.CrsGotoPage = "frmFAMROverview";
            this.cmdCrsTest.Location = new System.Drawing.Point(62, 149);
            this.cmdCrsTest.Name = "cmdCrsTest";
            this.cmdCrsTest.Size = new System.Drawing.Size(79, 35);
            this.cmdCrsTest.TabIndex = 31;
            this.cmdCrsTest.Text = "CRS Button Set On";
            this.cmdCrsTest.UseVisualStyleBackColor = true;
            this.cmdCrsTest.Click += new System.EventHandler(this.cmdCrsTest_Click);
            // 
            // pnlPlantControlStart
            // 
            this.pnlPlantControlStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPlantControlStart.BackgroundImage")));
            this.pnlPlantControlStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlantControlStart.Location = new System.Drawing.Point(610, 605);
            this.pnlPlantControlStart.Name = "pnlPlantControlStart";
            this.pnlPlantControlStart.Size = new System.Drawing.Size(116, 114);
            this.pnlPlantControlStart.TabIndex = 26;
            this.pnlPlantControlStart.Click += new System.EventHandler(this.pnlPlantControlStart_Click);
            this.pnlPlantControlStart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlantControlStart_Paint);
            // 
            // txtTextBox1
            // 
            this.txtTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.txtTextBox1.Location = new System.Drawing.Point(404, 738);
            this.txtTextBox1.Name = "txtTextBox1";
            this.txtTextBox1.Size = new System.Drawing.Size(84, 20);
            this.txtTextBox1.TabIndex = 30;
            // 
            // cmdPadFailsetReset
            // 
            this.cmdPadFailsetReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPadFailsetReset.Location = new System.Drawing.Point(356, 415);
            this.cmdPadFailsetReset.Name = "cmdPadFailsetReset";
            this.cmdPadFailsetReset.Size = new System.Drawing.Size(40, 40);
            this.cmdPadFailsetReset.TabIndex = 29;
            this.cmdPadFailsetReset.Text = "FLST\r\nRSET";
            this.cmdPadFailsetReset.UseVisualStyleBackColor = true;
            this.cmdPadFailsetReset.Click += new System.EventHandler(this.cmdPadFailsetReset_Click);
            // 
            // pnlLampPlantRunning
            // 
            this.pnlLampPlantRunning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLampPlantRunning.BackgroundImage")));
            this.pnlLampPlantRunning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLampPlantRunning.Location = new System.Drawing.Point(637, 437);
            this.pnlLampPlantRunning.Name = "pnlLampPlantRunning";
            this.pnlLampPlantRunning.Size = new System.Drawing.Size(66, 67);
            this.pnlLampPlantRunning.TabIndex = 28;
            this.pnlLampPlantRunning.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLampPlantRunning_Paint);
            // 
            // pnlLampPlantStopped
            // 
            this.pnlLampPlantStopped.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLampPlantStopped.BackgroundImage")));
            this.pnlLampPlantStopped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLampPlantStopped.Location = new System.Drawing.Point(637, 522);
            this.pnlLampPlantStopped.Name = "pnlLampPlantStopped";
            this.pnlLampPlantStopped.Size = new System.Drawing.Size(66, 67);
            this.pnlLampPlantStopped.TabIndex = 27;
            // 
            // pnlPlantControlStop
            // 
            this.pnlPlantControlStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPlantControlStop.BackgroundImage")));
            this.pnlPlantControlStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlantControlStop.Location = new System.Drawing.Point(611, 608);
            this.pnlPlantControlStop.Name = "pnlPlantControlStop";
            this.pnlPlantControlStop.Size = new System.Drawing.Size(113, 109);
            this.pnlPlantControlStop.TabIndex = 25;
            this.pnlPlantControlStop.Click += new System.EventHandler(this.pnlPlantControlStop_Click);
            // 
            // pnlLocalControlRed
            // 
            this.pnlLocalControlRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLocalControlRed.BackgroundImage")));
            this.pnlLocalControlRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLocalControlRed.Location = new System.Drawing.Point(197, 625);
            this.pnlLocalControlRed.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLocalControlRed.Name = "pnlLocalControlRed";
            this.pnlLocalControlRed.Size = new System.Drawing.Size(66, 67);
            this.pnlLocalControlRed.TabIndex = 24;
            // 
            // pnlLocalControlGreen
            // 
            this.pnlLocalControlGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLocalControlGreen.BackgroundImage")));
            this.pnlLocalControlGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLocalControlGreen.Location = new System.Drawing.Point(198, 624);
            this.pnlLocalControlGreen.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLocalControlGreen.Name = "pnlLocalControlGreen";
            this.pnlLocalControlGreen.Size = new System.Drawing.Size(66, 67);
            this.pnlLocalControlGreen.TabIndex = 23;
            // 
            // lblLocalControlAvailable
            // 
            this.lblLocalControlAvailable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalControlAvailable.Location = new System.Drawing.Point(183, 729);
            this.lblLocalControlAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalControlAvailable.Name = "lblLocalControlAvailable";
            this.lblLocalControlAvailable.Size = new System.Drawing.Size(100, 29);
            this.lblLocalControlAvailable.TabIndex = 22;
            this.lblLocalControlAvailable.Text = "LOCAL CONTROL\r\nAVAILABLE";
            this.lblLocalControlAvailable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLocalControlAvailable.Click += new System.EventHandler(this.lblLocalControlAvailable_Click);
            // 
            // lblLocalRemoteControlSelect
            // 
            this.lblLocalRemoteControlSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalRemoteControlSelect.Location = new System.Drawing.Point(59, 733);
            this.lblLocalRemoteControlSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalRemoteControlSelect.Name = "lblLocalRemoteControlSelect";
            this.lblLocalRemoteControlSelect.Size = new System.Drawing.Size(100, 29);
            this.lblLocalRemoteControlSelect.TabIndex = 21;
            this.lblLocalRemoteControlSelect.Text = "LOCAL/REMOTE\r\nCONTROL SELECT";
            this.lblLocalRemoteControlSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlLocalRemoteLeft
            // 
            this.pnlLocalRemoteLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLocalRemoteLeft.BackgroundImage")));
            this.pnlLocalRemoteLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLocalRemoteLeft.Location = new System.Drawing.Point(52, 606);
            this.pnlLocalRemoteLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLocalRemoteLeft.Name = "pnlLocalRemoteLeft";
            this.pnlLocalRemoteLeft.Size = new System.Drawing.Size(116, 114);
            this.pnlLocalRemoteLeft.TabIndex = 18;
            this.pnlLocalRemoteLeft.Click += new System.EventHandler(this.pnlLocalRemoteLeft_Click);
            this.pnlLocalRemoteLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLocalRemoteLeft_Paint);
            // 
            // pnlLocalRemoteRight
            // 
            this.pnlLocalRemoteRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLocalRemoteRight.BackgroundImage")));
            this.pnlLocalRemoteRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLocalRemoteRight.Location = new System.Drawing.Point(52, 606);
            this.pnlLocalRemoteRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLocalRemoteRight.Name = "pnlLocalRemoteRight";
            this.pnlLocalRemoteRight.Size = new System.Drawing.Size(116, 114);
            this.pnlLocalRemoteRight.TabIndex = 20;
            this.pnlLocalRemoteRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLocalRemoteRight_Paint);
            this.pnlLocalRemoteRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLocalRemoteRight_MouseClick);
            // 
            // cmdLoadFormTest
            // 
            this.cmdLoadFormTest.Location = new System.Drawing.Point(524, 204);
            this.cmdLoadFormTest.Name = "cmdLoadFormTest";
            this.cmdLoadFormTest.Size = new System.Drawing.Size(111, 32);
            this.cmdLoadFormTest.TabIndex = 45;
            this.cmdLoadFormTest.Text = "Load Form";
            this.cmdLoadFormTest.UseVisualStyleBackColor = true;
            this.cmdLoadFormTest.Click += new System.EventHandler(this.cmdLoadFormTest_Click);
            // 
            // crsLabel1
            // 
            this.crsLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.crsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crsLabel1.CrsChanNumOrAlias = "ecTest";
            this.crsLabel1.CrsChanValue = "\"<none>\"";
            this.crsLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.crsLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crsLabel1.Location = new System.Drawing.Point(793, 140);
            this.crsLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.crsLabel1.Name = "crsLabel1";
            this.crsLabel1.Size = new System.Drawing.Size(128, 44);
            this.crsLabel1.TabIndex = 49;
            this.crsLabel1.Text = "SS";
            this.crsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crsLabel1.TextChanged += new System.EventHandler(this.crsLabel1_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1280, 791);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCW_LCP_3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PT GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlBannerBorder.ResumeLayout(false);
            this.pnlBanner.ResumeLayout(false);
            this.pnlCW_LCP_3.ResumeLayout(false);
            this.pnlCW_LCP_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBannerBorder;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Panel pnlCW_LCP_3;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdPage1Next;
        private System.Windows.Forms.Label lblPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button cmdStartLive;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdPage2Prev;
        private System.Windows.Forms.Label lblPage2;
        private System.Windows.Forms.Panel pnlLocalRemoteRight;
        private System.Windows.Forms.Panel pnlLocalControlGreen;
        private System.Windows.Forms.Panel pnlLocalControlRed;
        private System.Windows.Forms.Label lblLocalControlAvailable;
        private System.Windows.Forms.Label lblLocalRemoteControlSelect;
		private System.Windows.Forms.Panel pnlLampPlantRunning;
		private System.Windows.Forms.Panel pnlLampPlantStopped;
		private System.Windows.Forms.Panel pnlPlantControlStop;
		private System.Windows.Forms.Panel pnlPlantControlStart;
		private System.Windows.Forms.TextBox txtTextBox1;
		private System.Windows.Forms.Button cmdPadFailsetReset;
		private System.Windows.Forms.Panel pnlLocalRemoteLeft;
        private CRSControlsLib.CrsLabel lblCrsTest;
        private CRSControlsLib.CrsButton cmdCrsTest;
        private CRSControlsLib.CrsLabel lblCrsBadLink;
        private CRSControlsLib.CrsLabel lblCrsTest2;
        private CRSControlsLib.CrsButton cmdCrsTestToggle;
        private CRSControlsLib.CrsButton cmdCrsTestZero;
        private CRSControlsLib.CrsButton cmdCrsToggleInternal;
        private CRSControlsLib.CrsLabel lblCrsScrollDisplay;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private CRSControlsLib.CrsLabel lblCrsOutsideAirTemp;
        private System.Windows.Forms.Button cmdLoadFormTest;
        private CRSControlsLib.CrsLabel crsLabel1;
    }
}

