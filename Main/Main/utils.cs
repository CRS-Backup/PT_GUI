using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using CRSControlsLib;
using Newtonsoft.Json;

namespace PtGui
{

    public partial class GuiCore
    {
        public static List<Form> lstForms = new List<Form>();

        //Debug flags
        public static bool dfSuppressWarnings = false;


        //
        //-----------------      update_form_controls_values     ---------------------
        //
        /// <summary>
        /// updates the controls' values on the form(s) with input data
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool update_form_controls_values()
        {
            try
            {
                //The controls have already been added to each entry
                //see setup_database_links()


                //Check the inputs

                var ipc = GuiCore.channelData.inputData.channelList;
                for (int ipChan = 0; ipChan < ipc.Count; ipChan++)
                {

                    //Each database channel value can be linked to several controls
                    foreach (Control c in ipc[ipChan].controls)
                    {
                        //Set the e.g. Label text to the current database value
                        update_control_value(c, ipc[ipChan].value);
                    }
                }


                //Check the internals

                var tpc = GuiCore.channelData.internalData.channelList;
                for (int tpChan = 0; tpChan < tpc.Count; tpChan++)
                {

                    //Each database channel value can be linked to several controls
                    foreach (Control c in tpc[tpChan].controls)
                    {
                        //Set the e.g. Label text to the current database value
                        update_control_value(c, tpc[tpChan].value);
                    }
                }


                //Check the outputs

                var opc = GuiCore.channelData.outputData.channelList;
                for (int opChan = 0; opChan < opc.Count; opChan++)
                {

                    //Each database channel value can be linked to several controls
                    foreach (Control c in opc[opChan].controls)
                    {
                        //Set the e.g. Label text to the current database value
                        update_control_value(c, opc[opChan].value);
                    }
                }


            }
            catch (Exception ex)
            {
                log_message($"update_form_controls_values exception: {ex.Message}");
            }
            GuiCore.channelData.inputData.new_data = false;
            return true;
        }



        //
        //-----------------      update_control_value     ---------------------
        //
        /// <summary>
        /// updates the passed control's value on the form(s) with passed value data
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool update_control_value(Control c, string value)
        {
            try
            {

                if (c is CrsLabel)
                {
                    CrsLabel crsLabel = new CrsLabel();
                    crsLabel = (CrsLabel)c;
                    crsLabel.CrsChanValue = value;
                    //crsLabel.CausesValidation = !crsLabel.CausesValidation;
                    //crsLabel.Text = crsLabel.Text + ".";
                    crsLabel.Text = crsLabel.CrsChanValue;
                    //crsLabel.Refresh();
                }
                else if (c is CrsButton)
                {
                    //Not handled - Button is an output
#if false
                    CrsButton crsControl = new CrsButton();
                    crsControl = (CrsButton)ipc[ipChan].control;
                    crsControl = ipc[ipChan].value.ToString();
#endif //false
                }

            }
            catch (Exception ex)
            {
                log_message($"update_control_value exception: {ex.Message}");
            }
            return true;
        }



        //
        //-----------------      setup_database_links     ---------------------
        //
        /// <summary>
        /// Links the CRS-type controls on the form to the database
        /// This is called recursively to drill down into controls within this object (e.g. a panel may contain controls)
        /// returns TRUE if ok, else FALSE if a channel could not be linked to the database or an exceptions occurred
        /// </summary>
        public static (int, int, int) setup_database_links(Control parent, int links_made_count, int link_failure_count, int link_undefined_count)
        {
            try
            {
                int links_made_this_form_count = 0;
                //Don't link the controls on this form if we've already see it
                if (formList.forms_linked.Contains(parent))
                {
                    return (links_made_count, link_failure_count, link_undefined_count);
                }
                formList.forms_linked.Add(parent);

                string form_name = parent.Name;
                //Drill-down through all controls on this form, linking the CRS channels to the database channels
                (links_made_this_form_count, link_failure_count, link_undefined_count) = add_database_links(form_name, parent, links_made_this_form_count, link_failure_count, link_undefined_count);
                links_made_count += links_made_this_form_count;
                GuiCore.log_message($"Linked {links_made_this_form_count} CRS Controls from form {form_name}");

            }
            catch (Exception ex)
            {
                GuiCore.log_message($"setup_database_links exception linking channels to database: {ex.Message}");
            }
            return (links_made_count, link_failure_count, link_undefined_count);
        }


        //
        //-----------------      add_database_links     ---------------------
        //
        /// <summary>
        /// Links the CRS-type controls on the form to the database
        /// This is called recursively to drill down into controls within this object (e.g. a panel may contain controls)
        /// returns the link_failure_count. 0 if all database links made. >0 if one of more links weren't made or there was an exception
        /// </summary>
        public static (int, int, int) add_database_links(string form_name, Control parent, int links_made_count, int link_failure_count, int link_undefined_count)
        {
            try
            {
                foreach (Control c in parent.Controls)
                {
                    //Look for special CRS controls with extra fields
                    if (c.CompanyName == "CRSControlsLib")
                    {
                        int control_channel_num = 0;
                        string control_name = c.Name;
                        if (c is CrsLabel)
                        {
                            CrsLabel crsControl = new CrsLabel();
                            crsControl = (CrsLabel)c;
                            control_channel_num = extract_chan_num(crsControl.CrsChanNumOrAlias);
                        }
                        else if (c is CrsButton)
                        {
                            CrsButton crsControl = new CrsButton();
                            crsControl = (CrsButton)c;
                            control_channel_num = extract_chan_num(crsControl.CrsChanNumOrAlias);
                        }

                        //Now we have the control on the form, link it to an input channel
                        bool controlFound = false;
                        if (control_channel_num > 0)
                        {
                            //Check the inputs
                            var ipc = GuiCore.channelData.inputData.channelList;
                            for (int ipChan = 0; ipChan < ipc.Count; ipChan++)
                            {
                                //Find the input channel that matches
                                if (ipc[ipChan].channel_number == control_channel_num)
                                {
                                    //Add the control to this list of controls that access this channel
                                    ipc[ipChan].controls.Add(c);
                                    links_made_count++;
                                    controlFound = true;
                                    break;
                                }
                            }


                            //Check the internals
                            if (!controlFound)
                            {
                                var tpc = GuiCore.channelData.internalData.channelList;
                                for (int tpChan = 0; tpChan < tpc.Count; tpChan++)
                                {
                                    //Find the input channel that matches
                                    if (tpc[tpChan].channel_number == control_channel_num)
                                    {
                                        //Add the control to this list of controls that access this channel
                                        tpc[tpChan].controls.Add(c);
                                        links_made_count++;
                                        controlFound = true;
                                        break;
                                    }
                                }
                            }


                            //Check the outputs
                            if (!controlFound)
                            {
                                var opc = GuiCore.channelData.outputData.channelList;
                                for (int opChan = 0; opChan < opc.Count; opChan++)
                                {
                                    //Find the input channel that matches
                                    if (opc[opChan].channel_number == control_channel_num)
                                    {
                                        //Add the control to this list of controls that access this channel
                                        opc[opChan].controls.Add(c);
                                        links_made_count++;
                                        controlFound = true;
                                        break;
                                    }
                                }
                            }

                        }

                        //Flag a warning if we haven't seen it
                        if (!controlFound)
                        {
                            if (control_channel_num > 0)
                            {
                                GuiCore.log_message($"ERROR - on form: {form_name} failed to find chan: {control_channel_num} defined on control {control_name} in input or output database files");
                                link_failure_count++;
                            }
                            else
                            {
                                GuiCore.log_message($"WARNING - on form: {form_name} no database channel link defined on control {control_name}");
                                link_undefined_count++;
                            }
                        }
                    }
                    else
                    {
                        //Recursively call this function to drill down to controls within this object
                        (links_made_count, link_failure_count, link_undefined_count) = add_database_links(form_name, c, links_made_count, link_failure_count, link_undefined_count);
                    }
                }
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"on form: {form_name}  add_database_links exception linking channels to database: {ex.Message}");
                link_failure_count++;
            }
            return (links_made_count, link_failure_count, link_undefined_count);
        }

#if false
        //
        //-----------------      setup_control_links     ---------------------
        //
        /// <summary>
        /// Links the CRS-type controls on the form to the database
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool setup_control_links(Control.ControlCollection controls)
        {
            try
            {
                for (int iControl = 0; iControl < controls.Count; iControl++)
                {
                    if (controls[iControl].CompanyName == "CRSControlsLib")
                    {
                        int control_channel_num = 0;
                        string control_name = controls[iControl].Name;
                        if (controls[iControl] is CrsLabel)
                        {
                            CrsLabel crsControl = new CrsLabel();
                            crsControl = (CrsLabel)controls[iControl];
                            control_channel_num = crsControl.CrsChanNumber;
                        }
                        else if (controls[iControl] is CrsButton)
                        {
                            CrsButton crsControl = new CrsButton();
                            crsControl = (CrsButton)controls[iControl];
                            control_channel_num = crsControl.CrsChanNumber;
                        }

                        //Now we have the control on the form, link it to an input channel
                        if (control_channel_num > 0)
                        {
                            bool controlFound = false;
                            var ipc = GuiCore.channelData.inputData.channelList;
                            for (int ipChan = 0; ipChan < ipc.Count; ipChan++)
                            {
                                //Find the input channel that matches
                                if (ipc[ipChan].channel_number == control_channel_num)
                                {
                                    //Save the control
                                    ipc[ipChan].control = controls[iControl];
                                    controlFound = true;
                                }
                            }

                            //Flag a warning if we haven't seen it
                            if (!controlFound)
                            {
                                GuiCore.log_message($"failed to find chan: {control_channel_num} defined on control {control_name} in input or output file");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"setup_control_links exception linking channels to controls: {ex.Message}");
            }
            return true;
        }
#endif //false


        //
        //-----------------      toggle_channel     ---------------------
        //
        /// <summary>
        /// toggles the passed Dig channel value
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool toggle_channel(int channel_number)
        {
            try
            {

                //NOT COMPLETE
            }
            catch (Exception ex)
            {
                log_message($"toggle_channel exception: {ex.Message}");
            }
            return true;
        }


        //
        //-----------------      getCrsChanValue     ---------------------
        //
        /// <summary>
        /// returns the Crs Channel Valuetoggles the passed Dig channel value
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static string getCrsChanValue(object sender)
        {
            string crsChanValue = "";
            try
            {
                if (sender is CrsButton)
                {
                    CRSControlsLib.CrsButton thisButton = new CRSControlsLib.CrsButton();
                    thisButton = (CRSControlsLib.CrsButton)sender;
                    crsChanValue = thisButton.CrsChanValue;
                }
                else if (sender is CrsLabel)
                {
                    CRSControlsLib.CrsLabel thisLabel = new CRSControlsLib.CrsLabel();
                    thisLabel = (CRSControlsLib.CrsLabel)sender;
                    crsChanValue = thisLabel.CrsChanValue;
                }

            }
            catch (Exception ex)
            {
                log_message($"getCrsChanValue exception: {ex.Message}");
            }
            return crsChanValue;
        }



        //
        //-----------------      get_chan_val_string     ---------------------
        //
        /// <summary>
        /// gets the channel value of the passed object (e.g. button) or the passed channel name
        /// returns the channel value as a string or "0"
        /// </summary>
        public static string get_chan_val_string(object sender)
        {
            string channel_value = "0";
            try
            {
                int channel_num = get_chan_num_from_object(sender);
                channel_value = get_chan_val_from_chan_num(channel_num);
            }
            catch (Exception ex)
            {
                log_message($"get_chan_val_string exception: {ex.Message}");
            }
            return channel_value;
        }



        //
        //-----------------      get_chan_val_double     ---------------------
        //
        /// <summary>
        /// gets the channel value of the passed object (e.g. button) or the passed channel name
        /// returns the channel value as a double or 0
        /// </summary>
        public static double get_chan_val_double(object sender)
        {
            double channel_value = 0;
            try
            {
                int channel_num = get_chan_num_from_object(sender);
                string str_channel_value = get_chan_val_from_chan_num(channel_num);
                Double.TryParse(str_channel_value, out channel_value);
            }
            catch (Exception ex)
            {
                log_message($"get_chan_val_double exception: {ex.Message}");
            }
            return channel_value;
        }



        //
        //-----------------      get_chan_val_integer     ---------------------
        //
        /// <summary>
        /// gets the channel value of the passed object (e.g. button) or the passed channel name
        /// returns the channel value as a integer or 0
        /// </summary>
        public static int get_chan_val_integer(object sender)
        {
            int channel_value = 0;
            try
            {
                int channel_num = get_chan_num_from_object(sender);
                string str_channel_value = get_chan_val_from_chan_num(channel_num);
                Int32.TryParse(str_channel_value, out channel_value);
            }
            catch (Exception ex)
            {
                log_message($"get_chan_val_integer exception: {ex.Message}");
            }
            return channel_value;
        }


        //
        //-----------------      get_chan_num_from_object     ---------------------
        //
        /// <summary>
        /// gets the channel number associated with the passed object (e.g. button) or the passed channel number/alias
        /// returns the channel number or 0
        /// </summary>
        public static int get_chan_num_from_object(object sender)
        {
            int control_channel_num = 0;

            try
            {
                //Get the channel number from the Control object
                if (sender is CrsButton)
                {
                    CrsButton crsControl = new CrsButton();
                    crsControl = (CrsButton)sender;
                    control_channel_num = extract_chan_num(crsControl.CrsChanNumOrAlias);
                }
                else if (sender is CrsLabel)
                {
                    CrsLabel crsControl = new CrsLabel();
                    crsControl = (CrsLabel)sender;
                    control_channel_num = extract_chan_num(crsControl.CrsChanNumOrAlias);
                }
                else if (sender is String)
                {
                    //The user may have sent a channel number, rather than an object (like a button)
                    if (int.TryParse((String)sender, out int chan_num))
                    {
                        control_channel_num = chan_num;
                    }
                    else
                    {
                        //The user may have sent an alias
                        control_channel_num = get_chan_num_from_alias((String)sender);
                    }
                }

            }
            catch (Exception ex)
            {
                log_message($"get_chan_num_from_object exception: {ex.Message}");
            }
            return control_channel_num;
        }


        //
        //-----------------      extract_chan_num     ---------------------
        //
        /// <summary>
        /// The Button/Label etc database link can be a channel number or an alias
        /// e.g. "2002" or "chan2002" 
        /// This function extracts the channel number
        /// returns the channel value or "0"
        /// </summary>
        public static int extract_chan_num(string chanNumOrAlias)
        {
            int channel_num = 0;
            try
            {

                //First try to read it as a number
                if (!int.TryParse(chanNumOrAlias, out channel_num))
                {
                    //It failed as a number - try to look up the number from the Alias
                    channel_num = get_chan_num_from_alias(chanNumOrAlias);
                }


                //Flag a warning if we haven't seen it
                if (channel_num == 0)
                {
                    GuiCore.log_message($"ERROR - extract_chan_num() failed to extract chan num from: {chanNumOrAlias}");
                }
            }

            catch (Exception ex)
            {
                log_message($"extract_chan_num exception: {ex.Message}");
            }
            return channel_num;
        }



        //
        //-----------------      get_chan_val_from_chan_num     ---------------------
        //
        /// <summary>
        /// gets the channel value of the passed channel nuumber
        /// returns the channel value or "0"
        /// </summary>
        public static string get_chan_val_from_chan_num(int channel_num)
        {
            string channel_value = "0";
            try
            {

                //We have a channel number - now get its value
                bool controlFound = false;
                if (channel_num > 0)
                {
                    //Check the inputs
                    var ipc = GuiCore.channelData.inputData.channelList;
                    for (int ipChan = 0; ipChan < ipc.Count; ipChan++)
                    {
                        //Find the input channel that matches
                        if (ipc[ipChan].channel_number == channel_num)
                        {
                            channel_value = ipc[ipChan].value;
                            controlFound = true;
                            break;
                        }
                    }

                    //Check the internals
                    var tpc = GuiCore.channelData.internalData.channelList;
                    for (int tpChan = 0; tpChan < tpc.Count; tpChan++)
                    {
                        //Find the internal channel that matches
                        if (tpc[tpChan].channel_number == channel_num)
                        {
                            channel_value = tpc[tpChan].value;
                            controlFound = true;
                            break;
                        }
                    }


                    //Check the outputs
                    if (!controlFound)
                    {
                        var opc = GuiCore.channelData.outputData.channelList;
                        for (int opChan = 0; opChan < opc.Count; opChan++)
                        {
                            //Find the input channel that matches
                            if (opc[opChan].channel_number == channel_num)
                            {
                                channel_value = opc[opChan].value;
                                controlFound = true;
                                break;
                            }
                        }
                    }

                }

                //Flag a warning if we haven't seen it
                if (!controlFound)
                {
                    if (channel_num > 0)
                    {
                        GuiCore.log_message($"ERROR - get_chan_val_from_chan_num() failed to find chan: {channel_num} in input or output database files");
                    }
                    else
                    {
                        GuiCore.log_message($"WARNING - get_chan_val_from_chan_num() no channel number defined");
                    }
                }



            }
            catch (Exception ex)
            {
                log_message($"get_chan_val_from_chan_num exception: {ex.Message}");
            }
            return channel_value;
        }


        //
        //-----------------      get_chan_num_from_alias     ---------------------
        //
        /// <summary>
        /// gets the channel number from the channel alias
        /// returns the channel number or 0
        /// </summary>
        public static int get_chan_num_from_alias(string channel_alias)
        {
            int channel_number = 0;
            try
            {

                //We have a channel number - now get its value
                bool aliasFound = false;
                //Check the inputs
                var ipc = GuiCore.channelData.inputData.channelList;
                for (int ipChan = 0; ipChan < ipc.Count; ipChan++)
                {
                    //Find the input channel that matches
                    if (ipc[ipChan].alias == channel_alias)
                    {
                        channel_number = ipc[ipChan].channel_number;
                        aliasFound = true;
                        break;
                    }
                }


                //Check the internals
                if (!aliasFound)
                {
                    var tpc = GuiCore.channelData.internalData.channelList;
                    for (int tpChan = 0; tpChan < tpc.Count; tpChan++)
                    {
                        //Find the internal channel that matches
                        if (tpc[tpChan].alias == channel_alias)
                        {
                            channel_number = tpc[tpChan].channel_number;
                            aliasFound = true;
                            break;
                        }
                    }
                }

                //Check the outputs
                if (!aliasFound)
                {
                    var opc = GuiCore.channelData.outputData.channelList;
                    for (int opChan = 0; opChan < opc.Count; opChan++)
                    {
                        //Find the input channel that matches
                        if (opc[opChan].alias == channel_alias)
                        {
                            channel_number = opc[opChan].channel_number;
                            aliasFound = true;
                            break;
                        }
                    }
                }

                //Flag a warning if we haven't seen it
                if (!aliasFound)
                {
                    GuiCore.log_message($"WARNING - get_chan_num_from_alias() no channel number found for alias {channel_alias}");
                }

            }
            catch (Exception ex)
            {
                log_message($"get_chan_num_from_alias exception: {ex.Message}");
            }
            return channel_number;
        }



        //
        //-----------------      set_channel_value (int)    ---------------------
        //
        /// <summary>
        /// sets the output channel to the passed int value
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool set_channel_value(object sender, int new_value)
        {
            try
            {
                string chan_val = new_value.ToString();
                set_channel_value(sender, chan_val);
            }
            catch (Exception ex)
            {
                log_message($"set_channel_value (int) exception: {ex.Message}");
            }
            return true;
        }



        //
        //-----------------      set_channel_value (double)    ---------------------
        //
        /// <summary>
        /// sets the output channel to the passed int value
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool set_channel_value(object sender, double new_value)
        {
            try
            {
                string chan_val = new_value.ToString();
                set_channel_value(sender, chan_val);
            }
            catch (Exception ex)
            {
                log_message($"set_channel_value (double) exception: {ex.Message}");
            }
            return true;
        }



        //
        //-----------------      set_channel_value     ---------------------
        //
        /// <summary>
        /// sets the output channel to the passed value
        /// returns TRUE if ok, else FALSE
        /// </summary>
        public static bool set_channel_value(object sender, string new_value)
        {
            try
            {
                int channel_num = get_chan_num_from_object(sender);

                bool controlFound = false;
                if (channel_num > 0)
                {
                    //First try the Outputs
                    var opc = GuiCore.channelData.outputData.channelList;
                    for (int opChan = 0; opChan < opc.Count; opChan++)
                    {
                        //Find the output channel that matches
                        if (opc[opChan].channel_number == channel_num)
                        {
                            //Write the new value and flag data has changed
                            opc[opChan].value = new_value;
                            GuiCore.channelData.outputData.new_data = true;
                            controlFound = true;
                            break;
                        }
                    }


                    var tpc = GuiCore.channelData.internalData.channelList;
                    for (int tpChan = 0; tpChan < tpc.Count; tpChan++)
                    {
                        //Find the internal channel that matches
                        if (tpc[tpChan].channel_number == channel_num)
                        {
                            //Write the new value and flag data has changed
                            tpc[tpChan].value = new_value;
                            GuiCore.channelData.internalData.new_data = true;
                            controlFound = true;
                            break;
                        }
                    }


                    if (!controlFound)
                    {
                        //Now try the Inputs
                        var ipc = GuiCore.channelData.inputData.channelList;
                        for (int ipChan = 0; ipChan < ipc.Count; ipChan++)
                        {
                            //Find the output channel that matches
                            if (ipc[ipChan].channel_number == channel_num)
                            {
                                //Write the new value and flag data has changed
                                ipc[ipChan].value = new_value;
                                //TODO - is this line needed?
                                GuiCore.channelData.inputData.new_data = true;
                                controlFound = true;
                                break;
                            }
                        }
                    }


                    if (!controlFound)
                    {
                        log_message($"Couldn't set channel value for chan: {channel_num}. Chan not found");
                    }
                }
                else
                {
                    log_message($"Couldn't set channel value for: {channel_num}. Channel not defined");
                }

            }
            catch (Exception ex)
            {
                log_message($"set_channel_value exception: {ex.Message}");
            }
            return true;
        }



        //
        //-----------------      show_form     ---------------------
        //              (DEFAULT don't hide caller + add to backlist)
        //
        /// <summary>
        /// Shows a form that we have already found during the startup process
        /// calling_form can the the form to hide or can be null if no calling form is to be hidden
        /// This default variant adds it to the backlist
        /// </summary>
        public static void show_form(string form_name)
        {
            try
            {
                show_form(form_name, null, Constants.ADD_TO_BACKLIST);
            }
            catch (Exception e)
            {
                GuiCore.log_message($"show_form Exception: " + e.Message);
                return;
            }

        }



        //
        //-----------------      show_form    ---------------------
        //              (don't hide caller + optinal add to backlist)
        //
        /// <summary>
        /// Shows a form that we have already found during the startup process
        /// calling_form can the the form to hide or can be null if no calling form is to be hidden
        /// This default variant adds it to the backlist
        /// </summary>
        public static void show_form(string form_name, bool add_to_backlist)
        {
            try
            {
                show_form(form_name, null, Constants.ADD_TO_BACKLIST);
            }
            catch (Exception e)
            {
                GuiCore.log_message($"show_form Exception: " + e.Message);
                return;
            }

        }



        //
        //-----------------      show_form    ---------------------
        //              (hide caller + add to backlist)
        //
        /// <summary>
        /// Shows a form that we have already found during the startup process
        /// calling_form can the the form to hide or can be null if no calling form is to be hidden
        /// This default variant adds it to the backlist
        /// </summary>
        public static void show_form(string form_name, Control calling_form)
        {
            try
            {
                show_form(form_name, calling_form, Constants.ADD_TO_BACKLIST);
            }
            catch (Exception e)
            {
                GuiCore.log_message($"show_form Exception: " + e.Message);
                return;
            }

        }



        //
        //-----------------      show_form     ---------------------
        //                (full contrtol version)
        //
        /// <summary>
        /// Shows a form that we have already found during the startup process
        /// calling_form can the the form to hide or can be null if no calling form is to be hidden
        /// </summary>
        public static void show_form(string form_name, Control calling_form, bool add_to_backlist)
        {
            try
            {
                bool found = false;

                foreach (Form frm in lstForms)
                {
                    if (frm.Name == form_name)
                    {

                        found = true;
                        frm.Show();
                        frm.BringToFront();

                        if (add_to_backlist) formList.backListx.Insert(0, "frmDiscrepancies");

                        //Hide the form that is showing the new form
                        if (calling_form != null) ((Form)calling_form).Hide();

                        break;
                    }
                }
                if (!found) GuiCore.log_message($"show_form couldn't find form {form_name}");

            }
            catch (Exception e)
            {
                GuiCore.log_message($"show_form Exception: " + e.Message);
                return;
            }

        }



        //
        //-----------------      get_and_link_all_forms     ---------------------
        //
        /// <summary>
        /// uses reflection to get, link CRS objects to the database and load all the forms in the project
        /// </summary>
        public static bool get_and_link_all_forms()
        {
            try
            {
                int links_made_count = 0;
                int link_failure_count = 0;
                int link_undefined_count = 0;       //How many CRS models do not have a channel number defined

                //Use reflection to go through the Assembly looking for forms that have been defined
                //(but are not loaded at this stage of the program)
                //Add each form to a List
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
                    }
                }



                //We have all the forms loaded. Go through each and create a link from the CRS
                //Controls (Buttons, Labels etc) to the database
                foreach (Form frm in GuiCore.lstForms)
                {
                    (links_made_count, link_failure_count, link_undefined_count) = GuiCore.setup_database_links(frm, links_made_count, link_failure_count, link_undefined_count);
                }


                //Let the user know if anything was amiss
                if (link_failure_count > 0)
                {
                    //Let the user know the bad news
                    string report_file = Path.Combine(GuiCore.GUI_report_folder, GuiCore.file_core_report + GuiCore.report_file_extension);

                    string caption = ">>> ERROR - Database Links Missing <<<";
                    string message = $"{link_failure_count} channels on forms could not be found in the database";
                    message += Environment.NewLine + $"See file: {report_file} for more details";
                    message += Environment.NewLine + Environment.NewLine + $"This program will terminate";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                    Application.Exit();
                }

                else if (link_undefined_count > 0)
                {
                    if (!GuiCore.dfSuppressWarnings)
                    {
                        //Let the user know there are some models without a channel number defined
                        string report_file = Path.Combine(GuiCore.GUI_report_folder, GuiCore.file_core_report + GuiCore.report_file_extension);

                        string caption = "WARNING - Models with undefined links";
                        string message = $"{link_undefined_count} models on the forms do not have channels defined";
                        message += Environment.NewLine + $"See file: {report_file} for more details";
                        message += Environment.NewLine + Environment.NewLine + $"This program will continue";

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                }



                //Trigger writes to the data monitor files to fill them in
                //This gets the channels/values read from the database and writes them
                //to the Internal and Output files
                GuiCore.channelData.internalData.new_data = true;
                GuiCore.channelData.outputData.new_data = true;

            }
            catch (Exception e)
            {
                GuiCore.log_message($"get_and_link_all_forms Exception: " + e.Message);
                return false;
            }
            return true;

        }



        //
        //-----------------      get_form_by_name     ---------------------
        //
        /// <summary>
        /// Get aa form reference (object) from the passed form name
        /// returns the Form or null if the name is not found
        /// </summary>
        public static Form get_form_by_name(string form_name)
        {
            Form found_form = null;
            try
            {
                bool found = false;

                foreach (Form frm in lstForms)
                {
                    if (frm.Name == form_name)
                    {
                        found_form = frm;
                        break;
                    }
                }
                if (!found) GuiCore.log_message($"get_form_by_name couldn't find form {form_name}");

            }
            catch (Exception e)
            {
                GuiCore.log_message($"get_form_by_name Exception: " + e.Message);
                return null;
            }
            return found_form;
        }



        //
        //-----------------      toggle_channel  ---------------------
        //
        /// <summary>
        /// Toggles the value of the passed channel (alias) - does not change the background
        /// returns the Form or null if the name is not found
        /// </summary>
        public static void toggle_channel(string alias)
        {
            try
            {
                string chan_val = GuiCore.get_chan_val_string(alias);
                chan_val = (chan_val == Constants.DIGITAL_OFF) ? Constants.DIGITAL_ON : Constants.DIGITAL_OFF;
                GuiCore.set_channel_value(alias, chan_val);
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"toggle_channel Exception: " + ex.Message);
                return;
            }

        }



        //
        //-----------------      toggle_channel + background bitmap ---------------------
        //
        /// <summary>
        /// Toggles the value of the passed channel (alias) and sets the background bitmap
        /// returns the Form or null if the name is not found
        /// </summary>
        public static void toggle_channel(object caller, string alias, string on_bitmap_name, string off_bitmap_name)
        {
            try
            {
                toggle_channel(caller, null, alias, on_bitmap_name, off_bitmap_name, null, null);
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"toggle_channel+background Exception: " + ex.Message);
                return;
            }
        }


        //
        //-----------------      toggle_channel + background bitmap + label text ---------------------
        //
        /// <summary>
        /// Toggles the value of the passed channel (alias)
        /// sets the background bitmap and sets the associated label text
        /// returns the Form or null if the name is not found
        /// </summary>
        public static void toggle_channel(object caller, object target_label, string alias, string on_bitmap_name, string off_bitmap_name, string on_label_text, string off_label_text)
        {
            try
            {
                Bitmap background = null;
                string label_text = "";

                //Get the current channel value
                string chan_val = GuiCore.get_chan_val_string(alias);

                //Toggle the value and get the associated background bitmap
                if (chan_val == Constants.DIGITAL_OFF)
                {
                    chan_val = Constants.DIGITAL_ON;
                    label_text = on_label_text;
                    try
                    {
                        background = new Bitmap(on_bitmap_name);
                    }
                    catch (Exception ex)
                    {
                        GuiCore.log_message($"toggle_channel {on_bitmap_name} 'ON' bitmap not found");
                    }
                }
                else
                {
                    chan_val = Constants.DIGITAL_OFF;
                    label_text = off_label_text;
                    try
                    {
                        background = new Bitmap(off_bitmap_name);
                    }
                    catch (Exception ex)
                    {
                        GuiCore.log_message($"toggle_channel {off_bitmap_name} 'OFF' bitmap not found");
                    }
                }

                //Set the toggled channel value
                GuiCore.set_channel_value(alias, chan_val);


                //Set the background bitmap based on the calling object type
                switch (caller)
                {
                    case Button button:
                        button.BackgroundImage = background;
                        break;

                    case Label label:
                        label.BackgroundImage = background;
                        break;

                    case Panel panel:
                        panel.BackgroundImage = background;
                        break;

                    default:
                        GuiCore.log_message($"toggle_channel {caller.GetType()} object not supported");
                        break;

                }


                //If a label object has been passed, set the text for that label
                if(target_label != null)
                {
                    switch (target_label)
                    {
                        case Label label:
                            label.Text = label_text;
                            break;

                        default:
                            GuiCore.log_message($"toggle_channel target_label {caller.GetType()} object not supported");
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                GuiCore.log_message($"toggle_channel+background Exception: " + ex.Message);
                return;
            }

        }
    }
}