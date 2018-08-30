namespace Dx2Timer
{
    partial class MoonPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelState1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelState2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.moonTimer1 = new Dx2Timer.MoonTimer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(131)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(85, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "月齢";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.labelState1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelTime1);
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 82);
            this.panel2.TabIndex = 13;
            // 
            // labelState1
            // 
            this.labelState1.BackColor = System.Drawing.Color.Transparent;
            this.labelState1.ForeColor = System.Drawing.Color.White;
            this.labelState1.Location = new System.Drawing.Point(21, 10);
            this.labelState1.Name = "labelState1";
            this.labelState1.Size = new System.Drawing.Size(110, 30);
            this.labelState1.TabIndex = 16;
            this.labelState1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 30);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelTime1
            // 
            this.labelTime1.ForeColor = System.Drawing.Color.White;
            this.labelTime1.Location = new System.Drawing.Point(29, 47);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(94, 27);
            this.labelTime1.TabIndex = 7;
            this.labelTime1.Text = "00:48:39";
            this.labelTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.labelState2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.labelTime2);
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 82);
            this.panel3.TabIndex = 14;
            // 
            // labelState2
            // 
            this.labelState2.BackColor = System.Drawing.Color.Transparent;
            this.labelState2.ForeColor = System.Drawing.Color.White;
            this.labelState2.Location = new System.Drawing.Point(21, 10);
            this.labelState2.Name = "labelState2";
            this.labelState2.Size = new System.Drawing.Size(110, 30);
            this.labelState2.TabIndex = 18;
            this.labelState2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(21, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 30);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // labelTime2
            // 
            this.labelTime2.ForeColor = System.Drawing.Color.White;
            this.labelTime2.Location = new System.Drawing.Point(29, 47);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(94, 27);
            this.labelTime2.TabIndex = 7;
            this.labelTime2.Text = "01:47:39";
            this.labelTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moonTimer1
            // 
            this.moonTimer1.MoonAgeChanged += new Dx2Timer.MoonTimer.MoonAgeEventHandler(this.moonTimer1_MoonAgeChanged);
            this.moonTimer1.SecondChanged += new System.EventHandler(this.moonTimer1_SecondChanged);
            // 
            // MoonPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "MoonPanel";
            this.Size = new System.Drawing.Size(150, 308);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelState1;
        private System.Windows.Forms.Label labelState2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MoonTimer moonTimer1;
    }
}
