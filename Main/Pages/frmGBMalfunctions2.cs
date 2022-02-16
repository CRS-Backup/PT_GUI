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
	public partial class frmGBMalfunctions2: Form

	{
		public frmGBMalfunctions2()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}
		
		private void PageFwd_Click(object sender, EventArgs e)
		{
			formList.newGBMalfunctions1.Show();
			formList.newGBMalfunctions1.BringToFront();
			formList.backList.Insert(0, formList.newGBMalfunctions1);

		}

		private void PageBack_Click(object sender, EventArgs e)
		{
			formList.newGBMalfunctions1.Show();
			formList.newGBMalfunctions1.BringToFront();
			formList.backList.Insert(0, formList.newGBMalfunctions1);
		}
	}
}
