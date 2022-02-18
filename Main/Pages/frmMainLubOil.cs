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
	public partial class frmMainLubOil: Form

	{
		public frmMainLubOil()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}

		private void pnlVlv1Opn_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LIFLL030", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFLL030

		}

		private void pnlVlv3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LIFLL026", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFLL026

		}

		private void pnlVlv2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LIFLL014", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFLL014

		}

		private void pnlPump3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LIFLPP3", Constants.PUMP_RUNNINGL, Constants.PUMP_STOPPEDL);
			// LFLPP3

		}

		private void pnlPump4_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LIFLPP4", Constants.PUMP_RUNNINGL, Constants.PUMP_STOPPEDL);
			// LFLPP4

		}

		private void pnlVlvADLO_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LIFLL023", Constants.BMP_VALVE5_OPENED, Constants.BMP_VALVE5_CLOSED);
			// LFLL023

		}
	}
	 //   ADLO PUMP - CHECK WE STILL HAVE THIS
	 //   pnlPump1 - STBD BELT DRIVEN Pp LFLPP1
	 //   pnlPump2 - PORT BELT DRIVEN Pp LFLPP2

}
