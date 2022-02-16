using System;
using System.Drawing;
using System.Windows.Forms;

namespace PtGui
{
	public partial class frmSeaState : Form
	{
		public frmSeaState()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 792);
		}
		private void pnlCANCEL_Click(object sender, EventArgs e)
		{
			//The user has cancelled the update. 
			this.Hide();
		}

		private void pnlCalm_Click(object sender, EventArgs e)
		{
			GuiCore.set_channel_value("t_sea_state", "Calm");
			GuiCore.set_channel_value("IIXSVSS", 1);
			this.Hide();
		}

		private void pnlAverage_Click(object sender, EventArgs e)
		{
			GuiCore.set_channel_value("t_sea_state", "Average");
			GuiCore.set_channel_value("IIXSVSS", 2);
			this.Hide();
		}

		private void pnlRough_Click(object sender, EventArgs e)
		{
			GuiCore.set_channel_value("t_sea_state", "Rough");
			GuiCore.set_channel_value("IIXSVSS", 3);
			this.Hide();
		}
	}
}
