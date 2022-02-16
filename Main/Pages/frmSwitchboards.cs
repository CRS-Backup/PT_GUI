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
	public partial class frmSwitchboards : Form

	{

		public frmSwitchboards()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void pnlUAMR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmUAMROverview", this);
		}

		private void pnlFAMR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmFAMROverview", this);
		}

		private void pnlGTR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmGTROverview", this);
		}

		private void pnlMGR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmMGROverview", this);
		}

		private void pnlAVR_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmAVROverview", this);
		}
		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", this);
		}

	}
}
