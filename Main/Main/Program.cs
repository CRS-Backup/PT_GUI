using PtGui;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtGui
{
    internal static class Program
    //internal static partial class GuiCore
    //public partial class GuiCore
    //public partial class GuiCore
    {

        #region program_history
        public static string prog_name = "PT_GUI";
        //public static double prog_version = 0.01;     //27/11/21      initial trial of adding a 'channel name' entry to certain WinForm controls
        //public static double prog_version = 0.02;     //27/11/21      added code to access json files and made a start at hooking that to the forms controls
        //public static double prog_version = 0.03;     //28/11/21      more code changes for hooking inputs to forms controls
        //public static double prog_version = 0.04;     //28/11/21      got live input data updating on screen
        //public static double prog_version = 0.05;     //30/11/21      Added output signal structure (not working yet). Added GUI bitmap elements and tested layout
        //public static double prog_version = 0.06;     //12/01/22      Added Anna's latest pages and made some structural changes
        //public static double prog_version = 0.07;     //15/01/22      Redid and updated the model/database linkages. Live data into CRS Label models works
        //public static double prog_version = 0.08;     //18/01/22      Managed to get do to write to file
        //public static double prog_version = 0.09;     //19/01/22      Added get_channel_value(), set_channel_value() and multiple support functions to handle Alias
        //public static double prog_version = 0.10;     //20/01/22      Added internal channels and associated file handlers. Changed button & lable to use CrsChanNumOrAlias
        //public static double prog_version = 0.11;     //22/01/22      All channels now read from single file. Added more generic getCrsChanValue()
        //public static double prog_version = 0.12;     //23/01/22      On startup, if the Inputs Data file does not exist, it is created and written with the Input channels. If is does exist, it if not overwritten
        //public static double prog_version = 0.13;     //26/01/22      Added reflection code to open all forms to get access to CRS Controls
        //public static double prog_version = 0.14;     //29/01/22      changed form/controls linking, added show_form(), changed all the form loading, added more added try/catch error handling
        //public static double prog_version = 0.15;     //31/01/22      set_channel_value() acccept various data types, added get_form_by_name()
                                                        //              removed need for ((CRSControlsLib.CrsLabel)sender).Text = GuiCore.getCrsChanValue(sender); in lable text_change
                                                        //              changed get_chan_val to return various types
        public static double prog_version = 0.16;       //06/02/22      merged/added Anna's latest forms
                                                        //              updated show_form() to include add_to_backlist. Added some more variations
                                                        //              added example code behind NumberKeypad and frmReset



        #endregion //program_history        

        #region todo
        //TODO 
        //1. x   Read channel defs from database file rather than from input, internal and output files
        //2.    add a 2nd part to each channel value to allow temporary working copies of the value
        //3.    allow override values of inputs, internals and outputs to aid debugging

        #endregion //todo


        //
        //-----------------      Main     ---------------------
        //
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                check_command_line_args();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                GuiCore.open_report_file();                     //Reports general operation of the program
                                                                //GuiCore.create_output_data_file();
                string status_message = "GUI Core started, main folder: " + GuiCore.GUI_folder + ", program version: " + prog_version;
                GuiCore.log_message(status_message);


                //Read all channel definitions from main database file
                if (!GuiCore.read_channel_definitions()) return;


                //Create/Open channel values (data, not definitions) reporting files 
                //the Input data file is handled by FileSystemWatcher
                if (!GuiCore.create_input_data_file()) return;
                if (!GuiCore.create_internal_data_file()) return;
                if (!GuiCore.create_output_data_file()) return;


                //Setup FileSystemWatcher to check for changes to the database files
                if (!GuiCore.setup_fileSystemWatcher()) return;


                //Read the database input-channels file (via FileSystemWatcher)
                GuiCore.touch_file(GuiCore.full_input_file);
                GuiCore.log_message($"reading input file {GuiCore.full_input_file}");

                Stopwatch file_read_wait_timer = new Stopwatch();
                file_read_wait_timer.Start();
                //Wait for database file to be loaded - this happens async, so we have to wait for a 'completed' flag
                while (!GuiCore.inputData_initialised)
                {
                    if (file_read_wait_timer.ElapsedMilliseconds > GuiCore.IO_file_read_timeout_ms)
                    {

                        string message = "";
                        if (!GuiCore.inputData_initialised)
                        {
                            message = $"failed to read input I/O file {GuiCore.full_input_file}";
                        }
                        GuiCore.log_message(message);

                        string caption = ">>> ERROR - Program Initialisation <<<";
                        string report_file = Path.Combine(GuiCore.GUI_report_folder, GuiCore.file_core_report + GuiCore.report_file_extension);

                        message += Environment.NewLine + $"See file: {report_file} for more details";
                        message += Environment.NewLine + Environment.NewLine + $"This program will terminate";

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        Application.Exit();
                        return;
                    }

                }

                //
                GuiCore.get_and_link_all_forms();

                //Start the Main program
                GuiCore.log_message($"File Initialisation complete - starting GUI");
                //GuiCore.show_form("frmMain");
                GuiCore.show_form("frmMasterPanel", null);
                Form main_form = GuiCore.get_form_by_name("frmMain");
                if(main_form != null) Application.Run(main_form);
                GuiCore.log_message($"Main Program ended");
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"Main Exception: " + ex.Message);
                return;
            }

        }


        //
        //-----------------      check_command_line_args     ---------------------
        //
        /// <summary>
        /// Checks for command line argument flags
        /// returns nothing
        /// </summary>
        private static void check_command_line_args()
        {
            string strSuppressWarnings = "suppress_warnings";

            try
            {
                string[] args = Environment.GetCommandLineArgs();

                foreach (string arg in args)
                {
                    if (arg.ToLower().Contains(strSuppressWarnings))
                    {
                        GuiCore.dfSuppressWarnings = true;
                    }
                }
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"check_command_line_args Exception: " + ex.Message);
            }

        }

    }
}
