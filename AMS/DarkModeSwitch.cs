using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS
{/// <summary>
 /// Handles all inputs and validation of functions that will take place in <c>Class: DarkModeSwitch</c>
 /// </summary>
    public class DarkModeSwitch
    {
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color FontColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color BackgroundColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color PanelColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color GroupBoxColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color TextBoxColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color SearchBoxColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static Color ProfileButtonColour;
        /// <summary>
        /// Global variable
        /// </summary>
        public static bool Switch = false;

        /// <summary>
        /// The resulting method for when switch is in use
        /// </summary>
        public static void SwitchFunction()
        {
            //if the button is clicked
            if(Switch==true)
            {
                //Use the function DarkMode
                DarkMode();
            }

            //otherwise
            else
            {
                //Use the function LightMode
                LightMode();
            }
        }
        /// <summary>
        /// The resulting method for setting the form to lightmode
        /// </summary>
        private static void LightMode()
        {
            /// Sets the colour of any text to black
            FontColour = Color.Black;

            //Sets the Background colour an rgb value (the colours equivalent to the form fmAMS)
            BackgroundColour = Color.FromArgb(153, 180, 209);

            //Sets the panel colour an rgb value (the colours equivalent to the form FmAMS)
            PanelColour = Color.FromArgb(153, 180, 209);

            //Sets the group box colour an rgb value (the colours equivalent to the form FmAMS)
            GroupBoxColour = Color.FromArgb(0, 120, 215);

            //Sets the texbox colour an rgb value (the colours equivalent to the form FmAMS)
            TextBoxColour = Color.FromArgb(0, 120, 215);

            //Sets the Search colour an rgb value (the colours equivalent to the form FmAMS)
            SearchBoxColour = Color.FromArgb(255, 236, 216);

            //Sets the Background colour an rgb value (the colours equivalent to the form FmAMS)
            ProfileButtonColour = Color.FromArgb(153, 180, 209);

            //Sets the button that is represented as a bool to true
            Switch = true;
        }

        /// <summary>
        /// The resulting method for setting the form to DarkMode
        /// </summary>
        private static void DarkMode()
        {
            /// Sets the colour of any text to white
            FontColour = Color.White;

            //Sets the Background colour to an rgb value for a dark colour (For the form: FmAMS)
            BackgroundColour = Color.FromArgb(51, 51, 51);

            //Sets the panel colour to an rgb value for a dark colour (For the form: FmAMS)
            PanelColour = Color.FromArgb(51, 51, 51);

            //Sets the group box colour to an rgb value for a dark colour (For the form: FmAMS)
            GroupBoxColour = Color.FromArgb(38, 38, 38);

            //Sets the text box  colour to an rgb value for a dark colour (For the form: FmAMS)
            TextBoxColour = Color.FromArgb(38, 38, 38);

            //Sets the search box colour to an rgb value for a dark colour (For the form: FmAMS)
            SearchBoxColour = Color.FromArgb(52, 52, 51);

            //Sets the button colour to an rgb value for a dark colour(For the form: FmAMS)
            ProfileButtonColour = Color.FromArgb(51, 51, 51);

            //Sets the button that is represented as a bool to false
            Switch = false;
        }
    }

}
