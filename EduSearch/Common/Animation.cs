using System.Drawing;

namespace EduSearch.Common
{
    public class Animation
    {
        /// <summary>
        /// Maximum value in color range
        /// </summary>
        private const int MAX_COLOR = 255;

        /// <summary>
        /// Gives raise up animation to the label
        /// </summary>
        /// <param name="label">Label object</param>
        /// <param name="interval">Yime interval in millisecond</param>
        /// <param name="height">Height the animation takes place</param>
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
        /// <param name="label">Label object</param>
        /// <param name="interval">Time interval in millisecond</param>
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
                alpha = (alpha > MAX_COLOR) ? MAX_COLOR : alpha;
                myLabel.ForeColor = Color.FromArgb(alpha, oriColor);

                if (alpha == MAX_COLOR)
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
        /// <param name="label">Label object</param>
        /// <param name="interval">Time interval in millisecond</param>
        public static void LabelFadeOutAnimation(ref Custom.CustomLabel label, int interval)
        {
            System.Windows.Forms.Label myLabel = label;
            Color oriColor = myLabel.ForeColor;
            const int REDUCE_ALPHA = 3;
            int alpha = MAX_COLOR;

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
        /// <param name="label">Label object</param>
        /// <param name="interval">Time interval in millisecond</param>
        /// <param name="delay">Time delay between fade in and out in millisecond</param>
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
                alpha = (alpha > MAX_COLOR) ? MAX_COLOR : (alpha < 0) ? 0 : alpha;
                if (fadeIn)
                {
                    myLabel.ForeColor = Color.FromArgb(alpha, oriColor);

                    if (alpha == MAX_COLOR)
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
        }

        /// <summary>
        /// Gives fade in animation to panel after certain delay
        /// </summary>
        /// <param name="panel">Object panel</param>
        /// <param name="interval">Time interval in millisecond</param>
        /// <param name="delay">Time delay in millisecond</param>
        public static void PanelFadeInAfterAnimation(ref Custom.CustomPanel panel, int interval, int delay)
        {
            System.Windows.Forms.Panel myPanel = panel;
            Color color = myPanel.BackColor;
            const int ADD_ALPHA = 3;
            int alpha = 0, total_interval = 0;

            myPanel.Visible = true;
            myPanel.BackColor = Color.FromArgb(alpha, color);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                if (total_interval >= delay)
                {
                    total_interval = delay;
                    myPanel.BackColor = Color.FromArgb(alpha, color);

                    if (alpha >= MAX_COLOR)
                    {
                        timer.Stop();
                        
                        foreach (System.Windows.Forms.Control p in myPanel.Controls)
                        {
                            p.Visible = true;
                        }

                        return;
                    }

                    alpha += ADD_ALPHA;
                }
                else
                {
                    total_interval += interval;
                }
            };

            timer.Start();
        }

        /// <summary>
        /// Show control after delay
        /// </summary>
        /// <param name="control">Control object</param>
        /// <param name="interval">Time interval in millisecond</param>
        /// <param name="delay">Time delay in millisecond</param>
        public static void ShowControlAfterAnimation(ref System.Windows.Forms.Control control, int interval, int delay)
        {
            System.Windows.Forms.Control myControl = control;
            int total_interval = 0;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                if (total_interval >= delay)
                {
                    total_interval = delay;
                    timer.Stop();

                    myControl.Visible = true;

                    return;
                }
                else
                {
                    total_interval += interval;
                }
            };

            timer.Start();
        }
    }
}
