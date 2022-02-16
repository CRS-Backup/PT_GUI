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
	public partial class frmExternalCond : Form

	{
		public frmExternalCond()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void cmdLoadHome_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMain", this);
		}

		// OUTSIDE AIR TEMPERATURE

		private void pnlAirTemp_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlAirTemp.BackgroundImage = bitmap;

			GuiCore.show_form("frmNumberKeypad", null);

			//TODO - get remote form reference to allow updates to values

			//Form frm = get_form("frmNumberKeypad");
			//frm.TitleLabel = "Outside Air Temperature";
			//frm.MaxValue = "30°C";
			//formList.newNumberKeypad.MinValue = "-20°C";
			//formList.newNumberKeypad.Show();

		}

		private void pnlAirTemp_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlAirTemp.BackgroundImage = bitmap;
		}

		private void lblCrsOutsideAirTemp_TextChanged(object sender, EventArgs e)
		{
			//Update the text value with the new CRS channel value defined on this object
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}


		//ELECTRICAL BLOCK LOAD CHANGES

		private void pnlElecLoadChanges_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlElecLoadChanges.BackgroundImage = bitmap;

			GuiCore.show_form("frmLoadChanges", null);
		}

		private void pnlElecLoadChanges_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlElecLoadChanges.BackgroundImage = bitmap;
		}

				  
		// TOWED ARRAY

		private void pnlTowedArray_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlTowedArray.BackgroundImage = bitmap;

			string towed_array_state = GuiCore.get_chan_val_string("t_towed_array");

			if (towed_array_state == "Unattached")
			{
				GuiCore.set_channel_value("LIXSVTW", "true");
				GuiCore.set_channel_value("t_towed_array", "Attached");
			}
			else
			{
				GuiCore.set_channel_value("LIXSVTW", "false");
				GuiCore.set_channel_value("t_towed_array", "Unattached");
			}
		}

		private void pnlTowedArray_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlTowedArray.BackgroundImage = bitmap;
		}


		// SHORE SUPPLIES FORWARD


		private void pnlShoreSuppliesFwd_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlShoreSuppliesFwd.BackgroundImage = bitmap;

			string shore_supplies_fwd_state = GuiCore.get_chan_val_string("t_shore_supplies_fwd");

			if (shore_supplies_fwd_state == "No")
			{
				GuiCore.set_channel_value("LIXSVFD", "true");
				GuiCore.set_channel_value("t_shore_supplies_fwd", "Yes");
			}
			else
			{
				GuiCore.set_channel_value("LIXSVFD", "false");
				GuiCore.set_channel_value("t_shore_supplies_fwd", "No");
			}

		}

		private void pnlShoreSuppliesFwd_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlShoreSuppliesFwd.BackgroundImage = bitmap;
		}


		// GT ICING

				private void pnlGTIcing_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlGTIcing.BackgroundImage = bitmap;

			string gt_icing_state = GuiCore.get_chan_val_string("t_gt_icing");

			if (gt_icing_state == "Off")
			{
				GuiCore.set_channel_value("LIXSVICE", "true");
				GuiCore.set_channel_value("t_gt_icing", "On");
			}
			else
			{
				GuiCore.set_channel_value("LIXSVICE", "false");
				GuiCore.set_channel_value("t_gt_icing", "Off");
			}
		}

		private void pnlGTIcing_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlGTIcing.BackgroundImage = bitmap;
		}


		// SHORE SUPPLIES AFT

		private void pnlShoreSuppliesAft_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlShoreSuppliesAft.BackgroundImage = bitmap;

			string shore_supplies_aft_state = GuiCore.get_chan_val_string("t_shore_supplies_aft");

			if (shore_supplies_aft_state == "No")
			{
				GuiCore.set_channel_value("LIXSVAF", "true");
				GuiCore.set_channel_value("t_shore_supplies_aft", "Yes");
			}
			else
			{
				GuiCore.set_channel_value("LIXSVAF", "false");
				GuiCore.set_channel_value("t_shore_supplies_aft", "No");
			}
		}

		private void pnlShoreSuppliesAft_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlShoreSuppliesAft.BackgroundImage = bitmap;
		}


		// SEA STATE

		private void pnlSeaState_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_DOWN);
			pnlSeaState.BackgroundImage = bitmap;

			GuiCore.show_form("frmSeaState", null);
		}

		private void pnlSeaState_MouseUp(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_LONG_BUTTON_GREEN_UP);
			pnlSeaState.BackgroundImage = bitmap;
		}

		private void lblCrsSeaState_TextChanged(object sender, EventArgs e)
		{
			//Update the text value with the new CRS channel value defined on this object
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}

	}
}
