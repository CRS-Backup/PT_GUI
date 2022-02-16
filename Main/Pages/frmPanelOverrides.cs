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
	public partial class frmPanelOverrides : Form

	{
		public frmPanelOverrides()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		// Propulsion Selection

		private void pnlPropulsion_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmPropOverrides", this);
		}

		private void pnlPropulsion_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_DOWN);
			pnlPropulsion.BackgroundImage = bitmap;
		}

		private void pnlPropulsion_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_UP);
			pnlPropulsion.BackgroundImage = bitmap;
		}

		// Electrical Generation Selection

		private void pnlElecGen_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmElecOverrides", this);
		}

		private void pnlElecGen_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_DOWN);
			pnlElecGen.BackgroundImage = bitmap;
		}

		private void pnlElecGen_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_UP);
			pnlElecGen.BackgroundImage = bitmap;
		}

		// Chilled Water and HP SeaWater Selection

		private void pnlHPSeawater_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOtherOverrides", this);
		}

		private void pnlHPSeawater_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_DOWN);
			pnlHPSeawater.BackgroundImage = bitmap;
		}

		private void pnlHPSeawater_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_UP);
			pnlHPSeawater.BackgroundImage = bitmap;
		}

		private void pnlCW_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_DOWN);
			pnlCW.BackgroundImage = bitmap;
		}

		private void pnlCW_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_UP);
			pnlCW.BackgroundImage = bitmap;
		}
	}
}
