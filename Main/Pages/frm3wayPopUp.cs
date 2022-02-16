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
	public partial class frm3wayPopUp : Form
	{
		public frm3wayPopUp()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 792);
		}

		private void pnlCANCEL_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void lblCANCEL_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
