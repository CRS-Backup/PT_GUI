using System;
using System.IO;
using System.Threading;

namespace PtGui
{
    public partial class GuiCore
    {
        public static int file_system_watcher_exceptions = 0;


        //
        //-----------------      setup_fileSystemWatcher     ---------------------
        //
        /// <summary>
        /// Sets up FileSystemWatcher to monitor changes in data files
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool setup_fileSystemWatcher()
        {
            //Setup File System Watcher
            try
            {
                watcher = new FileSystemWatcher(GUI_folder);
                watcher.InternalBufferSize = 65536;
                watcher.NotifyFilter = NotifyFilters.LastWrite;

                watcher.Changed += OnChanged;
                watcher.Error += OnError;

                watcher.Filter = "*.json";
                watcher.EnableRaisingEvents = true;
                watcher.IncludeSubdirectories = false;

            }
            catch (Exception ex)
            {
                log_message($"setup_fileSystemWatcher error: {ex.Message}");
                return false;
            }

            return true;
        }



        //
        //-----------------      OnChanged     ---------------------
        //
        /// <summary>
        /// Called by OS when a monitored file changes
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            //--------------------    Input Data    --------------------

            if (e.Name == file_input_data)
            {
                int retry_count = 0;
                bool data_read = false;

                while (retry_count < max_retry_count && !data_read)
                {

                    try
                    {
                        //Read data from file
                        using (var reader = new StreamReader(e.FullPath))
                        {
                            string line = "";
                            while (!reader.EndOfStream)
                            {
                                line += reader.ReadLine();
                            }
                            if (line.Length > 0)
                            {
                                //This routine can get called twice in very quick succession by FileSystemWatched (e.g. 5ms)
                                //even though the file hasn't changed. Check the contents have actually changed
                                if (line != lastMessage_input_data)
                                {
                                    lastMessage_input_data = line;
                                    read_input_data(line, e);
                                }
                                data_read = true;

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        retry_count++;
                        if (retry_count < max_retry_count)
                        {
                            Thread.Sleep(retry_read_delay_ms);
                        }
                        else
                        {
                            //The OnChanged() is called twice when a file is updated
                            //The first call sometimes fails with "other process has the file open for writing" message
                            log_message($"File read error: {ex.Message} on file {e.FullPath}");
                        }
                    }

                }
            }

#if false

            //--------------------    internal Data    --------------------

            if (e.Name == file_internal_data)
            {
                int retry_count = 0;
                bool data_read = false;

                while (retry_count < max_retry_count && !data_read)
                {

                    try
                    {
                        //Read data from file
#if false
                        using (var reader = new StreamReader(e.FullPath))
                        {
                            string line = "";
                            while (!reader.EndOfStream)
                            {
                                line += reader.ReadLine();
                            }
                            if (line.Length > 0)
                            {
                                //This routine can get called twice in very quick succession by FileSystemWatched (e.g. 5ms)
                                //even though the file hasn't changed. Check the contents have actually changed
                                if (line != lastMessage_internal_data)
                                {
                                    lastMessage_internal_data = line;
                                    read_internal_data(line, e);
                                }
                                data_read = true;

                            }
                        }
#endif //false
                        using (file_output_data_sw = new System.IO.StreamReader(e.FullPath))
                        {
                            string line = "";
                            while (!file_output_data_sw.EndOfStream)
                            {
                                line += file_output_data_sw.ReadLine();
                            }
                            if (line.Length > 0)
                            {
                                //This routine can get called twice in very quick succession by FileSystemWatched (e.g. 5ms)
                                //even though the file hasn't changed. Check the contents have actually changed
                                if (line != lastMessage_internal_data)
                                {
                                    lastMessage_internal_data = line;
                                    read_internal_data(line, e);
                                }
                                data_read = true;

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        retry_count++;
                        if (retry_count < max_retry_count)
                        {
                            Thread.Sleep(retry_read_delay_ms);
                        }
                        else
                        {
                            //The OnChanged() is called twice when a file is updated
                            //The first call sometimes fails with "other process has the file open for writing" message
                            log_message($"File read error: {ex.Message} on file {e.FullPath}");
                        }
                    }

                }
            }

#endif //false



#if false
            //--------------------    Output Data    --------------------

            else if (e.Name == file_output_data)
            {
                int retry_count = 0;
                bool data_read = false;

                while (retry_count < max_retry_count && !data_read)
                {

                    try
                    {
                        //Read data from file
                        using (var reader = new StreamReader(e.FullPath))
                        {
                            string line = "";
                            while (!reader.EndOfStream)
                            {
                                line += reader.ReadLine();
                            }
                            if (line.Length > 0)
                            {
                                //This routine can get called twice in very quick succession by FileSystemWatched (e.g. 5ms)
                                //even though the file hasn't changed. Check the contents have actually changed
                                if (line != lastMessage_output_data)
                                {
                                    lastMessage_output_data = line;
                                    read_output_data(line, e);
                                }
                                data_read = true;

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        retry_count++;
                        if (retry_count < max_retry_count)
                        {
                            Thread.Sleep(retry_read_delay_ms);
                        }
                        else
                        {
                            //The OnChanged() is called twice when a file is updated
                            //The first call sometimes fails with "other process has the file open for writing" message
                            log_message($"File read error: {ex.Message} on file {e.FullPath}");
                        }
                    }

                }
            }
            else
            {
                //log_message($"Ignored: {e.FullPath}");
            }
#endif  //false

        }


        //
        //-----------------      OnCreated     ---------------------
        //
        /// <summary>
        /// Called by OS when a file is created in the monitored folder
        /// returns TRUE if ok, else FALSE
        /// </summary>
        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            log_message(value);
        }



        //
        //-----------------      OnDeleted     ---------------------
        //
        /// <summary>
        /// Called by OS when a file is deleted from the monitored folder
        /// returns TRUE if ok, else FALSE
        /// </summary>
        private static void OnDeleted(object sender, FileSystemEventArgs e) =>
            log_message($"Deleted: {e.FullPath}");



        //
        //-----------------      OnRenamed     ---------------------
        //
        /// <summary>
        /// Called by OS when a file is renamed in the monitored folder
        /// returns TRUE if ok, else FALSE
        /// </summary>
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            log_message($"Renamed:");
            log_message($"    Old: {e.OldFullPath}");
            log_message($"    New: {e.FullPath}");
        }



        //
        //-----------------      OnError     ---------------------
        //
        /// <summary>
        /// Called by OS when an error occurs
        /// returns TRUE if ok, else FALSE
        /// </summary>
        private static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());



        //
        //-----------------      PrintException     ---------------------
        //
        /// <summary>
        /// Called by OS when an error occurs and prints exception details on the console
        /// returns TRUE if ok, else FALSE
        /// </summary>
        private static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                file_system_watcher_exceptions++;
                log_message($"FileSystemWatcher exception: {file_system_watcher_exceptions} error: {ex.Message}");
            }
        }
    }
}