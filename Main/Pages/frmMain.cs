using PtGui;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PtGui
{
	public partial class frmMain : Form
	{

		public frmMain()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);

			{
				//frmMasterPanel newMasterPanel = new frmMasterPanel();
				// Show the selection bar form
				//newMasterPanel.Show();
			}
		}



		//
		//-----------------      Form1_Load     ---------------------
		//
		/// <summary>
		/// Main Form load point
		/// Runs forms initialisation code
		/// </summary>
		private void Form1_Load(object sender, EventArgs e)
		{
			//Define the links between control objects (buttons, labels etc) and the I/O channels

			try
			{
#if false
				//#########


				//Use reflection to go through the Assembly looking for forms that have been defined
				//(but are not loaded at this stage of the program)
				Assembly assembly = Assembly.GetExecutingAssembly();

				List<string> listAllForm = new List<string>();
				List<string> listAllControl = new List<string>();
				string control = string.Empty, form = string.Empty;
				foreach (Type assemblyType in assembly.GetTypes())
				{
					if (assemblyType.IsSubclassOf(typeof(Form)))
					{
						AssemblyName[] name = assembly.GetReferencedAssemblies();

						listAllForm.Add(assemblyType.Name);

						var vform = Activator.CreateInstance(Type.GetType("PtGui." + assemblyType.Name)) as Form;
						GuiCore.lstForms.Add(vform);
						//vform.ShowDialog();
					}
				}

				//#########



				//We have all the forms loaded. Go through each and create a link from the CRS
				//Controls (Buttons, Labels etc) to the database
				foreach (Form var in GuiCore.lstForms)
				{
					int links_made = GuiCore.setup_database_links(var);
					GuiCore.log_message($"Linked {links_made} CRS Controls from form {var.Name}");
				}

				//Link the channels/aliases on the CRS models to the database
				//GuiCore.setup_database_links(this);

				this.Text = Program.prog_name + " v" + Program.prog_version;

				//Trigger writes to the data monitor files to fill them in
				GuiCore.channelData.internalData.new_data = true;
				GuiCore.channelData.outputData.new_data = true;

				tmrUpdate.Enabled = true;
#endif //false

				//GuiCore.get_and_link_all_forms();
				this.Text = Program.prog_name + " v" + Program.prog_version;

				tmrUpdate.Enabled = true;
			}
			catch (Exception ex)
			{
				GuiCore.log_message($"Form1_Load Exception: " + ex.Message);
				return;
			}


		}



		//
		//-----------------      tmrUpdate_Tick     ---------------------
		//
		/// <summary>
		/// Main Form I/O cycle timer
		/// </summary>
		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			try
			{
				if (GuiCore.channelData.inputData.new_data || GuiCore.channelData.internalData.new_data || GuiCore.channelData.outputData.new_data)
				{
					//New input, internal or output data
					GuiCore.update_form_controls_values();
				}


				if (GuiCore.channelData.internalData.new_data)
				{
					GuiCore.channelData.internalData.new_data = false;
					//New internal data to write to the database (file)
					GuiCore.write_internal_data_file();
				}

				if (GuiCore.channelData.outputData.new_data)
				{
					//New output data to write to the database (file)
					GuiCore.channelData.outputData.new_data = false;
					GuiCore.write_output_data_file();
				}

				// 'Resetting' TEXT ON RESETS PAGE

				{
					string hp_air = GuiCore.get_chan_val_string("LIXRHP");
					if (hp_air == "true")
						GuiCore.set_channel_value("t_rst_hp_air", "Resetting");
					else
						GuiCore.set_channel_value("t_rst_hp_air", "");
				
					string halon_drench = GuiCore.get_chan_val_string("LIXRDR");
					if (halon_drench == "true")
						GuiCore.set_channel_value("t_rst_halon_drench", "Resetting");
					else
						GuiCore.set_channel_value("t_rst_halon_drench", "");
				
					string lp_air = GuiCore.get_chan_val_string("LIXRLP");
					if (lp_air == "true")
						GuiCore.set_channel_value("t_rst_lp_air", "Resetting");
					else
						GuiCore.set_channel_value("t_rst_lp_air", "");

					string recharge_batteries = GuiCore.get_chan_val_string("LIXRRC");
					if (recharge_batteries == "true")
						GuiCore.set_channel_value("t_rst_recharge_batteries", "Resetting");
					else
						GuiCore.set_channel_value("t_rst_recharge_batteries", "");

					string general_resets = GuiCore.get_chan_val_string("LIXRGN");
					if (general_resets == "true")
						GuiCore.set_channel_value("t_general_resets", "Resetting");
					else
						GuiCore.set_channel_value("t_general_resets", "");

				}



			}
			catch (Exception ex)
			{
				GuiCore.log_message($"tmrUpdate_Tick Exception: " + ex.Message);
				return;
			}
		}



		private void cmdStartLive_Click(object sender, EventArgs e)
		{
			if (cmdStartLive.Text == "Start Live Updates")
			{
				cmdStartLive.Text = "Stop Live Updates";
				tmrUpdate.Enabled = true;
			}
			else
			{
				cmdStartLive.Text = "Start Live Updates";
				tmrUpdate.Enabled = false;
			}
		}



		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string message = "You you really want to exit?";
			string caption = "End Program";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;

			//Display the MessageBox.
			result = MessageBox.Show(message, caption, buttons);
			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				//Closes the parent form.
				this.Close();
			}
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void cmdPage1Next_Click(object sender, EventArgs e)
		{
			tabMain.SelectTab(Constants.tabPagePropulsion);
		}

		private void cmdPage2Prev_Click(object sender, EventArgs e)
		{
			tabMain.SelectTab(Constants.tabPageMain);
		}

		private void cmdPage1Next_Click_1(object sender, EventArgs e)
		{

		}

		private void pnlLocalRemoteRight_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlLocalRemoteLeft_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlLocalRemoteLeft_Click(object sender, EventArgs e)
		{
			pnlLocalRemoteLeft.Hide();
			pnlLocalRemoteRight.Show();

			pnlLocalControlRed.Hide();
			pnlLocalControlGreen.Show();
			//TODO - Set channel value to something
		}

		private void pnlLocalRemoteRight_MouseClick(object sender, MouseEventArgs e)
		{
			pnlLocalRemoteRight.Hide();
			pnlLocalRemoteLeft.Show();

		    pnlLocalControlGreen.Hide();
			pnlLocalControlRed.Show();
			//TODO - Set channel value to something

		}

		private void pnlPlantControlStart_Click(object sender, EventArgs e)
		{
			pnlPlantControlStart.Hide();
			pnlPlantControlStop.Show();

			pnlLampPlantStopped.Hide();
			pnlLampPlantRunning.Show();
		}

		private void pnlPlantControlStop_Click(object sender, EventArgs e)
		{
			pnlPlantControlStop.Hide();
			pnlPlantControlStart.Show();

			pnlLampPlantRunning.Hide();
			pnlLampPlantStopped.Show();

		}

		private void cmdPadFailsetReset_Click(object sender, EventArgs e)
		{
			if (txtTextBox1.BackColor == Constants.BACKGROUND_ON)
			{
				txtTextBox1.BackColor = Constants.BACKGROUND_OFF;
				cmdPadFailsetReset.BackColor = Constants.BACKGROUND_OFF;
			}
			else
			{
				txtTextBox1.BackColor = Constants.BACKGROUND_ON;
				cmdPadFailsetReset.BackColor = Constants.BACKGROUND_ON;
			}
			



		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
		private void pnlCW_LCP_3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lblLocalControlAvailable_Click(object sender, EventArgs e)
		{

		}

		private void pnlLampPlantRunning_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlPlantControlStart_Paint(object sender, PaintEventArgs e)
		{

		}

        private void cmdCrsTest_Click(object sender, EventArgs e)
        {

			GuiCore.set_channel_value(sender, Constants.DIGITAL_ON.ToString());

		}

        private void lblCrsTest_CausesValidationChanged(object sender, EventArgs e)
        {
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}

		private void lblCrsTest_TextChanged(object sender, EventArgs e)
        {
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}

		private void cmdCrsTestZero_Click(object sender, EventArgs e)
        {
			GuiCore.set_channel_value(sender, Constants.DIGITAL_OFF);

		}

        private void cmdCrsTestToggle_Click(object sender, EventArgs e)
        {
			//Test code to toggle an Output channel
#if false
			string chan_val = GuiCore.get_channel_value(sender);
			chan_val = (chan_val == Constants.DIGITAL_OFF) ? Constants.DIGITAL_ON : Constants.DIGITAL_OFF;
			GuiCore.set_channel_value(sender, chan_val);
#endif //false

			string alias = "chan3002";
			string chan_val = GuiCore.get_chan_val_string(alias);
			chan_val = (chan_val == Constants.DIGITAL_OFF) ? Constants.DIGITAL_ON : Constants.DIGITAL_OFF;
			GuiCore.set_channel_value(alias, chan_val);

		}

        private void cmdCrsToggleInternal_Click(object sender, EventArgs e)
        {
			//Test code to toggle an Internal channel
#if false
			string chan_val = GuiCore.get_channel_value(sender);
			chan_val = (chan_val == Constants.DIGITAL_OFF) ? Constants.DIGITAL_ON : Constants.DIGITAL_OFF;
			GuiCore.set_channel_value(sender, chan_val);
#endif //false

			string alias = "t_tog_test";
			string chan_val = GuiCore.get_chan_val_string(alias);
			chan_val = (chan_val == Constants.DIGITAL_OFF) ? Constants.DIGITAL_ON : Constants.DIGITAL_OFF;
			GuiCore.set_channel_value(alias, chan_val);


		}

        private void lblCrsTest2_TextChanged(object sender, EventArgs e)
        {
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}

		private void lblCrsTest2_Click(object sender, EventArgs e)
        {

        }

        private void lblCrsScrollDisplay_TextChanged(object sender, EventArgs e)
        {
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
			string alias = "2001";
			GuiCore.set_channel_value(alias, hScrollBar1.Value);

		}

        private void lblCrsOutsideAirTemp_TextChanged(object sender, EventArgs e)
        {
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}

        private void cmdLoadFormTest_Click(object sender, EventArgs e)
        {
			GuiCore.show_form("frmExternalCond", this);
		}

        private void crsLabel1_TextChanged(object sender, EventArgs e)
        {
			//((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender);
		}
	}
}
