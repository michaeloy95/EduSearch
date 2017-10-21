using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduSearch.Custom
{
    public class CustomLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = this.ClientRectangle;
            StringFormat fmt = new StringFormat(StringFormat.GenericTypographic);
            fmt.Alignment = StringAlignment.Near;
            using (var br = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, br, rc, fmt);
            }
        }
    }
}
