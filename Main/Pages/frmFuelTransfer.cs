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
	public partial class frmFuelTransfer : Form

	{
		public frmFuelTransfer()
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

		private void pnlVlvOverflowIn_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV8", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LFRV8CS

		}

		private void pnlVlvOverflowOut_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV8A", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV8CSA

		}

		private void pnlVlvTank1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT1", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT1CS , LFRVT1OS

		}

		private void pnlVlvTank2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT2", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT2CS , LFRVT2OS

		}

		private void pnlVlvTank3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT3", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT3CS , LFRVT3OS
		}

		private void pnlVlvTank4_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT4", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT4CS , LFRVT4OS

		}

		private void pnlVlvTank5_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT5", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT5CS , LFRVT5OS

		}

		private void pnlVlvTank6_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT6", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT6CS , LFRVT6OS

		}

		private void pnlVlvTank7_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT7", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT7CS , LFRVT7OS

		}

		private void pnlVlvTank8_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT8", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT8CS , LFRVT8OS

		}

		private void pnlVlvTank9_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT9", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT9CS , LFRVT9OS

		}

		private void pnlVlvTank10_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIVT10", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRVT10CS , LFRVT10OS

		}

		private void pnlVlvService2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV7", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LFRV7CS 
		}

		private void pnlVlvService1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV6", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LFRV6CS 

		}

		private void pnlVlv1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV5", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV5CS 

		}

		private void pnlPump1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRITP1", Constants.PUMP_RUNNINGL, Constants.PUMP_STOPPEDL);
			// LFRTP1RS

		}

		private void pnlPump2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRITP2", Constants.PUMP_RUNNINGR, Constants.PUMP_STOPPEDR);
			// LFRTP2RS
		}

		private void pnlVlvPumpIn_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV2", Constants.BMP_VALVE4_OPENED, Constants.BMP_VALVE4_CLOSED);
			// LFRV2CS

		}

		private void pnlVlv2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV3", Constants.BMP_VALVE1_OPENED, Constants.BMP_VALVE1_CLOSED);
			// LFRV3CS

		}

		private void pnlVlvAftOut_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV1", Constants.BMP_VALVE2_OPENED, Constants.BMP_VALVE2_CLOSED);
			// LFRV1CS

		}

		private void pnlCoalescer1_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRICP1", Constants.COALESCER_OPEN, Constants.COALESCER_CLOSED);
			// LFRCP1CS
		}

		private void pnlCoalescer2_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRICP2", Constants.COALESCER_OPEN, Constants.COALESCER_CLOSED);
			// LFRCP2CS

		}

		private void pnlVlv3_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LFRIV4", Constants.BMP_VALVE3_OPENED, Constants.BMP_VALVE3_CLOSED);
			// LFRV4CS

		}
	}
}

	//SERVICE TANK 3 OPENED LFR105, CLOSED LFR106 - MONITORING ONLY

