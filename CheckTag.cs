using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Dx2Timer
{
    class CheckTag : CheckBox
    {
        public CheckTag()
        {
            Appearance = Appearance.Button;
            AutoSize = false;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(21, 54);
            Text = "";

            Draw();

            SetStyle(ControlStyles.Selectable, false);
        }

        void Draw()
        {
            List<Point> points = new List<Point>();
            List<byte> types = new List<byte>();

            if (this.Checked)
            {
                this.Image = Properties.Resources.tag_enabled;

                points.Add(new Point(2, 12));
                points.Add(new Point(2, 47));
                points.Add(new Point(13, 54));
                points.Add(new Point(13, 41));
                points.Add(new Point(20, 36));
                points.Add(new Point(20, 1));

                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
            }
            else
            {
                this.Image = Properties.Resources.tag_disabled;

                points.Add(new Point(2, 12));
                points.Add(new Point(2, 47));
                points.Add(new Point(20, 36));
                points.Add(new Point(20, 1));

                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
                types.Add((byte)PathPointType.Line);
            }

            GraphicsPath path =
                new GraphicsPath(points.ToArray(), types.ToArray());
            this.Region = new Region(path);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            Draw();
            base.OnCheckedChanged(e);
        }
    }
}
