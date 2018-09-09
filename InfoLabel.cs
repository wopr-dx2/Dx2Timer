using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dx2Timer
{
    class InfoLabel : Label
    {
        public InfoLabel()
        {
            this.ForeColor = Color.White;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            using (SolidBrush enabledBrush = new SolidBrush(Color.FromArgb(101, 31, 156)))
            using (SolidBrush disabledBrush = new SolidBrush(Color.FromArgb(80, 80, 80)))
            {
                for (int i = 0; i < 10; i++)
                {
                    Rectangle rect = new Rectangle(i * 7, 0, 7, 27);
                    if (StartTime.AddMinutes(i).Minute < 55)
                    {
                        e.Graphics.FillRectangle(enabledBrush, rect);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(disabledBrush, rect);
                    }
                }
            }
            base.OnPaint(e);
        }

        DateTime startTime = DateTime.Now;
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                this.Text = startTime.ToString("HH:mm");
                this.Refresh();
            }
        }
    }
}
