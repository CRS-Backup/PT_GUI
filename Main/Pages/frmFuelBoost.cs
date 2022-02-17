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
	public partial class frmFuelBoost : Form
	{
		public frmFuelBoost()
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
			GuiCore.show_form("frmOutstationMenu", null);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", null);
		}

		private void pnlH2VLV_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV18", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV18CS
		}

		private void pnlH1VLV_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV17", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV17CS

		}
	}
}
