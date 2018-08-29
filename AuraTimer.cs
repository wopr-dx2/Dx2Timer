using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dx2Timer
{
    class AuraTimer : BaseTimer
    {
        const int OPEN_MINUTE = 0;
        const int CLOSE_MINUTE = 55;

        // 1 秒毎チェック
        protected override void OnSecondChanged(object sender, EventArgs e)
        {
            base.OnSecondChanged(sender, e);

            // 55 分より前は開いている
            IsOpen = Now.Minute < CLOSE_MINUTE;
        }

        // アウラゲートは出現しているか
        private bool isOpen;
        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                if (isOpen != value)
                {
                    isOpen = value;
                    OnAuraStateChanged();
                }
            }
        }

        // 前回 出現していたのは（現時間の分と秒が 0 の値）
        public DateTime LastOpened =>
            new DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, 0, 0);

        // LastOpened に 1 時間足しただけ
        public DateTime NextOpened =>
            LastOpened.AddHours(1);

        // 出現までの時間
        public TimeSpan UpToOpen
        {
            get
            {
                if (IsOpen)
                {
                    // 開いている場合は 0 を返す
                    return TimeSpan.Zero;
                }
                else
                {
                    return NextOpened.Subtract(Now);
                }
            }
        }

        // 消滅までの時間
        public TimeSpan UpToClose
        {
            get
            {
                if (IsOpen)
                {
                    return LastOpened.AddMinutes(CLOSE_MINUTE).Subtract(Now);
                }
                else
                {
                    return TimeSpan.Zero;
                }
            }
        }

        // アウラゲートの状態が変化したらイベント発生
        public event EventHandler AuraStateChanged;
        protected virtual void OnAuraStateChanged(object sender, EventArgs e)
        {
            this.AuraStateChanged?.Invoke(sender, e);
        }
        private void OnAuraStateChanged()
        {
            this.OnAuraStateChanged(this, new EventArgs());
        }
    }
}
