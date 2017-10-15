using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSearch.Themes
{
    public abstract class Theme
    {
        /// <summary>
        /// Primary color on text
        /// </summary>
        public Color TEXT_PRIMARY_COLOR { get; protected set; }

        /// <summary>
        /// Secondary color on text
        /// </summary>
        public Color TEXT_SECONDARY_COLOR { get; protected set; }

        /// <summary>
        /// Tertiary color on text
        /// </summary>
        public Color TEXT_TERTIARY_COLOR { get; protected set; }

        /// <summary>
        /// Textbox color on text
        /// </summary>
        public Color TEXT_TEXTBOX_COLOR { get; protected set; }

        /// <summary>
        /// Text's background color on mouse hover
        /// </summary>
        public Color TEXT_BACKHOVER_COLOR { get; protected set; }

        /// <summary>
        /// Text's background color on mouse click
        /// </summary>
        public Color TEXT_BACKCLICK_COLOR { get; protected set; }

        /// <summary>
        /// Text's background color on mouse hover
        /// </summary>
        public Color TEXT_BACKHOVER_COLOR_R { get; protected set; }

        /// <summary>
        /// Text's background color on mouse click
        /// </summary>
        public Color TEXT_BACKCLICK_COLOR_R { get; protected set; }

        /// <summary>
        /// Primary color on background
        /// </summary>
        public Color BACKGROUND_PRIMARY_COLOR { get; protected set; }

        /// <summary>
        /// Secondary color on background
        /// </summary>x
        public Color BACKGROUND_SECONDARY_COLOR { get; protected set; }

        /// <summary>
        /// Secondary color on background
        /// </summary>x
        public Color BACKGROUND_NAVIGATION_COLOR { get; protected set; }
    }
}
