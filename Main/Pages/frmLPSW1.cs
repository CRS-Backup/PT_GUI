﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtGui
{
	public partial class frmLPSW1 : Form
	{
		public frmLPSW1()
		{
			InitializeComponent();

			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void pnl3WAY1_Click(object sender, EventArgs e)
		{
			frm3wayPopUp new3wayPopUp = new frm3wayPopUp();
			new3wayPopUp.ShowDialog();
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}
	}
}