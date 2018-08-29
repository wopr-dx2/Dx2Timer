using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dx2Timer
{
    class BaseTimer : Timer
    {
        // constructor 内ではイベント発生しない（ LastFullMoonChanged が…）
        bool isFirstRefresh = true;

        public BaseTimer()
        {
            this.Interval = 100;
            this.Enabled = false;
        }

        protected override void OnTick(EventArgs e)
        {
            base.OnTick(e);

            // 最初の 1 回目のイベント発生時だけ
            if (isFirstRefresh)
            {
                isFirstRefresh = false;
                OnCanInitialize();
            }

            // 秒の値が違えば 1 秒毎イベント発生
            if (DateTime.Now.Second != Now.Second)
            {
                if (DateTime.Now.Minute != Now.Minute)
                {
                    Now = DateTime.Now;
                    OnSecondChanged();
                    OnMinutesChanged(); // 分の値が違えば 1 分毎イベント発生
                }
                else
                {
                    Now = DateTime.Now;
                    OnSecondChanged();
                }
            }
        }

        public DateTime Now { get; private set; } = DateTime.Now;

        // 秒が変わったら発生する
        public event EventHandler SecondChanged;
        protected virtual void OnSecondChanged(object sender, EventArgs e)
        {
            this.SecondChanged?.Invoke(sender, e);
        }
        private void OnSecondChanged()
        {
            this.OnSecondChanged(this, new EventArgs());
        }

        // 分が変わったら発生する
        public event EventHandler MinutesChanged;
        protected virtual void OnMinutesChanged(object sender, EventArgs e)
        {
            this.MinutesChanged?.Invoke(sender, e);
        }
        private void OnMinutesChanged()
        {
            this.OnMinutesChanged(this, new EventArgs());
        }

        // 初期化用
        public event EventHandler CanInitialize;
        protected virtual void OnCanInitialize(object sender, EventArgs e)
        {
            this.CanInitialize?.Invoke(sender, e);
        }
        private void OnCanInitialize()
        {
            this.OnCanInitialize(this, new EventArgs());
        }
    }
}
