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
    public partial class MoonPanel : UserControl
    {
        const string TIMESPAN_FORMAT = @"hh\:mm\:ss";

        public MoonPanel()
        {
            InitializeComponent();

            // ラベルの親を PictureBox に設定
            labelState1.Parent = pictureBox1;
            labelState1.Location = new Point(0, 0);

            labelState2.Parent = pictureBox2;
            labelState2.Location = new Point(0, 0);

            // PictureBox の色を設定
            SetColor(pictureBox1, false);
            SetColor(pictureBox2, false);

            // なぜかデザイン時に表示されないのでここで
            moonTimer1.MinutesChanged += MoonTimer1_MinutesChanged;
        }

        // Label の値を書き換える
        void SetState1(string text)
        {
            if (labelState1.Text != text)
            {
                labelState1.Text = text;
            }
        }

        // Label の値を書き換える
        void SetState2(string text)
        {
            if (labelState2.Text != text)
            {
                labelState2.Text = text;
            }
        }

        // PictureBox の色を設定
        void SetColor(PictureBox picBox, bool state)
        {
            Color col, gra;

            if (state)
            {
                col = Color.FromArgb(101, 31, 156);
                gra = Color.FromArgb(212, 113, 255);
            }
            else
            {
                col = Color.FromArgb(80, 80, 80);
                gra = Color.FromArgb(103, 103, 103);
            }

            // ラベルの疑似グラデーション
            picBox.Image = new Bitmap(picBox.Width, picBox.Height);
            using (Graphics g = Graphics.FromImage(picBox.Image))
            using (LinearGradientBrush brush =
                new LinearGradientBrush(
                    g.VisibleClipBounds, Color.Red, Color.Blue,
                    LinearGradientMode.Horizontal))
            {
                ColorBlend blend = new ColorBlend();

                blend.Positions = new float[] { 0.0f, 0.2f, 0.8f, 1.0f };

                blend.Colors = new Color[] { gra, col, col, gra };

                brush.InterpolationColors = blend;

                g.FillRectangle(brush, g.VisibleClipBounds);
            }
        }

        // 月齢
        MoonAges moonAge = MoonAges.none;
        public MoonAges MoonAge
        {
            get { return moonAge; }
            set
            {
                if (moonAge != value)
                {
                    moonAge = value;

                    if (moonAge == MoonAges.Full)
                    {
                        // 満月になった
                        SetState1("満月 残り");
                        SetState2("新月 まで");
                        SetColor(pictureBox1, true);
                    }
                    else if (MoonAges.F7N <= moonAge & moonAge <= MoonAges.F1N)
                    {
                        // 満月終了後の 7/8 齢から 新月手前の 1/8 齢まで
                        SetState1("新月 まで");
                        SetState2("満月 まで");
                        SetColor(pictureBox1, false);
                    }
                    else if (moonAge == MoonAges.New)
                    {
                        // 新月になった
                        SetState1("新月 残り");
                        SetState2("満月 まで");
                        SetColor(pictureBox1, true);
                    }
                    else if (MoonAges.N1F <= moonAge & moonAge <= MoonAges.N7F)
                    {
                        // 新月終了後の 1/8 齢から満月手前の 7/8 齢まで
                        SetState1("満月 まで");
                        SetState2("新月 まで");
                        SetColor(pictureBox1, false);
                    }

                }
            }
        }

        // 次の満月の時間を Form に通達
        public DateTime NextFullMoon => moonTimer1.NextFullMoon;

        // 次の満月までの時間を Form に通達
        public TimeSpan UpToFullMoon => moonTimer1.UpToNextFullMoon;

        // AuraTimer の Enabled 値を Form に通達
        public bool TimerEnabled
        {
            get { return moonTimer1.Enabled; }
            set { moonTimer1.Enabled = value; }
        }

        // 1 秒毎イベント
        private void moonTimer1_SecondChanged(object sender, EventArgs e)
        {
            // 時間の表示
            if (MoonAge == MoonAges.Full)
            {
                labelTime1.Text = moonTimer1.RemainingFullMoon.ToString(TIMESPAN_FORMAT);
                labelTime2.Text = moonTimer1.UpToNextNewMoon.ToString(TIMESPAN_FORMAT);
            }
            else if (MoonAges.F7N <= MoonAge & MoonAge <= MoonAges.F1N)
            {
                labelTime1.Text = moonTimer1.UpToNextNewMoon.ToString(TIMESPAN_FORMAT);
                labelTime2.Text = moonTimer1.UpToNextFullMoon.ToString(TIMESPAN_FORMAT);
            }
            else if (MoonAge == MoonAges.New)
            {
                labelTime1.Text = moonTimer1.RemainingNewMoon.ToString(TIMESPAN_FORMAT);
                labelTime2.Text = moonTimer1.UpToNextFullMoon.ToString(TIMESPAN_FORMAT);
            }
            else if (MoonAges.N1F <= MoonAge & MoonAge <= MoonAges.N7F)
            {
                labelTime1.Text = moonTimer1.UpToNextFullMoon.ToString(TIMESPAN_FORMAT);
                labelTime2.Text = moonTimer1.UpToNextNewMoon.ToString(TIMESPAN_FORMAT);
            }

            OnSecondChanged();
        }

        // 1 分毎イベント
        private void MoonTimer1_MinutesChanged(object sender, EventArgs e)
        {
            // 満月の 5 分前にメッセージを表示する
            //if (moonTimer1.NextFullMoon.AddMinutes(-1 * Properties.Settings.Default.BeforeFullMoon) ==
            //    moonTimer1.Now)

            // なんかおかしいなー思ったら、ミリセカンドまで比較してたのね…
            // なんで最初は動いてたんやろか？
            
            // 修正: 20180828

            string fmt = "yyyyMMddHHmm";
            string before = moonTimer1.NextFullMoon.AddMinutes(
                Properties.Settings.Default.BeforeFullMoon * -1).ToString(fmt);
            string snooze = moonTimer1.NextFullMoon.AddMinutes(
                Properties.Settings.Default.SnoozeFullMoon * -1).ToString(fmt);

            if (moonTimer1.Now.ToString(fmt) == before)
            {
                OnShowMessage(string.Format("満月の {0} 分前です", Properties.Settings.Default.BeforeFullMoon));
            }

            // スヌーズの部分
            // 追加: 20180828
            if (moonTimer1.Now.ToString(fmt) == snooze)
            {
                OnShowMessage(string.Format("満月の {0} 分前です", Properties.Settings.Default.SnoozeFullMoon));
            }
        }

        // メッセージ表示イベント
        public delegate void MessageEentHandler(object sender, MessageEventArgs e);
        public event MessageEentHandler ShowMessage;
        protected virtual void OnShowMessage(object sender, MessageEventArgs e)
        {
            this.ShowMessage?.Invoke(sender, e);
        }
        private void OnShowMessage(string msg)
        {
            this.OnShowMessage(this, new MessageEventArgs(msg));
        }

        // 月齢が変化したとき
        private void moonTimer1_MoonAgeChanged(object sender, MoonAgeEventArgs e)
        {
            MoonAge = e.MoonAge;
            OnMoonAgeChanged();

            // 満月終了時にメッセージ
            // コムギコ氏より要望　20180902
            if (MoonAge == MoonAges.F7N)
            {
                OnShowMessage("満月が終了しました");
            }
        }

        // 月齢が変化したら発生するイベント
        public delegate void MoonAgeEventHandler(object sender, MoonAgeEventArgs e);
        public event MoonAgeEventHandler MoonAgeChanged;
        protected virtual void OnMoonAgeChanged(object sender, MoonAgeEventArgs e)
        {
            this.MoonAgeChanged?.Invoke(sender, e);
        }
        private void OnMoonAgeChanged()
        {
            this.OnMoonAgeChanged(this, new MoonAgeEventArgs(MoonAge));
        }

        // 秒が変化したら発生するイベント
        public event EventHandler SecondChanged;
        protected virtual void OnSecondChanged(object sender, EventArgs e)
        {
            this.SecondChanged?.Invoke(sender, e);
        }
        private void OnSecondChanged()
        {
            this.OnSecondChanged(this, new EventArgs());
        }
    }
}
