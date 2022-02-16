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
	public partial class frmElecMalfunctions2: Form

	{
		public frmElecMalfunctions2()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void PageFwd_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmElecMalfunctions1", this);
		}


		private void PageBack_Click(object sender, EventArgs e)
		{
			GuiCore.show_form("frmElecMalfunctions1", this);
		}
	}
}
