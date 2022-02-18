using System;
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
	public partial class frmLPSW2 : Form
	{
		public frmLPSW2()
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

		private void pnlVlvOverflow1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSIV01", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LLSIV01

		}

		private void pnlH2Valve_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSNU8", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSNU8

		}

		private void pnlH1Valve_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSNU9", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSNU9

		}
	}
}   //   pnl3WAY1 = ILLSNDG3 1 = TO DISCH, 2 = TO ENG MONITORING ONLY
	//	 pnl3WAY2 = ILLSNDG4 1 = TO DISCH, 2 = TO ENG MONITORING ONLY
