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
	public partial class frmBackTrack : Form

	{
		public frmBackTrack()
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
