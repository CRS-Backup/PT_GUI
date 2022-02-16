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
	public partial class frmMGROverview : Form

	{

		public frmMGROverview()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		//GB LCP

		private void pnlGBLCP_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmGB_LCP", this); 
		}

		private void pnlGBLCP_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlGBLCP.BackgroundImage = bitmap;
		}

		private void pnlGBLCP_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlGBLCP.BackgroundImage = bitmap;
		}

		//CW LCP

		private void pnlCWLCP_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmCW_LCP", this);
		}

		private void pnlCWLCP_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlCWLCP.BackgroundImage = bitmap;
		}

		private void pnlCWLCP_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlCWLCP.BackgroundImage = bitmap;
		}


		//Fuel Boost

		private void pnlFuelBoost_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmFuelBoost", this);
		}

		private void pnlFuelBoost_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlFuelBoost.BackgroundImage = bitmap;
		}

		private void pnlFuelBoost_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlFuelBoost.BackgroundImage = bitmap;
		}

		//Fuel Transfer	

		private void pnlFuelTransfer_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmFuelTransfer", this);
		}

		private void pnlFuelTransfer_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlFuelTransfer.BackgroundImage = bitmap;
		}

		private void pnlFuelTransfer_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlFuelTransfer.BackgroundImage = bitmap;
		}


		//Main Lub Oil

		private void pnlLubOil_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMainLubOil", this);
		}

		private void pnlLubOil_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlLubOil.BackgroundImage = bitmap;
		}

		private void pnlLubOil_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlLubOil.BackgroundImage = bitmap;
		}


		//LPSW1

		private void pnlLPSW1_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmLPSW1", this);
		}

		private void pnlLPSW1_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlLPSW1.BackgroundImage = bitmap;
		}

		private void pnlLPSW1_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlLPSW1.BackgroundImage = bitmap;
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMGRDiscrepancies", this);
		}
	}
}
