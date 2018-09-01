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
    public partial class AuraPanel : UserControl
    {
        public AuraPanel()
        {
            InitializeComponent();

            // 保存されている行動力をセットする
            textBoxVal.Text =
                Properties.Settings.Default.AuraVal.ToString();

            // 保存されている行動力最大値をセットする
            textBoxMax.Text =
                Properties.Settings.Default.AuraMax.ToString();

            // ラベルの親を PictureBox に設定
            labelAuraState.Parent = pictureBoxAuraState;
            labelAuraState.Location = new Point(0, 0);

            // PictureBox の色を設定
            SetColor(pictureBoxAuraState, false);
        }

        // PictureBox の色を設定
        void SetColor(PictureBox picBox, bool state)
        {
            Color col, gra;

            if (state)
            {
                // 紫
                col = Color.FromArgb(101, 31, 156);
                gra = Color.FromArgb(212, 113, 255);
            }
            else
            {
                // グレー
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

        // アウラゲートの状態が変化した
        private void auraTimer1_AuraStateChanged(object sender, EventArgs e)
        {
            // ラベルを変更
            labelAuraState.Text = auraTimer1.IsOpen ? "消滅まで" : "出現まで";
            // ラベル背景（PictureBox）の色を変更
            SetColor(pictureBoxAuraState, auraTimer1.IsOpen);
        }

        // 1 秒毎イベント
        private void auraTimer1_SecondChanged(object sender, EventArgs e)
        {
            // 時間の表示を書き換える
            labelAuraTime.Text = auraTimer1.IsOpen ?
                auraTimer1.UpToClose.ToString(@"hh\:mm\:ss") :
                auraTimer1.UpToOpen.ToString(@"hh\:mm\:ss");
        }

        // 1 分毎イベント
        private void auraTimer1_MinutesChanged(object sender, EventArgs e)
        {
            #region TextBox の値チェック

            // Validating でもええんやろけど…

            if (int.TryParse(textBoxVal.Text, out int val))
            {
                textBoxVal.ForeColor = SystemColors.WindowText;
            }
            else
            {
                textBoxVal.ForeColor = Color.Red;
                return;
            }

            if (int.TryParse(textBoxMax.Text, out int max))
            {
                textBoxMax.ForeColor = SystemColors.WindowText;
            }
            else
            {
                textBoxMax.ForeColor = Color.Red;
                return;
            }

            if (val < 0)
            {
                textBoxVal.ForeColor = Color.Red;
                return;
            }

            if (max < 0)
            {
                textBoxMax.ForeColor = Color.Red;
                return;
            }

            #endregion

            if (val < max)
            {
                // 行動力の値を 1 回復
                // 保存するように変更 20180831
                val++;

                Properties.Settings.Default.AuraVal = val;  // 20180831
                Properties.Settings.Default.Save();         // 20180831

                textBoxVal.Text = val.ToString();

                // メッセージを表示する設定なら表示イベントを発生させる
                if (Properties.Settings.Default.AuraMessage)
                {
                    if (val == max - Properties.Settings.Default.BeforeAuraVal)
                    {
                        OnShowMessage(string.Format(
                            "行動力回復まで {0} 分",
                            Properties.Settings.Default.BeforeAuraVal));
                    }
                }
            }
        }

        // 入力されたら保存する
        private void textBoxMax_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMax.Text, out int max))
            {
                Properties.Settings.Default.AuraMax = max;
                Properties.Settings.Default.Save();
            }
        }

        private void textBoxVal_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxVal.Text, out int val))
            {
                Properties.Settings.Default.AuraVal = val;
                Properties.Settings.Default.Save();
            }
        }

        // AuraTimer の Enabled 値を Form に通達
        public bool TimerEnabled
        {
            get { return auraTimer1.Enabled; }
            set { auraTimer1.Enabled = value; }
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
    }
}
