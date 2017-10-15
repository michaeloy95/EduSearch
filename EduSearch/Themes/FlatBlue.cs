using System.Drawing;

namespace EduSearch.Themes
{
    public class FlatBlue : Theme
    {
        /// <summary>
        /// Flat Blue Theme default constructor
        /// </summary>
        public FlatBlue()
        {
            TEXT_PRIMARY_COLOR = Color.FromArgb(255, 255, 255);
            TEXT_SECONDARY_COLOR = Color.FromArgb(236, 240, 241);
            TEXT_TERTIARY_COLOR = Color.FromArgb(189, 195, 199);
            TEXT_TEXTBOX_COLOR = Color.FromArgb(25, 25, 25);
            TEXT_BACKHOVER_COLOR = Color.FromArgb(94, 154, 193);
            TEXT_BACKCLICK_COLOR = Color.FromArgb(41, 102, 142);
            TEXT_BACKHOVER_COLOR_R = Color.FromArgb(231, 76, 60);
            TEXT_BACKCLICK_COLOR_R = Color.FromArgb(192, 57, 43);
            BACKGROUND_PRIMARY_COLOR = Color.FromArgb(34, 167, 240);
            BACKGROUND_SECONDARY_COLOR = Color.FromArgb(52, 152, 219);
            BACKGROUND_NAVIGATION_COLOR = Color.FromArgb(41, 128, 185);
        }        
    }
}
