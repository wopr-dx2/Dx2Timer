using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dx2Timer
{
    public partial class FormMain : Form
    {
        // panel
        int PANEL_EXPAND = 113;     // 開く
        int PANEL_COLLAPSE = -108;  // 閉じる

        // Form 移動用
        Point mousePoint;

        public FormMain()
        {
            InitializeComponent();

            // デザイナで Marlett が選べないのでここで
            buttonClose.Font = new Font("Marlett", 8, FontStyle.Regular);
            buttonHide.Font = new Font("Marlett", 8, FontStyle.Regular);

            // タイトルバーが無くてもフォームが動くようにする
            // Form のイベントと MoonBox を共用する
            // しかしこれ、そもそも Form 見えてないのでは…
            moonBox1.MouseDown +=
                new MouseEventHandler(FormMain_MouseDown);
            moonBox1.MouseMove +=
                new MouseEventHandler(FormMain_MouseMove);

            // チェックボックスの親を変更
            buttonInfo.Parent = moonBox1;

            // チェックボックスの形を変更
            // http://dobon.net/vb/dotnet/form/formregion.html
            Point[] points =
            {
                new Point(0,0),
                new Point(0,60),
                new Point(52, 30)
            };
            byte[] types =
            {
                (byte) System.Drawing.Drawing2D.PathPointType.Line,
                (byte) System.Drawing.Drawing2D.PathPointType.Line,
                (byte) System.Drawing.Drawing2D.PathPointType.Line
            };
            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath(points, types);
            buttonInfo.Region = new Region(path);

            // TopMost
            checkBoxTopMost.Checked = Properties.Settings.Default.TopMost;
            this.TopMost = Properties.Settings.Default.TopMost;

            // 背景を透明にする
            this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.AllowTransparency = true;
        }

        // 各タイマー起動
        private void Form1_Load(object sender, EventArgs e)
        {
            moonPanel1.TimerEnabled = true;
            auraPanel1.TimerEnabled = Properties.Settings.Default.AuraMessage;
        }

        // 右上 最小化ボタン
        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
        }

        // 右上 閉じるボタン
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Form 移動

        // https://dobon.net/vb/dotnet/form/moveform.html

        // WndProc にしようかと思ったが、面倒なのでマウス操作だけで…

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        #endregion

        #region 情報ボタン(i)を押した時にパネルを表示

        // 閉じる・月齢パネル・アウラゲートパネル の tri-state
        enum PanelStates { Close, Moon, Aura };
        PanelStates panelState = PanelStates.Close;

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            switch (panelState)
            {
                case PanelStates.Close:
                    moonPanel1.Top = PANEL_EXPAND;
                    panelState = PanelStates.Moon;
                    break;
                case PanelStates.Moon:
                    moonPanel1.Top = PANEL_COLLAPSE;
                    auraPanel1.Top = PANEL_EXPAND;
                    panelState = PanelStates.Aura;
                    break;
                case PanelStates.Aura:
                    auraPanel1.Top = PANEL_COLLAPSE;
                    panelState = PanelStates.Close;
                    break;
                default:
                    moonPanel1.Top = PANEL_COLLAPSE;
                    auraPanel1.Top = PANEL_COLLAPSE;
                    panelState = PanelStates.Close;
                    break;
            }
        }

        #endregion

        // テスト用
        private void button1_Click(object sender, EventArgs e)
        {
            //CalcMoonAge calc = new CalcMoonAge();
            //MessageBox.Show(moonTimer1.LastFullMoon.ToString("yyyy/MM/dd HH:mm:ss"));
        }

        // アイコンをダブルクリックした
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 表示(&S) を実行する
            toolStripMenuItemShow.PerformClick();
        }

        // 表示(&S)
        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            this.Visible = true;

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                //notifyIcon1.Visible = false;
            }
        }

        // 次の満月(&N)
        private void toolStripMenuItemNextFullMoon_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText =
                moonPanel1.MoonAge == MoonAges.Full ?
                    string.Format("次の満月は {0}", moonPanel1.NextFullMoon.ToString("MM/dd HH:mm"))
                :
                    string.Format("次の満月は {0}", moonPanel1.NextFullMoon.ToString("MM/dd HH:mm")) +
                    Environment.NewLine +
                    string.Format("次の満月まで {0}", moonPanel1.UpToFullMoon.ToString(@"hh\:mm"));
            notifyIcon1.ShowBalloonTip(3000);
        }

        // 終了(&X)
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            // 閉じるボタンに任せる
            buttonClose.PerformClick();
        }

        #region ぴょこって出るやつ

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            if (panelState == PanelStates.Close & moonPanel1.Top < 0)
            {
                moonPanel1.Top = PANEL_COLLAPSE + 10;
            }
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            if (moonPanel1.Top < 0)
            {
                moonPanel1.Top = PANEL_COLLAPSE;
            }
        }

        #endregion

        private void checkBoxTopMostTopMost_CheckedChanged(object sender, EventArgs e)
        {
            // 常に手前に表示
            this.TopMost = checkBoxTopMost.Checked;
            
            // 値を保存
            Properties.Settings.Default.TopMost = checkBoxTopMost.Checked;
            Properties.Settings.Default.Save();
        }

        private void moonPanel1_MoonAgeChanged(object sender, MoonAgeEventArgs e)
        {
            // MoonPanel
            moonBox1.MoonAge = e.MoonAge;

            // NotifyIcon
            // 継承できればコントロールに任せるんやけど…
            switch (e.MoonAge)
            {
                case MoonAges.none:
                    notifyIcon1.Icon = Properties.Resources.iNewMoon;
                    break;
                case MoonAges.Full:
                    notifyIcon1.Icon = Properties.Resources.iFullMoon;
                    break;
                case MoonAges.F7N:
                    notifyIcon1.Icon = Properties.Resources.iF7N;
                    break;
                case MoonAges.F6N:
                    notifyIcon1.Icon = Properties.Resources.iF6N;
                    break;
                case MoonAges.F5N:
                    notifyIcon1.Icon = Properties.Resources.iF5N;
                    break;
                case MoonAges.F4N:
                    notifyIcon1.Icon = Properties.Resources.iF4N;
                    break;
                case MoonAges.F3N:
                    notifyIcon1.Icon = Properties.Resources.iF3N;
                    break;
                case MoonAges.F2N:
                    notifyIcon1.Icon = Properties.Resources.iF2N;
                    break;
                case MoonAges.F1N:
                    notifyIcon1.Icon = Properties.Resources.iF1N;
                    break;
                case MoonAges.New:
                    notifyIcon1.Icon = Properties.Resources.iNewMoon;
                    break;
                case MoonAges.N1F:
                    notifyIcon1.Icon = Properties.Resources.iN1F;
                    break;
                case MoonAges.N2F:
                    notifyIcon1.Icon = Properties.Resources.iN2F;
                    break;
                case MoonAges.N3F:
                    notifyIcon1.Icon = Properties.Resources.iN3F;
                    break;
                case MoonAges.N4F:
                    notifyIcon1.Icon = Properties.Resources.iN4F;
                    break;
                case MoonAges.N5F:
                    notifyIcon1.Icon = Properties.Resources.iN5F;
                    break;
                case MoonAges.N6F:
                    notifyIcon1.Icon = Properties.Resources.iN6F;
                    break;
                case MoonAges.N7F:
                    notifyIcon1.Icon = Properties.Resources.iN7F;
                    break;
                default:
                    notifyIcon1.Icon = Properties.Resources.iNewMoon;
                    break;
            }
        }

        private void moonPanel1_ShowMessage(object sender, MessageEventArgs e)
        {
            // 満月の {0} 分前です
            notifyIcon1.BalloonTipText = e.Message;
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void auraPanel1_ShowMessage(object sender, MessageEventArgs e)
        {
            // 行動力回復まで {0} 分
            notifyIcon1.BalloonTipText = e.Message;
            notifyIcon1.ShowBalloonTip(3000);
        }
    }
}
