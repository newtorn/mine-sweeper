using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace mine_sweeper
{
     public class Common
    {
        private static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // top left
            path.AddArc(arcRect, 180, 90);

            // top right
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // bottom right
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // bottom left
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void SetWindowRegion(Form form)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            form.Region = new Region(FormPath);

        }

        public static void SetWindowCenterScreen(Form form)
        {
            int width = System.Windows.Forms.SystemInformation.WorkingArea.Width;
            int height = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            int fwidth = form.Size.Width;
            int fheight = form.Size.Height;
            form.SetDesktopLocation((width - fwidth) / 2, (height - fheight) / 2);
        }
    }

}
