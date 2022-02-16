using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PtGui
{

    public partial class GuiCore
    {
        public static FileSystemWatcher watcher;
        public static ChannelData channelData = new ChannelData();
        public static ChannelDefinitions channelDefinitions = new ChannelDefinitions();
        public static int IO_file_read_timeout_ms = 15000;       

        //General folder definitions
        public static string GUI_folder = Constants.ROOT_FOLDER;         //This can be over-ridden for Windows systems at startup by command line args
        public static string logfile_subfolder = @"/logs";
        public static string GUI_report_folder = GUI_folder + logfile_subfolder;


        //Channels definitions file
        public static string channels_definitions = @"channels_database.json";
        public static string full_channels_definitions_file = Path.Combine(GuiCore.GUI_folder, GuiCore.channels_definitions);
        public static StreamWriter file_channels_definitions_sw = null;
        public static bool channels_definitions_initialised = false;


        //File data for Input data - handled by FileSystemWatcher
        public static string file_input_data = @"input_channels.json";
        public static string lastMessage_input_data = "";
        public static string full_input_file = Path.Combine(GuiCore.GUI_folder, GuiCore.file_input_data);
        public static StreamWriter file_input_data_sw = null;
        public static bool inputData_initialised = false;
        public static int read_count = 0;          //How many times the input file has been read


        //File data for Internal data
        public static string file_internal_data = @"internal_channels.json";
        public static string lastMessage_internal_data = "";
        public static StreamWriter file_internal_data_sw = null;
        public static string full_internal_file = Path.Combine(GuiCore.GUI_folder, GuiCore.file_internal_data);
        public static bool internalData_initialised = false;
        public static int max_internal_file_write_size = 0;
        public static int internal_write_count = 0;          //How many times the internal file has been written


        //File data for Output data
        public static string file_output_data = @"output_channels.json";
        public static string lastMessage_output_data = "";
        public static StreamWriter file_output_data_sw = null;
        public static string full_output_file = Path.Combine(GuiCore.GUI_folder, GuiCore.file_output_data);
        public static bool outputData_initialised = false;
        public static int max_output_file_write_size = 0;
        public static int output_write_count = 0;          //How many times the output file has been written


        //FileSystemWatcher file read retries
        static int max_retry_count = 3;
        static int retry_read_delay_ms = 5;         //Time between retry a file read
        static int retry_write_delay_ms = 1;    //Time between retry a file write

        //File data for Report file
        public static string report_file_extension = @".txt";
        public static string file_core_report = @"PT_GUI_report";
        public static StreamWriter file_core_report_sw = null;
        public static int file_core_report_lines = 0;

        //File for Startup parameters (engine rating etc)
        public static string file_startup_definitions = @"startup_params.json";


        //=======================================================================
        //
        //                          CHANNEL DEFINITIONS
        //
        //=======================================================================

        //
        //-----------------      read_channel_definitions     ---------------------
        //
        /// <summary>
        /// JSON parses Channel Definitions file data
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool read_channel_definitions()
        {
            //The complete file has been read into a single line
            //Remove whitespace
            //string json = Regex.Replace(line, @"\s", "");
            string json_data = "";
            bool success = true;
            string caption = "";
            string message = "";


            try
            {

                //Open file
                var reader = new StreamReader(full_channels_definitions_file);
                if (reader == null)
                {
                    caption = ">>> ERROR - Channels Definitions file Missing <<<";
                    message = $"failed to open channels definition file {full_channels_definitions_file}";
                    message += Environment.NewLine + Environment.NewLine + $"This program will terminate";
                    log_message(message);
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    return false;
                }

                //Read channel definitions into a single string, ready to parse from json
                using (reader)
                {
                    while (!reader.EndOfStream)
                    {
                        json_data += reader.ReadLine();
                    }
                    if (json_data.Length == 0)
                    {
                        caption = ">>> ERROR - Channels Definitions file Missing <<<";
                        message = $"no data read from channels definition file {full_channels_definitions_file}";
                        message += Environment.NewLine + Environment.NewLine + $"This program will terminate";
                        log_message(message);
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        return false;
                    }
                }



                //Extract the channel definitions from json
                channelDefinitions = JsonConvert.DeserializeObject<ChannelDefinitions>(json_data);
                //This is the first time. Also copy in the channels to the full I/O list
                //After the first pass, the controls objects are added to this list
                channelData.inputData = channelDefinitions.inputChannels;
                channelData.inputData.comment = "Input data. For testing, you can manually edit the 'value' field and save the file to update the value on-screen";
                channelData.internalData = channelDefinitions.internalChannels;
                channelData.internalData.comment = "Internal data. (you cannot edit these values)";
                channelData.outputData = channelDefinitions.outputChannels;
                channelData.outputData.comment = "Output data. (you cannot edit these values)";

                message = $"channels definition file read: {channelData.inputData.channelList.Count} input channels, ";
                message += $"{channelData.internalData.channelList.Count} internal channels, ";
                message += $"{channelData.outputData.channelList.Count} output channels, ";
                log_message(message);

            }
            catch (Exception ex)
            {
                log_message($"read_channel_definitions exception: {ex.Message} on file {full_channels_definitions_file}");
                success = false;
            }

            return success;
        }



        //=======================================================================
        //
        //                          INPUT DATA
        //
        //=======================================================================


        //
        //-----------------      create_input_data_file     ---------------------
        //
        /// <summary>
        /// Creates/opens the file to read input data from
        /// If the file does not exist, the Input channel entries are written into it
        /// This is not necessary for the program to run, but makes testing easier
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool create_input_data_file()
        {
            bool success = true;
            string message;
            string caption;
            string line = "";

            try
            {

                if (File.Exists(full_input_file))
                {

                    System.IO.StreamReader file_input_data_sr = new System.IO.StreamReader(Path.Combine(GUI_folder, file_input_data));
                    if (file_input_data_sr == null)
                    {
                        caption = ">>> ERROR - Input Channels file <<<";
                        message = $"failed to open/create Input channels definition file for reading: {full_input_file}";
                        message += Environment.NewLine + Environment.NewLine + $"This program will terminate";
                        log_message(message);
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                        return false;
                    }


                    //See if there is already data in the file
                    while (!file_input_data_sr.EndOfStream)
                    {
                        line += file_input_data_sr.ReadLine();
                    }
                    file_input_data_sr.Close();
                    //If the file exists and there is data there. Do not overwrite it
                    if (line.Length > 0) return true;
                }


                //The file is empty. Write the Input channel definitions into it

                file_input_data_sw = new System.IO.StreamWriter(Path.Combine(GUI_folder, file_input_data));
                if (file_input_data == null)
                {
                    caption = ">>> ERROR - Input Channels file <<<";
                    message = $"failed to open Input channels definition file for writing: {full_input_file}";
                    message += Environment.NewLine + Environment.NewLine + $"This program will terminate";
                    log_message(message);
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    return false;
                }

                if (!write_input_data_file()) success = false;
                file_input_data_sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open input file: {file_input_data} with error: {ex.Message}");
                success = false;
            }
            return success;
        }


        //
        //-----------------      read_input_data     ---------------------
        //
        /// <summary>
        /// JSON parses INPUT data
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool read_input_data(string line, FileSystemEventArgs e)
        {
            //The complete file has been read into a single line
            //Remove whitespace
            //string json = Regex.Replace(line, @"\s", "");
            string json = line;

            try
            {
                //Extract the Input data
                ChannelEntries fileInputData = JsonConvert.DeserializeObject<ChannelEntries>(json);
                if (!inputData_initialised)
                {
                    //This is the first time. Also copy in the channels to the full I/O list
                    //After the first pass, the controls objects are added to this list
                    channelData.inputData = JsonConvert.DeserializeObject<ChannelEntries>(json);
                    inputData_initialised = true;
                }
                else
                {
                    //Not the first pass. Copy the value data over without overwriting the controls entries
                    var fid = fileInputData.channelList;
                    for (int iChan = 0; iChan < fid.Count; iChan++)
                    {
                        channelData.inputData.channelList[iChan].value = fid[iChan].value;
                    }
                }
                GuiCore.channelData.inputData.new_data = true;
            }
            catch (Exception ex)
            {
                log_message($"read_input_data Parse to JSON error: {ex.Message} on file {e.FullPath}");
            }

            read_count++;
            return true;
        }



        //
        //-----------------      write_input_data_file     ---------------------
        //
        /// <summary>
        /// Writes input data to file - this is only used once at startup to fill in the channel
        /// details in the file if there is no file present.
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool write_input_data_file()
        {
            try
            {
                if (file_input_data_sw == null)
                {
                    log_message($"input data file {full_input_file} not opened");
                    return false;
                }

                bool write_to_file = (file_input_data_sw == null) ? false : true;
                if (!write_to_file)
                {
                    log_message($"failed to open input data file {full_input_file}");
                    return false;
                }

                string json = "";
                file_input_data_sw.Flush();
                file_input_data_sw.BaseStream.Seek(0, SeekOrigin.Begin);    //Rewind file to the start

                //Add Timestamp to file
                DateTime utcDate = DateTime.UtcNow;
                GuiCore.channelData.inputData.timestamp = utcDate.ToString();

                //Write data to the file
                json += JsonConvert.SerializeObject(GuiCore.channelData.inputData, Formatting.Indented);
                file_input_data_sw.WriteLine(json);
                file_input_data_sw.Flush();

            }
            catch (Exception e)
            {
                log_message(e.Message + " Exception caught writing to input file: " + file_input_data);
                return false;
            }
            GuiCore.channelData.inputData.new_data = false;
            return true;

        }


        //=======================================================================
        //
        //                          INTERNAL DATA
        //
        //=======================================================================


        //
        //-----------------      create_internal_data_file     ---------------------
        //
        /// <summary>
        /// Creates/opens the file to send (internal channels) data to
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool create_internal_data_file()
        {
            bool success = true;
            try
            {
                file_internal_data_sw = new System.IO.StreamWriter(Path.Combine(GUI_folder, file_internal_data));
                if (file_internal_data == null) success = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open internal file: {file_internal_data} with error: {ex.Message}");
                success = false;
            }
            return success;
        }


#if false
        //
        //-----------------      read_internal_data     ---------------------
        //
        /// <summary>
        /// JSON parses internal data - this is read once to see what channels are defined
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool read_internal_data(string line, FileSystemEventArgs e)
        {
            //The complete file has been read into a single line
            //Remove whitespace
            //string json = Regex.Replace(line, @"\s", "");
            string json = line;

            try
            {
                //This is the first time. Also copy in the channels to the full I/O list
                //After the first pass, the controls objects are added to this list
                channelData.internalData = JsonConvert.DeserializeObject<ChannelEntries>(json);
                internalData_initialised = true;
            }
            catch (Exception ex)
            {
                log_message($"read_internal_data Parse to JSON error: {ex.Message} on file {e.FullPath}");
            }

            return true;
        }
#endif //false


        //
        //-----------------      write_internal_data_file     ---------------------
        //
        /// <summary>
        /// Writes internal data to file (for logging purposes)
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool write_internal_data_file()
        {
            try
            {
                if (file_internal_data_sw == null)
                {
                    log_message($"Internal data file {full_internal_file} not opened");
                    return false;
                }

                bool write_to_file = (file_internal_data_sw == null) ? false : true;
                if (!write_to_file)
                {
                    log_message($"failed to open internal data file {full_internal_file}");
                    return false;
                }

                string json = "";
                file_internal_data_sw.Flush();
                file_internal_data_sw.BaseStream.Seek(0, SeekOrigin.Begin);    //Rewind file to the start

                //Add Timestamp to file
                DateTime utcDate = DateTime.UtcNow;
                GuiCore.channelData.internalData.timestamp = utcDate.ToString();

                //Write data to the file
                json += JsonConvert.SerializeObject(GuiCore.channelData.internalData, Formatting.Indented);
                //There is a problem where the last entries in the file are not removed 
                //if a shorter json string is written, e.g. after a Damage entry has been deleted
                if (json.Length < max_internal_file_write_size)
                {
                    string pad = string.Empty.PadRight(max_internal_file_write_size - json.Length, (char)32);
                    json += pad;
                }
                file_internal_data_sw.WriteLine(json);
                file_internal_data_sw.Flush();

                if (json.Length > max_internal_file_write_size)
                {
                    max_internal_file_write_size = json.Length;
                }
                internal_write_count++;             //how many times data has been written to the internal file
            }
            catch (Exception e)
            {
                log_message(e.Message + " Exception caught writing to Internal file: " + file_internal_data);
                return false;
            }
            GuiCore.channelData.internalData.new_data = false;
            return true;

        }

        //=======================================================================
        //
        //                          OUTPUT DATA
        //
        //=======================================================================


        //
        //-----------------      create_output_data_file     ---------------------
        //
        /// <summary>
        /// Creates/opens the file to send output data to
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool create_output_data_file()
        {
            bool success = true;
            try
            {
                file_output_data_sw = new System.IO.StreamWriter(Path.Combine(GUI_folder, file_output_data));
                if (file_output_data_sw == null) success = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open output file: {file_output_data} with error: {ex.Message}");
                success = false;
            }
            return success;
        }


#if false
        //
        //-----------------      read_output_data     ---------------------
        //
        /// <summary>
        /// JSON parses OUTPUT data - this is read once to see what channels are defined
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool read_output_data(string line, FileSystemEventArgs e)
        {
            //The complete file has been read into a single line
            //Remove whitespace
            //string json = Regex.Replace(line, @"\s", "");
            string json = line;

            try
            {
                //This is the first time. Also copy in the channels to the full I/O list
                //After the first pass, the controls objects are added to this list
                channelData.outputData = JsonConvert.DeserializeObject<ChannelEntries>(json);
                outputData_initialised = true;
            }
            catch (Exception ex)
            {
                log_message($"read_output_data Parse to JSON error: {ex.Message} on file {e.FullPath}");
            }

            return true;
        }
#endif //false


        //
        //-----------------      write_output_data_file     ---------------------
        //
        /// <summary>
        /// Writes OUTPUT data to file
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool write_output_data_file()
        {
            try
            {
                if (file_output_data_sw == null)
                {
                    log_message($"Output data file {full_output_file} not opened");
                    return false;
                }

                bool write_to_file = (file_output_data_sw == null) ? false : true;
                if (!write_to_file)
                {
                    log_message($"failed to open Output data file {full_output_file}");
                    return false;
                }

                string json = "";
                file_output_data_sw.Flush();
                file_output_data_sw.BaseStream.Seek(0, SeekOrigin.Begin);    //Rewind file to the start

                //Add Timestamp to file
                DateTime utcDate = DateTime.UtcNow;
                GuiCore.channelData.outputData.timestamp = utcDate.ToString();

                //Write data to the file
                json += JsonConvert.SerializeObject(GuiCore.channelData.outputData, Formatting.Indented);
                //There is a problem where the last entries in the file are not removed 
                //if a shorter json string is written, e.g. after a Damage entry has been deleted
                if (json.Length < max_output_file_write_size)
                {
                    string pad = string.Empty.PadRight(max_output_file_write_size - json.Length, (char)32);
                    json += pad;
                }
                file_output_data_sw.WriteLine(json);
                file_output_data_sw.Flush();

                if (json.Length > max_output_file_write_size)
                {
                    max_output_file_write_size = json.Length;
                }
                output_write_count++;             //how many times data has been written to the output file
            }
            catch (Exception e)
            {
                log_message(e.Message + " Exception caught writing to Output file: " + file_output_data);
                return false;
            }
            GuiCore.channelData.outputData.new_data = false;
            return true;

        }



        //
        //-----------------      open_report_file     ---------------------
        //
        /// <summary>
        /// Opens a file to report to
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool open_report_file()
        {
            DateTime utcDate = DateTime.UtcNow;
            bool success = true;
            try
            {
                //Add a timestamp to the file to make it unique
                //string ts_file = file_core_report + "_" + utcDate.ToString("yyMMdd_HHmmss") + report_file_extension;
                string ts_file = file_core_report + report_file_extension;
                file_core_report_sw = new StreamWriter(Path.Combine(GUI_report_folder, ts_file));
                if (file_core_report_sw == null) success = false;
            }
            catch (Exception ex)
            {
                log_message($"Failed to open output file: {file_core_report} with error: {ex.Message}");
                success = false;
            }
            return success;
        }



        //
        //-----------------      touch_file     ---------------------
        //
        /// <summary>
        /// make a file appear as though it has been modified equivalent of linux 'touch'
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool touch_file(string fileName)
        {
            try
            {
                System.IO.File.SetLastWriteTimeUtc(fileName, DateTime.UtcNow);
            }

            catch (Exception ex)
            {
                log_message($"touch_file failed for {fileName} with error: {ex.Message}");
                return false;
            }
            return true;
        }



        //
        //-----------------      log_message     ---------------------
        //
        /// <summary>
        /// Writes timestamped message to the ACE report file
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool log_message(string message)
        {
            bool status = false;

            status = write_to_report_file(message);
            return status;
        }



        //
        //-----------------      write_to_report_file     ---------------------
        //
        /// <summary>
        /// Writes timestamped message to the passed report file
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool write_to_report_file(string message)
        {

            //Create report file from ace_core
            string report_message = "";
            DateTime utcDate = DateTime.UtcNow;
            StreamWriter file_sw = null;
            string file_name = "";
            int line_count = 0;

            try
            {
                file_sw = file_core_report_sw;
                file_name = file_core_report;
                file_core_report_lines++;
                line_count = file_core_report_lines;
                
                report_message = line_count.ToString() + "," + utcDate.ToString("yyMMdThhmmss.fffZ") + "," + message;

                if (file_sw != null)
                {
                    file_sw.WriteLine(report_message);
                    file_sw.Flush();
                }
                else
                {
                    //No file - write to console
                    Console.WriteLine($"{report_message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"write_report_file exception on file: {file_name} with error: {ex.Message}");
                return false;
            }
            return true;
        }

    }
}