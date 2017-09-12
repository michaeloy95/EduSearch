using System;

namespace EduSearch.Common
{
    public class Navigation
    {
        /// <summary>
        /// Default constant for NavPanel drag purpose
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;

        /// <summary>
        /// Default constant for NavPanel drag purpose
        /// </summary>
        public const int HT_CAPTION = 0x2;
        
        /// <summary>
        /// External method for NavPanel drag purpose
        /// </summary>
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /// <summary>
        /// External method for NavPanel drag purpose
        /// </summary>
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
