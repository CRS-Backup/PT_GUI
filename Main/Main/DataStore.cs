using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace PtGui
{

    public class formList
    {
        //List of forms that have been linked to the database
        public static List<Control> forms_linked = new List<Control>();

        public static List<Form> backList = new List<Form>();  //  Used for 'Back Page' button
        public static List<String> backListx = new List<String>();  //  Used for 'Back Page' button

    }


    public class Channel
    {
        public int channel_number = 0;
        public string alias = "";
        public string value = "";
        [JsonIgnore]
        public List<Control> controls = new List<Control>();         //This is not read in but used to store the control (button etc)this channel links to
    }

    public class ChannelEntries
    {
        [JsonIgnore]
        public bool data_changed = false;
        public string timestamp;
        public string comment = "";
        [JsonIgnore]
        public bool new_data = false;
        public List<Channel> channelList = new List<Channel>();
    }

    public class ChannelData
    {
        public ChannelEntries inputData = new ChannelEntries();
        public ChannelEntries internalData = new ChannelEntries();
        public ChannelEntries outputData = new ChannelEntries();
    }

    //Holds the channel defintions (database)
    public class ChannelDefinitions
    {
        public string timestamp;
        public string comment = "";
        public ChannelEntries inputChannels = new ChannelEntries();
        public ChannelEntries internalChannels = new ChannelEntries();
        public ChannelEntries outputChannels = new ChannelEntries();
    }

    public static class PageExtensions
    {
        public static IEnumerable<Control> All(this ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                foreach (Control grandChild in control.Controls.All())
                    yield return grandChild;

                yield return control;
            }
        }
    }

}
