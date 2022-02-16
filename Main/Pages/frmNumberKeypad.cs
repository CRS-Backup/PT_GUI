using System;
using System.Drawing;
using System.Windows.Forms;

namespace PtGui
{
	public partial class frmNumberKeypad : Form
	{
		string edit_val = "";
#if false
		public string TitleLabel
		{
			set { this.lblTitle.Text = value; }
		}
		public string MaxValue
		{
			set { this.lblMaxValue.Text = value; }
		}
		public string MinValue
		{
			set { this.lblMinValue.Text = value; }
		}
		public string Value
		{
			set { this.lblValue.Text = value; }
		}
#endif //false
		public frmNumberKeypad()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 792);
		}
		private void pnlCANCEL_Click(object sender, EventArgs e)
		{
			//Clear the temporary Edit value
			edit_val = "";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);

			//Show the Master Panel
			GuiCore.show_form("frmMasterPanel", this);
		}

        private void pnl1_Click(object sender, EventArgs e)
        {
			edit_val += "1";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

        private void pnl2_Click(object sender, EventArgs e)
        {
			edit_val += "2";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

        private void pnl3_Click(object sender, EventArgs e)
        {
			edit_val += "3";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl4_Click(object sender, EventArgs e)
        {
			edit_val += "4";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl5_Click(object sender, EventArgs e)
        {
			edit_val += "5";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl6_Click(object sender, EventArgs e)
        {
			edit_val += "6";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl7_Click(object sender, EventArgs e)
        {
			edit_val += "7";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl8_Click(object sender, EventArgs e)
        {
			edit_val += "8";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl9_Click(object sender, EventArgs e)
        {
			edit_val += "9";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnl0_Click(object sender, EventArgs e)
        {
			edit_val += "0";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnlPlusMinus_Click(object sender, EventArgs e)
        {
			//Check if there is a '-' in the string (on the front)
			if (!edit_val.Contains("-"))
			{
				//Add a leading '-'
				edit_val = "-" + edit_val;
			}
			else
            {
				//Remove the leading '-'
				edit_val = edit_val.TrimStart('-');
			}
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnlPoint_Click(object sender, EventArgs e)
        {
			//Add a decimal point, as long as one doesn't already exist
			if (!edit_val.Contains("."))
			{
				edit_val += ".";
				GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
			}
		}

		private void pnlDelete_Click(object sender, EventArgs e)
        {
			//Remove the last character from the string
			if(edit_val.Length > 0) edit_val = edit_val.Substring(0, edit_val.Length - 1);
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnlClear_Click(object sender, EventArgs e)
        {
			//Clear the temporary Edit value
			edit_val = "";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}

		private void pnlEnter_Click(object sender, EventArgs e)
        {
			//User wants to accept the value
			double new_val = 0;

			//Convert to a number so we can check it is valid
			Double.TryParse(edit_val, out new_val);
			if (new_val >= 0 && new_val <= 100)
			{
				//Set the Output channel to the new value
				GuiCore.set_channel_value("o_storageTankLevel", new_val);

				//Clear the temp edit value
				edit_val = "";
				GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);

				//Show the Master Panel
				GuiCore.show_form("frmMasterPanel", this);
			}
			else
            {

				//Problem with value - let the user know about it
				string caption = ">>> ERROR - Invalid value <<<";
				string message = Environment.NewLine + $"Storage Tank Level must be from 0 to 100";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBox.Show(message, caption, buttons);
			}

		}

        private void frmNumberKeypad_Activated(object sender, EventArgs e)
        {
		}

        private void frmNumberKeypad_Enter(object sender, EventArgs e)
        {
			edit_val = "";
			GuiCore.set_channel_value("t_frmNumKeyVal", edit_val);
		}
	}
}
