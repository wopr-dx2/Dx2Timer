using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Dx2Timer
{
    public partial class NozuchiPanel : UserControl
    {
        const string TIMESPAN_FORMAT = @"hh\:mm\:ss";

        public NozuchiPanel()
        {
            InitializeComponent();

            // 耐性
            Point[] points =
            {
                new Point(0, 66), new Point(0, 88),
                new Point(120, 22), new Point(120, 0)
            };
            byte[] types =
            {
                (byte) PathPointType.Line,
                (byte) PathPointType.Line,
                (byte) PathPointType.Line,
                (byte) PathPointType.Line
            };
            GraphicsPath path =
                new GraphicsPath(points, types);
            pictureBox3.Region = new Region(path);

            // ボタンの形を変更
            // http://dobon.net/vb/dotnet/form/formregion.html
            Point[] points2 =
            {
                new Point(0, 33),
                new Point(0, 75),
                new Point(11, 82),
                new Point(70, 48),
                new Point(70, 5),
                new Point(59, 0)
            };
            byte[] types2 =
            {
                (byte) PathPointType.Line,
                (byte) PathPointType.Line,
                (byte) PathPointType.Line,
                (byte) PathPointType.Line,
                (byte) PathPointType.Line,
                (byte) PathPointType.Line
            };
            GraphicsPath path2 =
                new GraphicsPath(points2, types2);
            button1.Region = new Region(path2);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            try
            {
                if (pictureBoxNormal.Visible)
                {
                    pictureBoxNormal.Visible = false;

                    // https://dobon.net/vb/dotnet/programing/random.html

                    Random r = new Random(DateTime.Now.Millisecond);
                    int i = r.Next(1000);
                    if (i < 5)
                    {
                        pictureBoxRare.Visible = true;
                        // http://posnum.hatenablog.com/entry/2014/10/28/222436
                        await Task.Delay(1500);
                        pictureBoxRare.Visible = false;
                        pictureBoxKomugiko.Visible = true;
                    }
                    else
                    {
                        pictureBoxBinded.Visible = true;
                    }
                }
                else
                {
                    pictureBoxBinded.Visible = false;
                    pictureBoxKomugiko.Visible = false;
                    pictureBoxNormal.Visible = true;
                }
            }
            finally
            {
                button1.Enabled = true;
            }
        }
    }
}
