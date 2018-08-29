using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dx2Timer
{
    class MoonTimer : BaseTimer
    {
        // https://wikiwiki.jp/d2-megaten-l/%E3%82%A2%E3%82%A6%E3%83%A9%E3%82%B2%E3%83%BC%E3%83%88
        // 満月では獲得マグネタイト (拾い物、戦闘報酬) 2倍、新月では獲得経験値2倍
        // 月齢はアウラゲートの開閉に関係なく動いている
        // 満月を起点にすると「満月→7～1→新月→1～7→満月」のループになっている
        // 満月/新月は10分、他の月齢は7分で次に進む
        // 満月開始（終了）から118分（109分）後にまた満月がやってくる

        const int INTERVAL_MINUTES = 118;   // 満月開始から次の満月まで
        const int TEN_MINUTES = 10;         // 満月と新月 10 分
        const int SEVEN_MINUTES = 7;        // 他の月齢 7 分

        #region constructor - destructor

        public MoonTimer()
        {
        }

        #endregion

        #region method

        // 最初の 1 秒で LastFullMoon を求める
        void Init()
        {
            // 満月基準日を 2018/08/01 01:55 とする（wiki より）
            DateTime reference = new DateTime(2018, 8, 1, 1, 55, 0);
            // 現在時刻との差を求める
            TimeSpan span = Now.Subtract(reference);
            // 分に換算
            double min = span.TotalMinutes;
            // 118 で割って切り捨て
            int div = (int)Math.Floor(min / INTERVAL_MINUTES);
            // 最終満月を求める
            LastFullMoon = reference.AddMinutes(INTERVAL_MINUTES * div);
        }

        // 1 秒毎に実行
        void Refresh()
        {
            // 最終満月 + 118 分を越えたら 1 周したことになる
            if (LastFullMoon.AddMinutes(INTERVAL_MINUTES) <= Now)
            {
                LastFullMoon = LastFullMoon.AddMinutes(INTERVAL_MINUTES);
            }

            #region 月齢 判定（ダサいしｗ）

            if (Now < LastFullMoon.AddMinutes(TEN_MINUTES))
            {
                MoonAge = MoonAges.Full;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES))
            {
                MoonAge = MoonAges.F7N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 2))
            {
                MoonAge = MoonAges.F6N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 3))
            {
                MoonAge = MoonAges.F5N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 4))
            {
                MoonAge = MoonAges.F4N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 5))
            {
                MoonAge = MoonAges.F3N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 6))
            {
                MoonAge = MoonAges.F2N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7))
            {
                MoonAge = MoonAges.F1N;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES))
            {
                MoonAge = MoonAges.New;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES))
            {
                MoonAge = MoonAges.N1F;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 2))
            {
                MoonAge = MoonAges.N2F;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 3))
            {
                MoonAge = MoonAges.N3F;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 4))
            {
                MoonAge = MoonAges.N4F;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 5))
            {
                MoonAge = MoonAges.N5F;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 6))
            {
                MoonAge = MoonAges.N6F;
            }
            else if (Now < LastFullMoon.AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7)
                .AddMinutes(TEN_MINUTES).AddMinutes(SEVEN_MINUTES * 7))
            {
                MoonAge = MoonAges.N7F;
            }
            else
            {
                MoonAge = MoonAges.none;    // エラーのような気がするけどなぁ
            }

            #endregion
        }

        #endregion

        #region override

        // 初期化時
        protected override void OnCanInitialize(object sender, EventArgs e)
        {
            base.OnCanInitialize(sender, e);
            Init();
        }

        // 1 秒毎
        protected override void OnSecondChanged(object sender, EventArgs e)
        {
            base.OnSecondChanged(sender, e);
            Refresh();
        }

        #endregion

        #region property

        #region 満月関係

        // 前回の満月（開始時間）→ 基準時間
        DateTime lastFullMoon;
        public DateTime LastFullMoon
        {
            get { return lastFullMoon; }
            private set
            {
                if (lastFullMoon != value)
                {
                    lastFullMoon = value;
                    //OnLastFullMoonChanged();
                }
            }
        }

        // 現在が満月か
        public bool IsFullMoon =>
            Now < LastFullMoon.AddMinutes(TEN_MINUTES);

        // 次の満月
        public DateTime NextFullMoon =>
            LastFullMoon.AddMinutes(INTERVAL_MINUTES);

        // 次の満月までの時間
        public TimeSpan UpToNextFullMoon =>
            IsFullMoon ? TimeSpan.Zero : NextFullMoon.Subtract(Now);

        // 満月の残り時間（満月の間）
        public TimeSpan RemainingFullMoon =>
            IsFullMoon ? LastFullMoon.AddMinutes(TEN_MINUTES).Subtract(Now) : TimeSpan.Zero;

        #endregion

        #region 新月関係

        // 前回の新月
        // 満月 + 59 分 未満なら満月より前の新月
        // それ以上なら満月の次の新月
        public DateTime LastNewMoon =>
            Now < LastFullMoon.AddMinutes(INTERVAL_MINUTES / 2) ?
            LastFullMoon.AddMinutes(INTERVAL_MINUTES / 2 * -1) :
            LastFullMoon.AddMinutes(INTERVAL_MINUTES / 2);

        // 現在が新月か
        public bool IsNewMoon =>
            Now < LastNewMoon.AddMinutes(TEN_MINUTES);

        // 次の新月
        public DateTime NextNewMoon =>
            LastNewMoon.AddMinutes(INTERVAL_MINUTES);

        // 次の新月までの時間
        public TimeSpan UpToNextNewMoon =>
            IsNewMoon ? TimeSpan.Zero : NextNewMoon.Subtract(Now);

        // 新月の残り時間（新月の間）
        public TimeSpan RemainingNewMoon =>
            IsNewMoon ? LastNewMoon.AddMinutes(TEN_MINUTES).Subtract(Now) : TimeSpan.Zero;

        #endregion

        private MoonAges moonAge;
        private MoonAges MoonAge
        {
            get { return moonAge; }
            set
            {
                // 値が変わったら変更する
                if (moonAge != value)
                {
                    moonAge = value;

                    // 値が変わったので MoonAgeChanged イベント発生
                    OnMoonAgeChanged();         
                }
            }
        }

        #endregion

        #region event

        // 月齢が変化したら発生するイベント
        public delegate void MoonAgeEventHandler(object sender, MoonAgeEventArgs e);
        public event MoonAgeEventHandler MoonAgeChanged;
        protected virtual void OnMoonAgeChanged(object sender, MoonAgeEventArgs e)
        {
            this.MoonAgeChanged?.Invoke(sender, e);
        }
        private void OnMoonAgeChanged()
        {
            this.OnMoonAgeChanged(this, new MoonAgeEventArgs(moonAge));
        }

        // LastFullMoon の値が変わったら発生する
        //public event EventHandler LastFullMoonChanged;
        //protected virtual void OnLastFullMoonChanged(object sender, EventArgs e)
        //{
        //    this.LastFullMoonChanged?.Invoke(sender, e);
        //}
        //private void OnLastFullMoonChanged()
        //{
        //    this.OnLastFullMoonChanged(this, new EventArgs());
        //}

        #endregion
    }
}
