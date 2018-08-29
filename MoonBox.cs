using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dx2Timer
{
    class MoonBox : PictureBox
    {
        public MoonBox()
        {
            // 下部を斜めにカットする
            Point[] points =
            {
                new Point(0,0), new Point(0,202),
                new Point(156, 110), new Point(156,0)
            };
            byte[] types =
            {
                (byte) System.Drawing.Drawing2D.PathPointType.Line,
                (byte) System.Drawing.Drawing2D.PathPointType.Line,
                (byte) System.Drawing.Drawing2D.PathPointType.Line,
                (byte) System.Drawing.Drawing2D.PathPointType.Line
            };
            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath(points, types);
            this.Region = new Region(path);

            // 最初なんで splash になるのかな？
            //ChangeAge();
        }

        private void ChangeAge()
        {
            switch (this.MoonAge)
            {
                case MoonAges.none:
                    this.Image = Properties.Resources.splash;
                    break;
                case MoonAges.Full:
                    this.Image = Properties.Resources.FullMoon;
                    break;
                case MoonAges.F7N:
                    this.Image = Properties.Resources.F7N;
                    break;
                case MoonAges.F6N:
                    this.Image = Properties.Resources.F6N;
                    break;
                case MoonAges.F5N:
                    this.Image = Properties.Resources.F5N;
                    break;
                case MoonAges.F4N:
                    this.Image = Properties.Resources.F4N;
                    break;
                case MoonAges.F3N:
                    this.Image = Properties.Resources.F3N;
                    break;
                case MoonAges.F2N:
                    this.Image = Properties.Resources.F2N;
                    break;
                case MoonAges.F1N:
                    this.Image = Properties.Resources.F1N;
                    break;
                case MoonAges.New:
                    this.Image = Properties.Resources.NewMoon;
                    break;
                case MoonAges.N1F:
                    this.Image = Properties.Resources.N1F;
                    break;
                case MoonAges.N2F:
                    this.Image = Properties.Resources.N2F;
                    break;
                case MoonAges.N3F:
                    this.Image = Properties.Resources.N3F;
                    break;
                case MoonAges.N4F:
                    this.Image = Properties.Resources.N4F;
                    break;
                case MoonAges.N5F:
                    this.Image = Properties.Resources.N5F;
                    break;
                case MoonAges.N6F:
                    this.Image = Properties.Resources.N6F;
                    break;
                case MoonAges.N7F:
                    this.Image = Properties.Resources.N7F;
                    break;
                default:
                    this.Image = Properties.Resources.splash;
                    break;
            }
            this.Refresh();
        }

        // Form から値をセットする
        private MoonAges moonAge = MoonAges.none;
        public MoonAges MoonAge
        {
            get { return moonAge; }
            set
            {
                if (moonAge != value)
                {
                    moonAge = value;
                    // 月齢イメージ変更
                    ChangeAge();
                }
            }
        }
    }
}
