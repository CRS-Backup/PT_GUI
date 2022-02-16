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
	public partial class frmInitialCond : Form

	{
		bool pnl1Selected = false;
		bool pnl2Selected = false;
		bool pnl3Selected = false;
		bool pnl4Selected = false;
		bool pnl5Selected = false;
		bool pnl6Selected = false;
		bool pnl7Selected = false;
		bool pnl8Selected = false;
		bool pnl9Selected = false;
		bool pnl10Selected = false;


		Bitmap red_down = new Bitmap(Constants.BMP_LONG_BUTTON_RED_DOWN);
		Bitmap red_up = new Bitmap(Constants.BMP_LONG_BUTTON_RED_UP);
		Bitmap green_down = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
		Bitmap green_up = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);

		public frmInitialCond()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmDiscrepancies", this);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmDiscrepancies", this);
		}

		private void pnl1_MouseDown(object sender, EventArgs e)
		{ 
			pnl1Selected = true;            //does this give a returning channel once the action has been accepted ?
			pnl2Selected = false;
			pnl3Selected = false;
			pnl4Selected = false;
			pnl5Selected = false;
			pnl6Selected = false;
			pnl7Selected = false; 
			pnl8Selected = false;
			pnl9Selected = false;
			pnl10Selected = false;

			if (pnl1Selected)
			{
				pnl1.BackgroundImage = red_down;
			}
			else
			{
				pnl1.BackgroundImage = green_down;
			}
		}
	
		private void pnl1_MouseUp(object sender, EventArgs e)
		{
			if (pnl1Selected)
			{
				pnl1.BackgroundImage = red_up;
				pnl2.BackgroundImage = green_up;
				pnl3.BackgroundImage = green_up;
			}
			else
			{
				pnl1.BackgroundImage = green_up;
			}
		}


		private void pnl2_MouseDown(object sender, EventArgs e)
		{
			pnl1Selected = false;            //does this give a returning channel once the action has been accepted ?
			pnl2Selected = true;
			pnl3Selected = false;
			pnl4Selected = false;
			pnl5Selected = false;
			pnl6Selected = false;
			pnl7Selected = false;
			pnl8Selected = false;
			pnl9Selected = false;
			pnl10Selected = false;

			if (pnl2Selected)
			{
				pnl2.BackgroundImage = red_down;
			}
			else
			{
				pnl2.BackgroundImage = green_down;
			}
		}

		private void pnl2_MouseUp(object sender, EventArgs e)
		{
			if (pnl2Selected)
			{
				pnl2.BackgroundImage = red_up;
				pnl1.BackgroundImage = green_up;
				pnl3.BackgroundImage = green_up;
			}
			else
			{
				pnl2.BackgroundImage = green_up;
			}
		}

		private void pnl3_MouseDown(object sender, EventArgs e)
		{
			pnl1Selected = false;            //does this give a returning channel once the action has been accepted ?
			pnl2Selected = false;
			pnl3Selected = true;
			pnl4Selected = false;
			pnl5Selected = false;
			pnl6Selected = false;
			pnl7Selected = false;
			pnl8Selected = false;
			pnl9Selected = false;
			pnl10Selected = false;

			if (pnl3Selected)
			{
				pnl3.BackgroundImage = red_down;
			}
			else
			{
				pnl3.BackgroundImage = green_down;
			}
		}

		private void pnl3_MouseUp(object sender, EventArgs e)
		{
			if (pnl3Selected)
			{
				pnl3.BackgroundImage = red_up;
				pnl1.BackgroundImage = green_up;
				pnl2.BackgroundImage = green_up;
			}
			else
			{
 				pnl3.BackgroundImage = green_up;
			}
		}

	
		private void pnlDiscrepancyReport_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmDiscrepancies", this);
		}

		private void pnlDiscrepancyReport_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_GREY_DOWN);
			pnlDiscrepancyReport.BackgroundImage = bitmap;
		}

		private void pnlDiscrepancyReport_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_GREY_UP);
			pnlDiscrepancyReport.BackgroundImage = bitmap;
		}
	}
}

