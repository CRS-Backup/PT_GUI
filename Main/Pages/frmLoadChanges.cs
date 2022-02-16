using System;
using System.Drawing;
using System.Windows.Forms;

namespace PtGui
{
	public partial class frmLoadChanges : Form
	{
		public frmLoadChanges()
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

		private void lbl800kW_Click(object sender, EventArgs e)
		{
			GuiCore.set_channel_value("t_elec_load_change", "800 KW");
			GuiCore.set_channel_value("IIXSVLD", 1);
			this.Hide();
		}

		private void lbl1000kW_Click(object sender, EventArgs e)
        {
			GuiCore.set_channel_value("t_elec_load_change", "1000 KW");
			GuiCore.set_channel_value("IIXSVLD", 2);
			this.Hide();
		}

		private void lbl1200kW_Click(object sender, EventArgs e)
        {
			GuiCore.set_channel_value("t_elec_load_change", "1200 KW");
			GuiCore.set_channel_value("IIXSVLD", 3);
			this.Hide();
		}

		private void lbl1400kW_Click(object sender, EventArgs e)
        {
			GuiCore.set_channel_value("t_elec_load_change", "1400 KW");
			GuiCore.set_channel_value("IIXSVLD", 4);
			this.Hide();
		}

	}
}
