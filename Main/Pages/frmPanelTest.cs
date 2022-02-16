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
	public partial class frmPanelTest : Form

	{
		public frmPanelTest()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void pnlAftSE_MouseDown(object sender, MouseEventArgs e)
		{

//			Bitmap bitmap_red = new Bitmap(Constants.BMP_HEX_BUTTON_RED_DOWN);
//			Bitmap bitmap_green = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_DOWN);
			
//			string AftSE = GuiCore.get_chan_val_string("LIXP67");

//			if (AftSE == "false")//
//			{
//				pnlAftSE.BackgroundImage = bitmap_red;
//				GuiCore.set_channel_value("LIXP67", "true");
//			}
//			else
//			{
//				pnlAftSE.BackgroundImage = bitmap_green;
//				GuiCore.set_channel_value("LIXP67", "false");
//			}
		}
		
		private void pnlAftSE_MouseUp(object sender, MouseEventArgs e)
		{
//			Bitmap bitmap_red = new Bitmap(Constants.BMP_HEX_BUTTON_RED_UP);
//			Bitmap bitmap_green = new Bitmap(Constants.BMP_HEX_BUTTON_GREEN_UP);
//
//			string AftSE = GuiCore.get_chan_val_string("LIXP67");
//
//			if (AftSE == "false")
//			{
//				pnlAftSE.BackgroundImage = bitmap_green;
//			}
//			else
//			{
//				pnlAftSE.BackgroundImage = bitmap_red;
//			}
		}

		private void pnlAftSE_MouseClick(object sender, MouseEventArgs e)
		{
			GuiCore.toggle_channel(sender, pnlAftSE, "LIXP67", Constants.BMP_HEX_BUTTON_RED_DOWN, Constants.BMP_HEX_BUTTON_RED_UP, "", "");

		}
	}
}
