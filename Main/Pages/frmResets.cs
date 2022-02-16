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
	public partial class frmResets : Form

	{
		public frmResets()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

	
		//  "Resetting" text is illuminated from frmMain


		//FUEL TANK CHANGE

		private void pnlChangeFuelTank_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlChangeFuelTank.BackgroundImage = bitmap;

			//Get the value of the Storage Channel output channel
			double tank_level = GuiCore.get_chan_val_double("o_storageTankLevel");

			//Set the value of the temporary Num Key form internal channel to the Tank Level
			GuiCore.set_channel_value("t_frmNumKeyEditVal", tank_level);

			//Set up the Num Key labels
			GuiCore.set_channel_value("t_frmNumKeyTitle", "Storage Tank Level");
			GuiCore.set_channel_value("t_frmNumKeyMax", "100%");
			GuiCore.set_channel_value("t_frmNumKeyMin", "0%");

			//Set the initial value of the Value label
			GuiCore.set_channel_value("t_frmNumKeyVal", tank_level);

			GuiCore.show_form("frmNumberKeypad");
		}

		private void pnlChangeFuelTank_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
			pnlChangeFuelTank.BackgroundImage = bitmap;
		}

		// SERVICE TANK CHANGE

		private void pnlChangeServiceTank_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlChangeServiceTank.BackgroundImage = bitmap;

			GuiCore.set_channel_value("t_frmNumKeyTitle", "Service Tank Level");
			GuiCore.set_channel_value("t_frmNumKeyMax", "100%");
			GuiCore.set_channel_value("t_frmNumKeyMin", "0%");
			GuiCore.set_channel_value("t_frmNumKeyVal", "");

			GuiCore.show_form("frmNumberKeypad");
		}

		private void pnlChangeServiceTank_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
			pnlChangeServiceTank.BackgroundImage = bitmap;
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmExternalCond", this);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmInitialCond", this);
		}


		//  reset button testing only

		private void panel1_Click(object sender, EventArgs e)
		{
			GuiCore.set_channel_value("LIXRDR", "false");
			GuiCore.set_channel_value("LIXRHP", "false");
			GuiCore.set_channel_value("LIXRLP", "false");
			GuiCore.set_channel_value("LIXRRC", "false");
			GuiCore.set_channel_value("LIXRGN", "false");

		}

		// HALON DRENCH

		private void pnlHalonDrench_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlHalonDrench.BackgroundImage = bitmap;

			GuiCore.set_channel_value("LIXRDR", "true");
			GuiCore.set_channel_value("t_rst_halon_drench", "Resetting");
		}

		private void pnlHalonDrench_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
			pnlHalonDrench.BackgroundImage = bitmap;
		}


		// HP AIR

		private void pnlHPAir_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlHPAir.BackgroundImage = bitmap;

			GuiCore.set_channel_value("LIXRHP", "true");
			GuiCore.set_channel_value("t_rst_hp_air", "Resetting");
		}

		private void pnlHPAir_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
			pnlHPAir.BackgroundImage = bitmap;
		}

		// LP AIR

		private void pnlLPAir_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlLPAir.BackgroundImage = bitmap;

			GuiCore.set_channel_value("LIXRLP", "true");
			GuiCore.set_channel_value("t_rst_lp_air", "Resetting");
		}

		private void pnlLPAir_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
			pnlLPAir.BackgroundImage = bitmap;
		}

		// RECHARGE BATTERIES

		private void pnlRechargeBatteries_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlRechargeBatteries.BackgroundImage = bitmap;

			GuiCore.set_channel_value("LIXRRC", "true");
			GuiCore.set_channel_value("t_rst_recharge_batteries", "Resetting");
		}
	
		private void pnlRechargeBatteries_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
		pnlRechargeBatteries.BackgroundImage = bitmap;
		}

		// GENERAL RESETS

			private void pnlGeneral_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_DOWN);
			pnlGeneral.BackgroundImage = bitmap;

			GuiCore.set_channel_value("LIXRGN", "true");
			GuiCore.set_channel_value("t_general_resets", "Resetting");
		}

		private void pnlGeneral_MouseUp(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RESET_BUTTON_CYAN_UP);
			pnlGeneral.BackgroundImage = bitmap;
		}

	}
}
