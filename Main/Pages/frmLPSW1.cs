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

		private void pnlVLV7_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN47", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSN47

		}

		private void pnlVLV1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN09", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSN09

		}

		private void pnlVLV8_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN48", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSN48

		}

		private void pnlVLV2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN40", Constants.BMP_VALVE6_OPENED, Constants.BMP_VALVE6_CLOSED);
			// LLSN40

		}

		private void pnlVLV3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN20", Constants.BMP_VALVE6_OPENED, Constants.BMP_VALVE6_CLOSED);
			// LLSN20

		}

		private void pnlVLV4_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN24", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSN24

		}

		private void pnlVLV5_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN35", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LLSN35

		}

		private void pnlVLV6_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LILSN21", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LLSN21


		}
	}
}
