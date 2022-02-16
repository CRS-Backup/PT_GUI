using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRSControlsLib
{
    public partial class CrsLabel: Label
    {

        private string strNumOrAlias;
        public string CrsChanNumOrAlias
        {
            get
            {
                return strNumOrAlias;
            }

            set
            {
                strNumOrAlias = value;
            }
        }
        //Add a store for the channel value from the database
        private string strValue;
        public string CrsChanValue
        {
            get
            {
                return strValue;
            }

            set
            {
                strValue = value;
            }
        }



        public CrsLabel()
        {
            InitializeComponent();
        }
    }
}
