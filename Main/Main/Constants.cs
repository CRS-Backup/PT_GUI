using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtGui
{
    class Constants
    {
        public const int tabPageMain = 0;
        public const int tabPagePropulsion = 1;

        public static System.Drawing.Color BACKGROUND_OFF = Color.Red;
        public static System.Drawing.Color BACKGROUND_ON = Color.Blue;

        public const string DIGITAL_OFF = "0";
        public const string DIGITAL_ON = "1";

        public const string ROOT_FOLDER = "c:/temp/PT_GUI_data/";
        //data types
        public const int DATA_TYPE_INPUTS = 0;
        public const int DATA_TYPE_INTERNALS = 1;
        public const int DATA_TYPE_OUTPUTS = 2;

        public const bool DO_NOT_ADD_TO_BACKLIST = false;
        public const bool ADD_TO_BACKLIST = true;


        //Bitmaps
        public const string BMP_FOLDER = ROOT_FOLDER + "resources/Bitmaps/";
        
		//GKD Test
		public const string BMP_BUTTON_RED_DOWN = BMP_FOLDER + "rect_button_red_pressed.bmp";
        public const string BMP_BUTTON_RED_UP = BMP_FOLDER + "rect_button_red.bmp";
        public const string BMP_BUTTON_GREEN_DOWN = BMP_FOLDER + "green_button_l_pressed.bmp";
        public const string BMP_BUTTON_GREEN_UP = BMP_FOLDER + "green_button_l.bmp";


        //Rectangle Buttons (650 x 500 pixels)
        public const string BMP_RECT_BUTTON_RED_DOWN = BMP_FOLDER + "rect_button_red_pressed.bmp";
        public const string BMP_RECT_BUTTON_RED_UP = BMP_FOLDER + "rect_button_red.bmp";

        public const string BMP_RECT_BUTTON_GREEN_DOWN = BMP_FOLDER + "rect_button_green_pressed.bmp";
        public const string BMP_RECT_BUTTON_GREEN_UP = BMP_FOLDER + "rect_button_green.bmp";

        public const string BMP_RECT_BUTTON_CYAN_DOWN = BMP_FOLDER + "rect_button_cyan_pressed.bmp";
        public const string BMP_RECT_BUTTON_CYAN_UP = BMP_FOLDER + "rect_button_cyan.bmp";

        public const string BMP_RECT_BUTTON_YELLOW_DOWN = BMP_FOLDER + "rect_button_yellow_pressed.bmp";
        public const string BMP_RECT_BUTTON_YELLOW_UP = BMP_FOLDER + "rect_button_yellow.bmp";

        public const string BMP_RECT_BUTTON_BLUE_DOWN = BMP_FOLDER + "rect_button_blue_pressed.bmp";
        public const string BMP_RECT_BUTTON_BLUE_UP = BMP_FOLDER + "rect_button_blue.bmp";

        public const string BMP_RECT_BUTTON_MAGENTA_DOWN = BMP_FOLDER + "rect_button_magenta_pressed.bmp";
        public const string BMP_RECT_BUTTON_MAGENTA_UP = BMP_FOLDER + "rect_button_magenta.bmp";

        public const string BMP_RECT_BUTTON_GREY_DOWN = BMP_FOLDER + "rect_button_grey_pressed.bmp";
        public const string BMP_RECT_BUTTON_GREY_UP = BMP_FOLDER + "rect_button_grey.bmp";


        //Long Buttons (2000 x 500 pixels)
        public const string BMP_LONG_BUTTON_GREEN_DOWN = BMP_FOLDER + "long_button_green_pressed.bmp";
        public const string BMP_LONG_BUTTON_GREEN_UP = BMP_FOLDER + "long_button_green.bmp";

        public const string BMP_LONG_BUTTON_RED_DOWN = BMP_FOLDER + "long_button_red_pressed.bmp";
        public const string BMP_LONG_BUTTON_RED_UP = BMP_FOLDER + "long_button_red.bmp";

        //Square Buttons (410 x 500 pixels)
        public const string BMP_SQUARE_BUTTON_RED_DOWN = BMP_FOLDER + "square_button_red_pressed.bmp";
        public const string BMP_SQUARE_BUTTON_RED_UP = BMP_FOLDER + "square_button_red.bmp";

        public const string BMP_SQUARE_BUTTON_GREEN_DOWN = BMP_FOLDER + "square_button_green_pressed.bmp";
        public const string BMP_SQUARE_BUTTON_GREEN_UP = BMP_FOLDER + "square_button_green.bmp";

        public const string BMP_SQUARE_BUTTON_CYAN_DOWN = BMP_FOLDER + "square_button_cyan_pressed.bmp";
        public const string BMP_SQUARE_BUTTON_CYAN_UP = BMP_FOLDER + "square_button_cyan.bmp";

        public const string BMP_SQUARE_BUTTON_YELLOW_DOWN = BMP_FOLDER + "square_button_yellow_pressed.bmp";
        public const string BMP_SQUARE_BUTTON_YELLOW_UP = BMP_FOLDER + "square_button_yellow.bmp";

        public const string BMP_SQUARE_BUTTON_BLUE_DOWN = BMP_FOLDER + "square_button_blue_pressed.bmp";
        public const string BMP_SQUARE_BUTTON_BLUE_UP = BMP_FOLDER + "square_button_blue.bmp";

        public const string BMP_SQUARE_BUTTON_GREY_DOWN = BMP_FOLDER + "square_button_grey_pressed.bmp";
        public const string BMP_SQUARE_BUTTON_GREY_UP = BMP_FOLDER + "square_button_grey.bmp";

        //Reset Buttons (650 x 500 pixels)
        public const string BMP_RESET_BUTTON_CYAN_DOWN = BMP_FOLDER + "reset_button_cyan_pressed.bmp";
        public const string BMP_RESET_BUTTON_CYAN_UP = BMP_FOLDER + "reset_button_cyan.bmp";

        public const string BMP_RESET_BUTTON_GREEN_DOWN = BMP_FOLDER + "reset_button_green_pressed.bmp";
        public const string BMP_RESET_BUTTON_GREEN_UP = BMP_FOLDER + "reset_button_green.bmp";

        public const string BMP_RESET_BUTTON_RED_DOWN = BMP_FOLDER + "reset_button_red_pressed.bmp";
        public const string BMP_RESET_BUTTON_RED_UP = BMP_FOLDER + "reset_button_red.bmp";

        //Hexagonal buttons
        public const string BMP_HEX_BUTTON_GREEN_DOWN = BMP_FOLDER + "hex_button_green_pressed.bmp";
        public const string BMP_HEX_BUTTON_GREEN_UP = BMP_FOLDER + "hex_button_green.bmp";

        public const string BMP_HEX_BUTTON_RED_DOWN = BMP_FOLDER + "hex_button_red_pressed.bmp";
        public const string BMP_HEX_BUTTON_RED_UP = BMP_FOLDER + "hex_button_red.bmp";


        // Run / Slow pointer
        public const string BMP_RUN = BMP_FOLDER + "run.bmp";
        public const string BMP_SLOW = BMP_FOLDER + "slow.bmp";

        //Valve1
        public const string BMP_VALVE1_OPENED = BMP_FOLDER + "valve_open.bmp";
        public const string BMP_VALVE1_CLOSED = BMP_FOLDER + "valve_closed.bmp";

        //Valve2
        public const string BMP_VALVE2_OPENED = BMP_FOLDER + "valve2_open.bmp";
        public const string BMP_VALVE2_CLOSED = BMP_FOLDER + "valve2_closed.bmp";

        //Valve3
        public const string BMP_VALVE3_OPENED = BMP_FOLDER + "valve3_open.bmp";
        public const string BMP_VALVE3_CLOSED = BMP_FOLDER + "valve3_closed.bmp";

        //Valve4
        public const string BMP_VALVE4_OPENED = BMP_FOLDER + "valve4_open.bmp";
        public const string BMP_VALVE4_CLOSED = BMP_FOLDER + "valve4_closed.bmp";

        public const string BMP_VALVE4_MON_OPENED = BMP_FOLDER + "valve4_open_mon.bmp";
        public const string BMP_VALVE4_MON_CLOSED = BMP_FOLDER + "valve4_closed_mon.bmp";



        //Valve5
        public const string BMP_VALVE5_OPENED = BMP_FOLDER + "valve5_open.bmp";
        public const string BMP_VALVE5_CLOSED = BMP_FOLDER + "valve5_closed.bmp";

        //Valve6
        public const string BMP_VALVE6_OPENED = BMP_FOLDER + "valve6_open.bmp";
        public const string BMP_VALVE6_CLOSED = BMP_FOLDER + "valve6_closed.bmp";

        //3 way valve right 
        public const string BMP_3WAYR1 = BMP_FOLDER + "3way_valve1.bmp";
        public const string BMP_3WAYR2 = BMP_FOLDER + "3way_valve2.bmp";
        public const string BMP_3WAYR3 = BMP_FOLDER + "3way_valve3.bmp";

        //3 way valve left
        public const string BMP_3WAYL1 = BMP_FOLDER + "3way_valve1_L.bmp";
        public const string BMP_3WAYL2 = BMP_FOLDER + "3way_valve2_L.bmp";
        public const string BMP_3WAYL3 = BMP_FOLDER + "3way_valve3_L.bmp";
        public const string BMP_3WAYL4 = BMP_FOLDER + "3way_valve4_L.bmp";

        //Boost pump
        public const string PUMP_RUNNINGL= BMP_FOLDER + "boost_open.bmp";
        public const string PUMP_STOPPEDL = BMP_FOLDER + "boost_closed.bmp";

    }
}
