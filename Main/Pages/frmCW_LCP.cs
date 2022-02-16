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
	public partial class frmCW_LCP : Form
	{
		public frmCW_LCP()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void lblLocalRemoteControlSelect_Click(object sender, EventArgs e)
		{

		}

		private void cmdPadFailsetReset_Click(object sender, EventArgs e)
		{
			lblCWPanel.Text = "PLANT RUNNING OKAY\nUNDER REMOTE CONTROL";
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenuBar", this);
		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmOutstationMenuBar", this);
		}
	}
}
