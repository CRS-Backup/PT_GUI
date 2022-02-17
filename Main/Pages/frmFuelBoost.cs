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

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", null);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", null);
		}

		private void pnlH1VLV_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV17", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV17CS
		}

		private void pnlH2VLV_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV18", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV18CS
		}


		private void pnlPUMP1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIBP1", Constants.PUMP_RUNNINGL, Constants.PUMP_STOPPEDL);
			// LFRBP1RS

		}

		private void pnlPUMP2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIBP2", Constants.PUMP_RUNNINGL, Constants.PUMP_STOPPEDL);
			// LFRBP2RS

		}

		private void pnlPUMP3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIBP3", Constants.PUMP_RUNNINGL, Constants.PUMP_STOPPEDL);
			// LFRBP3RS

		}

		private void pnlVLV6_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVV3", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRVV3CS
		}

		private void pnlVLV7_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVV2", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRVV2CS

		}

		private void pnlVLV8_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVV1", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRVV1CS

		}

		private void pnl3WAY1_Click(object sender, EventArgs e)
		{
			frm3wayPopUp new3wayPopUp = new frm3wayPopUp();
			new3wayPopUp.ShowDialog();

			//IFRIDV = 1 or 3 : No2 Boost Pp Discharge
		}

		private void pnlVLV2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV12", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			//LFRV12CS
		}

		private void pnlVLV1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV13", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			//LFRV13CS

		}

		private void pnlVLV3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVLS", Constants.BMP_VALVE2_OPENED, Constants.BMP_VALVE2_CLOSED);
			//LFRVLSCS

		}

		private void pnlVLV5_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVLP", Constants.BMP_VALVE2_OPENED, Constants.BMP_VALVE2_CLOSED);
			//LFRVLPCS

		}

		private void pnlVLV4_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV16", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LFRV16CS

		}

		private void pnlF1VLV_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV14", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRV14CS

		}

		private void pnlF2VLV_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV15", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRV15CS
		}

		private void pnl3WAY2_Click(object sender, EventArgs e)
		{
			//IFRISV3 1,2,3
		}

		private void pnl3WAY3_Click(object sender, EventArgs e)
		{
			//IFRISV2 1,2,3

		}

		private void pnl3WAY4_Click(object sender, EventArgs e)
		{
			//IFRISV1 1,2,3
		}
	}

}
// LGT059[1] = OPENED, LGT061[1] = CLOSED.
// NO ACTION , JUST INDICATION  - CHECK

// LGT059[0] = OPENED, LGT061[0] = CLOSED.
// NO ACTION , JUST INDICATION  - CHECK