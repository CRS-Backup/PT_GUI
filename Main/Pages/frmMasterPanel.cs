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
	public partial class frmMasterPanel : Form
	{
		bool normal_check;
		bool run_check;

		public frmMasterPanel()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 792);
		}

		//  Initial Conditions

		private void pnlSelectionpanel1_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel1.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel1_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel1.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel1_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmInitialCond",  Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		//  External Conditions

		private void pnlSelectionpanel2_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel2.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel2_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel2.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel2_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmExternalCond",  Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		//  Resets

		private void pnlSelectionpanel3_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel3.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel3_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel3.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel3_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmResets", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		// Snap Shot

		private void pnlSelectionpanel4_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmSnapShot", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		private void pnlSelectionpanel4_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel4.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel4_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel4.BackgroundImage = bitmap;
		}


		// Back Track

		private void pnlSelectionpanel5_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel5.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel5_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel5.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel5_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmBackTrack", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		// Panel Test

		private void pnlSelectionpanel6_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel6.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel6_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel6.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel6_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmPanelTest", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		// Panel Override

		private void pnlSelectionpanel7_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_DOWN);
			pnlSelectionpanel7.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel7_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_CYAN_UP);
			pnlSelectionpanel7.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel7_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmPanelOverrides", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		// Normal / Slow selection

		private void pnlSelectionpanel8_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_BLUE_DOWN);
			pnlSelectionpanel8.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel8_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_BLUE_UP);
			pnlSelectionpanel8.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel8_Click(object sender, EventArgs e)
		{

			Bitmap bitmap_slow = new Bitmap(Constants.BMP_SLOW);
			Bitmap bitmap_run = new Bitmap(Constants.BMP_RUN);

			if (normal_check == false)
			{
				pictureBox8.BackgroundImage = bitmap_run;
				normal_check = true;
			}
			else
			{
				pictureBox8.BackgroundImage = bitmap_slow;
				normal_check = false;
			}
		}

		// Run / Freeze selection

		private void pnlSelectionpanel10_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_BLUE_DOWN);
			pnlSelectionpanel10.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel10_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_BLUE_UP);
			pnlSelectionpanel10.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel10_Click(object sender, EventArgs e)
		{

			Bitmap bitmap_slow = new Bitmap(Constants.BMP_SLOW);
			Bitmap bitmap_run = new Bitmap(Constants.BMP_RUN);

			if (run_check == false)
			{
				pictureBox10.BackgroundImage = bitmap_run;
				run_check = true;
			}
			else
			{
				pictureBox10.BackgroundImage = bitmap_slow;
				run_check = false;
			}
		}

		// Outstation 1 selection

		// Outstation Menu

		private void pnlSelectionpanel12_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_YELLOW_DOWN);
			pnlSelectionpanel12.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel12_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_YELLOW_UP);
			pnlSelectionpanel12.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel12_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		// Outstation 1 selection

		// GT Malfunctions

		private void pnlSelectionpanel15_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel15.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel15_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel15.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel15_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmGTMalfunctions1", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		// GB Malfunctions

		private void pnlSelectionpanel17_MouseDown(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel17.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel17_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel17.BackgroundImage = bitmap;
		}


		private void pnlSelectionpanel17_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmGBMalfunctions1", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		// DG Malfunctions

		private void pnlSelectionpanel18_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel18.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel18_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel18.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel18_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmDGMalfunctions1", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		// Elec/MEPS Malfunctions

		private void pnlSelectionpanel19_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel19.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel19_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel19.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel19_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmElecMalfunctions1", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		// Maintenance Malfunctions

		private void pnlSelectionpanel20_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel20.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel20_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel20.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel20_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMaintMalfunctions1",  Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		// Propulsion Malfunctions

		private void pnlSelectionpanel16_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel16.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel16_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel16.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel16_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("newPropMalfunctions", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		//Misc Malfunctions 

		private void pnlSelectionpanel21_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel21.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel21_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel21.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel21_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfunctions", Constants.DO_NOT_ADD_TO_BACKLIST);
		}

		//Consequent Malfunctions 

		private void pnlSelectionpanel22_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel22.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel22_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel22.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel22_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmConseqMalfunctions", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		//Active Malfunctions 

		private void pnlSelectionpanel23_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_DOWN);
			pnlSelectionpanel23.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel23_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_RED_UP);
			pnlSelectionpanel23.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel23_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmActiveMalfunctions", Constants.DO_NOT_ADD_TO_BACKLIST);
		}


		//Back page
		private void pnlSelectionpanel25_Click(object sender, EventArgs e)
		{
		if (formList.backList.Count > 1)
			{
				formList.backList.RemoveAt(0);
				formList.backList[0].Show();
				formList.backList[0].BringToFront();
			}
		}


		private void pnlSelectionpanel25_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_GREEN_DOWN);
			pnlSelectionpanel25.BackgroundImage = bitmap;
		}

		private void pnlSelectionpanel25_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_SQUARE_BUTTON_GREEN_UP);
			pnlSelectionpanel25.BackgroundImage = bitmap;
		}

	}
}
