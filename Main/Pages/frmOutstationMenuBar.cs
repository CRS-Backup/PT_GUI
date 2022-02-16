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
	public partial class frmOutstationMenuBar : Form
	{
		public frmOutstationMenuBar()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 792);
		}

		//  UAMR Overview
		private void pnlUAMR_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_RED_DOWN);
			pnlUAMR.BackgroundImage = bitmap;
		}

		private void pnlUAMR_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_RED_UP);
			pnlUAMR.BackgroundImage = bitmap;
		}

		private void pnlUAMR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmUAMROverview", this);
		}

		//  FAMR Overview
		private void pnlFAMR_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_YELLOW_DOWN);
			pnlFAMR.BackgroundImage = bitmap;
		}

		private void pnlFAMR_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_YELLOW_UP);
			pnlFAMR.BackgroundImage = bitmap;
		}

		private void pnlFAMR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmFAMROverview", this);
		}

		//  GTR Overview
		private void pnlGTR_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			pnlGTR.BackgroundImage = bitmap;
		}

		private void pnlGTR_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			pnlGTR.BackgroundImage = bitmap;
		}

		private void pnlGTR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmGTROverview", this);
		}

		//  MGR Overview
		private void pnlMGR_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_BLUE_DOWN);
			pnlMGR.BackgroundImage = bitmap;
		}

		private void pnlMGR_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_BLUE_UP);
			pnlMGR.BackgroundImage = bitmap;
		}

		private void pnlMGR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMGROverview", this);
		}

		//  AVR Overview
		private void pnlAVR_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_MAGENTA_DOWN);
			pnlAVR.BackgroundImage = bitmap;
		}

		private void pnlAVR_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_MAGENTA_UP);
			pnlAVR.BackgroundImage = bitmap;
		}

		private void pnlAVR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmAVROverview", this);
		}

	}
}
