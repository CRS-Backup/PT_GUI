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

		private void pnlH2VLV_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_VALVE3_OPENED);
			pnlH2VLV.BackgroundImage = bitmap;

		//	GuiCore.set_channel_value("LFRIV18", "true");

			GuiCore.toggle_channel(sender, pnlH2VLV, "LFRIV18", Constants.BMP_RECT_BUTTON_GREEN_DOWN, Constants.BMP_RECT_BUTTON_GREEN_UP, "ON", "OFF");
		}

		private void pnlH2VLV_MouseUp(object sender, MouseEventArgs e)
		{
		//	Bitmap bitmap = new Bitmap(Constants.BMP_VALVE3_CLOSED);
		//	pnlH2VLV.BackgroundImage = bitmap;

		//	GuiCore.set_channel_value("LFRIV18", "false");
		}
	}
}
