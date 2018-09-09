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
    public partial class AgesPanel : UserControl
    {
        const int INTERVAL_MINUTES = 118;   // 満月開始から次の満月まで
        const string FORMAT_MMDD = "MM/dd";

        public AgesPanel()
        {
            InitializeComponent();
        }

        void SetMoonTimes()
        {
            DateTime dateTime;

            // 1 行目
            label1.Text = nextFullMoon.ToString(FORMAT_MMDD);
            infoLabel1.StartTime = nextFullMoon;

            // 2 行目
            label2.Text =
                nextFullMoon.Day == nextFullMoon.AddMinutes(INTERVAL_MINUTES).Day ?
                "" : nextFullMoon.AddMinutes(INTERVAL_MINUTES).ToString(FORMAT_MMDD);
            infoLabel2.StartTime = nextFullMoon.AddMinutes(INTERVAL_MINUTES);
            dateTime = nextFullMoon.AddMinutes(INTERVAL_MINUTES);

            // 3 行目以降
            label3.Text =
                dateTime.Day == dateTime.AddMinutes(INTERVAL_MINUTES).Day ?
                "" : dateTime.AddMinutes(INTERVAL_MINUTES).ToString(FORMAT_MMDD);
            infoLabel3.StartTime = dateTime.AddMinutes(INTERVAL_MINUTES);
            dateTime = dateTime.AddMinutes(INTERVAL_MINUTES);

            label4.Text =
                dateTime.Day == dateTime.AddMinutes(INTERVAL_MINUTES).Day ?
                "" : dateTime.AddMinutes(INTERVAL_MINUTES).ToString(FORMAT_MMDD);
            infoLabel4.StartTime = dateTime.AddMinutes(INTERVAL_MINUTES);
            dateTime = dateTime.AddMinutes(INTERVAL_MINUTES);

            label5.Text =
                dateTime.Day == dateTime.AddMinutes(INTERVAL_MINUTES).Day ?
                "" : dateTime.AddMinutes(INTERVAL_MINUTES).ToString(FORMAT_MMDD);
            infoLabel5.StartTime = dateTime.AddMinutes(INTERVAL_MINUTES);
            dateTime = dateTime.AddMinutes(INTERVAL_MINUTES);

            label6.Text =
                dateTime.Day == dateTime.AddMinutes(INTERVAL_MINUTES).Day ?
                "" : dateTime.AddMinutes(INTERVAL_MINUTES).ToString(FORMAT_MMDD);
            infoLabel6.StartTime = dateTime.AddMinutes(INTERVAL_MINUTES);
            dateTime = dateTime.AddMinutes(INTERVAL_MINUTES);

            label7.Text =
                dateTime.Day == dateTime.AddMinutes(INTERVAL_MINUTES).Day ?
                "" : dateTime.AddMinutes(INTERVAL_MINUTES).ToString(FORMAT_MMDD);
            infoLabel7.StartTime = dateTime.AddMinutes(INTERVAL_MINUTES);
            dateTime = dateTime.AddMinutes(INTERVAL_MINUTES);
        }

        private DateTime nextFullMoon;
        public DateTime NextFullMoon
        {
            get { return nextFullMoon; }
            set
            {
                nextFullMoon = value;
                SetMoonTimes();
            }
        }

        public bool IsInitialized { get; set; } = false;
    }
}
