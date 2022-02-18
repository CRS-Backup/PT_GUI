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
	public partial class frmGB_LCP : Form
	{
		public frmGB_LCP()
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

		private void pnlPort_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "IGBLCP", Constants.BMP_RESET_BUTTON_RED_UP, Constants.BMP_RESET_BUTTON_GREY_UP);
			// THINK THIS ACTUALLY SETS THE VALUE TO 2 (1 FOR STBD)

		}

		private void pnlStbd_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "IGBLCP", Constants.BMP_RESET_BUTTON_GREEN_UP, Constants.BMP_RESET_BUTTON_GREY_UP);
			// THINK THIS ACTUALLY SETS THE VALUE TO 1 (2 FOR PORT)

		}

		private void pnlOpen_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LGBI01", Constants.BMP_RECT_BUTTON_GREEN_UP, Constants.BMP_RECT_BUTTON_GREY_UP);
		}

		private void pnlShut_Click(object sender, EventArgs e)
		{
			GuiCore.toggle_channel(sender, "LGBI02", Constants.BMP_RECT_BUTTON_RED_UP, Constants.BMP_RECT_BUTTON_GREY_UP);
		}

		private void pnlRemote_Click(object sender, EventArgs e)
		{
			// LGBX08[0,1] GEAR BOX LCP REMOTE LAMP
		}

		private void pnlLocal_Click(object sender, EventArgs e)
		{
			// LGBX07[0,1] GEAR BOX LCP LOCAL LAMP

		}

		private void pnlSWLocalRemote_Click(object sender, EventArgs e)
		{

		}

	}
}
