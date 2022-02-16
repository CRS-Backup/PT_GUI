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
	public partial class FormTest : Form
	{

	public FormTest()
		{
			InitializeComponent();
		}


		private void btnList_Click(object sender, EventArgs e)
		{

			if (formList.backList.Count > 4)
			{
				label1.Text = formList.backListx[0].ToString();
				label2.Text = formList.backListx[1].ToString();
				label3.Text = formList.backListx[2].ToString();
				label4.Text = formList.backListx[3].ToString();
				label5.Text = formList.backListx[4].ToString();
			}
		}
	}
}
