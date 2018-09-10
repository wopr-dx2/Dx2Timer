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
            pictureBoxResist.Region = new Region(path);

            // ボタンの形を変更　シバブー
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
                if (labelTitle.Text != "ノズチ")
                {
                    labelTitle.Text = "ノズチ";
                    pictureBoxResist.BackgroundImage =
                        Properties.Resources.resist_nozuchi;
                }

                if (pictureBoxNormal.Visible)
                {
                    pictureBoxNormal.Visible = false;

                    // https://dobon.net/vb/dotnet/programing/random.html

                    Random r = new Random(DateTime.Now.Millisecond);
                    int i = r.Next(3000);
#if DEBUG
                    int j = 100;
#else
                    int j = 1;
#endif

                    if (i < 15 * j)
                    {
                        pictureBoxRare.Visible = true;
                        // http://posnum.hatenablog.com/entry/2014/10/28/222436
                        await Task.Delay(1500);

                        if (i < 5 * j)
                        {
                            labelTitle.Text = "スルト";
                            pictureBoxResist.BackgroundImage =
                                Properties.Resources.resist_surt;
                            pictureBoxResult.BackgroundImage =
                                Properties.Resources.nozuchi_surt;
                        }
                        else if (i < 10 * j)
                        {
                            labelTitle.Text = "ノズチ？";
                            pictureBoxResult.BackgroundImage =
                                Properties.Resources.nozuchi_mara;
                        }
                        else
                        {
                            labelTitle.Text = "ノズチ？";
                            pictureBoxResult.BackgroundImage =
                                Properties.Resources.nozuchi_komugiko;
                        }

                        pictureBoxRare.Visible = false;
                        pictureBoxResult.Visible = true;
                    }
                    else
                    {
                        pictureBoxBinded.Visible = true;
                    }
                }
                else
                {
                    pictureBoxBinded.Visible = false;
                    pictureBoxResult.Visible = false;
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
