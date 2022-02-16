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
	public partial class frmMiscMalfunctions : Form

	{
	public frmMiscMalfunctions()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		// Fuel 
		private void panel1_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfFuel", this);
		}

			private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel1.BackgroundImage = bitmap;
		}

		private void panel1_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel1.BackgroundImage = bitmap;
		}

		//Chilled Water

		private void panel2_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfCW", this);
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel2.BackgroundImage = bitmap;
		}

		private void panel2_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel2.BackgroundImage = bitmap;
		}

		// HPSW and LPSW

		private void panel3_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfHPSW", this);
		}

		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel3.BackgroundImage = bitmap;
		}

		private void panel3_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel3.BackgroundImage = bitmap;
		}

		private void panel4_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel4.BackgroundImage = bitmap;
		}

		private void panel4_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel4.BackgroundImage = bitmap;
		}


		//HP and LP Air, Ventilation and Fresh Water

		private void panel5_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfHPAir", this);
		}

		private void panel5_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel5.BackgroundImage = bitmap;
		}

		private void panel5_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel5.BackgroundImage = bitmap;
		}

		private void panel6_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel6.BackgroundImage = bitmap;
		}

		private void panel6_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel6.BackgroundImage = bitmap;
		}

		private void panel7_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel7.BackgroundImage = bitmap;
		}

		private void panel7_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel7.BackgroundImage = bitmap;
		}


		// Desalination, Bilge and Sullage, Refrigeration and Steering

		private void panel8_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfDesal", this);
		}

		private void panel8_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel8.BackgroundImage = bitmap;
		}

		private void panel8_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel8.BackgroundImage = bitmap;
		}

		private void panel9_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel9.BackgroundImage = bitmap;
		}

		private void panel9_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel9.BackgroundImage = bitmap;
		}

		private void panel10_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel10.BackgroundImage = bitmap;
		}

		private void panel10_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel10.BackgroundImage = bitmap;
		}

		private void panel11_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel11.BackgroundImage = bitmap;
		}

		private void panel11_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel11.BackgroundImage = bitmap;
		}
				
		// NBCD
		private void panel12_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMiscMalfNBCD", this);
		}

		private void panel12_MouseDown(object sender, MouseEventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_DOWN);
			panel12.BackgroundImage = bitmap;
		}

		private void panel12_MouseLeave(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Constants.BMP_RECT_BUTTON_CYAN_UP);
			panel12.BackgroundImage = bitmap;
		}
	}
}
