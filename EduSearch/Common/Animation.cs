using System.Drawing;

namespace EduSearch.Common
{
    public class Animation
    {
        /// <summary>
        /// Gives raise up animation to the label
        /// </summary>
        /// <param name="label">label object</param>
        /// <param name="interval">time interval in millisecond</param>
        /// <param name="height">height the animation takes place</param>
        public static void RaiseUpAnimation<T>(ref T control, int interval, int height)
        {
            System.Windows.Forms.Control myControl = control as System.Windows.Forms.Control;
            double targetY = myControl.Location.Y;
            double currentY = targetY + height;
            const double constant = 0.05;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                currentY = (currentY - targetY <= 1) ? targetY : currentY;
                myControl.Location = new Point(myControl.Location.X, (int)currentY);

                if (currentY == targetY)
                {
                    timer.Stop();
                }
                currentY -= (currentY - targetY) * constant;
            };

            timer.Start();
        }

        /// <summary>
        /// Gives fade in animation to label
        /// </summary>
        /// <param name="label">label object</param>
        /// <param name="interval">time interval in millisecond</param>
        public static void LabelFadeInAnimation(ref Custom.CustomLabel label, int interval)
        {
            System.Windows.Forms.Label myLabel = label;
            Color oriColor = myLabel.ForeColor;
            const int ADD_ALPHA = 3;
            int alpha = 0;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                alpha = (alpha > 255) ? 255 : alpha;
                myLabel.ForeColor = Color.FromArgb(alpha, oriColor);

                if (alpha == 255)
                {
                    timer.Stop();
                }
                alpha += ADD_ALPHA;
            };

            timer.Start();
        }

        /// <summary>
        /// Gives fade out animation to label
        /// </summary>
        /// <param name="label">label object</param>
        /// <param name="interval">time interval in millisecond</param>
        public static void LabelFadeOutAnimation(ref Custom.CustomLabel label, int interval)
        {
            System.Windows.Forms.Label myLabel = label;
            Color oriColor = myLabel.ForeColor;
            const int REDUCE_ALPHA = 3;
            int alpha = 255;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                alpha = (alpha < 0) ? 0 : alpha;
                myLabel.ForeColor = Color.FromArgb(alpha, oriColor);

                if (alpha == 0)
                {
                    timer.Stop();
                    myLabel.Dispose();
                    return ;
                }
                alpha -= REDUCE_ALPHA;
            };

            timer.Start();
        }

        /// <summary>
        /// Gives fade in and out animation to label
        /// </summary>
        /// <param name="label">label object</param>
        /// <param name="interval">time interval in millisecond</param>
        /// <param name="delay">time delay between fade in and out in millisecond</param>
        public static void LabelFadeInOutAnimation(ref Custom.CustomLabel label, int interval, int delay)
        {
            System.Windows.Forms.Label myLabel = label;
            Color oriColor = myLabel.ForeColor;
            const int ALTER_ALPHA = 3;
            int alpha = 0, total_delay = 0;
            bool fadeIn = true, fadeOut = false;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                alpha = (alpha > 255) ? 255 : (alpha < 0) ? 0 : alpha;
                if (fadeIn)
                {
                    myLabel.ForeColor = Color.FromArgb(alpha, oriColor);

                    if (alpha == 255)
                    {
                        fadeIn = false;
                    }
                    alpha += ALTER_ALPHA;
                }
                else if (fadeOut)
                {
                    myLabel.ForeColor = Color.FromArgb(alpha, oriColor);

                    if (alpha == 0)
                    {
                        fadeOut = false;
                        timer.Stop();
                        myLabel.Dispose();
                        return;
                    }
                    alpha -= ALTER_ALPHA;
                }
                else
                {
                    total_delay += interval;
                    if (total_delay >= delay)
                    {
                        fadeOut = true;
                    }
                }
            };

            timer.Start();
            myLabel.Visible = true;
        }
    }
}
