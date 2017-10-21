using System.Drawing;

namespace EduSearch.Themes
{
    public class Chrome : Theme
    {
        /// <summary>
        /// Chrome Theme default constructor
        /// </summary>
        public Chrome()
        {
            TEXT_PRIMARY_COLOR = Color.FromArgb(0, 0, 0);
            TEXT_SECONDARY_COLOR = Color.FromArgb(50, 50, 50);
            TEXT_TERTIARY_COLOR = Color.FromArgb(130, 130, 130);
            TEXT_TEXTBOX_COLOR = Color.FromArgb(130, 130, 130);
            TEXT_BACKHOVER_COLOR = Color.FromArgb(250, 250, 250);
            TEXT_BACKCLICK_COLOR = Color.FromArgb(220, 220, 220);
            TEXT_BACKHOVER_COLOR_R = Color.FromArgb(231, 76, 60);
            TEXT_BACKCLICK_COLOR_R = Color.FromArgb(192, 57, 43);
            BACKGROUND_PRIMARY_COLOR = Color.FromArgb(255, 255, 255);
            BACKGROUND_SECONDARY_COLOR = Color.FromArgb(252, 252, 252);
            BACKGROUND_NAVIGATION_COLOR = Color.FromArgb(247, 247, 247);
        }        
    }
}
