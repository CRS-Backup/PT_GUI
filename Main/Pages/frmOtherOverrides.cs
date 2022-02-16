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
	public partial class frmOtherOverrides: Form

	{
		public frmOtherOverrides()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmPropOverrides", this);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmElecOverrides", this);
		}


		//CW PUMP 1 START BUTTON

		private void pnlCWPpStart_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap_red = new Bitmap(Constants.BMP_RESET_BUTTON_RED_DOWN);
			Bitmap bitmap_green = new Bitmap(Constants.BMP_RESET_BUTTON_GREEN_DOWN);
			string Pressed = GuiCore.get_chan_val_string("LCWMIV1");

			if (Pressed == "false")
			{
				pnlCWPpStart.BackgroundImage = bitmap_red;
				GuiCore.set_channel_value("LCWMIV1", "true");
			}
			else
			{
				pnlCWPpStart.BackgroundImage = bitmap_green;
				GuiCore.set_channel_value("LCWMIV1", "false");
			}

		}

		private void pnlCWPpStart_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap_red = new Bitmap(Constants.BMP_RESET_BUTTON_RED_UP);
			Bitmap bitmap_green = new Bitmap(Constants.BMP_RESET_BUTTON_GREEN_UP);
			string Pressed = GuiCore.get_chan_val_string("LCWMIV1");

			if (Pressed == "false")
			{
				pnlCWPpStart.BackgroundImage = bitmap_green;
			}
			else
			{
				pnlCWPpStart.BackgroundImage = bitmap_red;
			}

		}

		//CW PUMP 1 INLET OPEN BUTTON

		private void pnlCWInletOpen_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap_red = new Bitmap(Constants.BMP_RESET_BUTTON_RED_DOWN);
			Bitmap bitmap_green = new Bitmap(Constants.BMP_RESET_BUTTON_GREEN_DOWN);
			string Pressed = GuiCore.get_chan_val_string("LCWMIV2");

			if (Pressed == "false")
			{
				pnlCWInletOpen.BackgroundImage = bitmap_red;
				GuiCore.set_channel_value("LCWMIV2", "true");
			}
			else
			{
				pnlCWInletOpen.BackgroundImage = bitmap_green;
				GuiCore.set_channel_value("LCWMIV2", "false");
			}

		}

		private void pnlCWInletOpen_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap_red = new Bitmap(Constants.BMP_RESET_BUTTON_RED_UP);
			Bitmap bitmap_green = new Bitmap(Constants.BMP_RESET_BUTTON_GREEN_UP);
			string Pressed = GuiCore.get_chan_val_string("LCWMIV2");

			if (Pressed == "false")
			{
				pnlCWInletOpen.BackgroundImage = bitmap_green;
			}
			else
			{
				pnlCWInletOpen.BackgroundImage = bitmap_red;
			}

		}
	}
}
