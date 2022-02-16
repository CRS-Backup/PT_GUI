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
	public partial class frmGB_LCP : Form
	{
		public frmGB_LCP()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void pnlLocal_Click(object sender, EventArgs e)
		{
			pnlSWLocal.Show();
			pnlSWRemote.Hide();
		}

		private void lblLocal_Click(object sender, EventArgs e)
		{
			pnlSWLocal.Show();
			pnlSWRemote.Hide();
		}

		private void pnlRemote_Click(object sender, EventArgs e)
		{
			pnlSWLocal.Hide();
			pnlSWRemote.Show();
		}

		private void lblRemote_Click(object sender, EventArgs e)
		{
			pnlSWLocal.Hide();
			pnlSWRemote.Show();
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", null);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenu", null);
		}
	}
}
