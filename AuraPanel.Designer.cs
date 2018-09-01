namespace Dx2Timer
{
    partial class AuraPanel
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
            this.labelAuraTime = new System.Windows.Forms.Label();
            this.labelAuraState = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxAuraState = new System.Windows.Forms.PictureBox();
            this.textBoxVal = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.pictureBoxEnergy = new System.Windows.Forms.PictureBox();
            this.auraTimer1 = new Dx2Timer.AuraTimer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuraState)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(131)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(67, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "アウラ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAuraTime
            // 
            this.labelAuraTime.ForeColor = System.Drawing.Color.White;
            this.labelAuraTime.Location = new System.Drawing.Point(29, 47);
            this.labelAuraTime.Name = "labelAuraTime";
            this.labelAuraTime.Size = new System.Drawing.Size(94, 27);
            this.labelAuraTime.TabIndex = 7;
            this.labelAuraTime.Text = "00:48:39";
            this.labelAuraTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuraState
            // 
            this.labelAuraState.BackColor = System.Drawing.Color.Transparent;
            this.labelAuraState.ForeColor = System.Drawing.Color.White;
            this.labelAuraState.Location = new System.Drawing.Point(21, 10);
            this.labelAuraState.Name = "labelAuraState";
            this.labelAuraState.Size = new System.Drawing.Size(110, 30);
            this.labelAuraState.TabIndex = 16;
            this.labelAuraState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.labelAuraState);
            this.panel2.Controls.Add(this.pictureBoxAuraState);
            this.panel2.Controls.Add(this.labelAuraTime);
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 82);
            this.panel2.TabIndex = 13;
            // 
            // pictureBoxAuraState
            // 
            this.pictureBoxAuraState.Location = new System.Drawing.Point(21, 10);
            this.pictureBoxAuraState.Name = "pictureBoxAuraState";
            this.pictureBoxAuraState.Size = new System.Drawing.Size(110, 30);
            this.pictureBoxAuraState.TabIndex = 15;
            this.pictureBoxAuraState.TabStop = false;
            // 
            // textBoxVal
            // 
            this.textBoxVal.Location = new System.Drawing.Point(10, 43);
            this.textBoxVal.Name = "textBoxVal";
            this.textBoxVal.Size = new System.Drawing.Size(50, 34);
            this.textBoxVal.TabIndex = 17;
            this.textBoxVal.Text = "0";
            this.textBoxVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxVal.Validated += new System.EventHandler(this.textBoxVal_Validated);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(92, 43);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(50, 34);
            this.textBoxMax.TabIndex = 19;
            this.textBoxMax.Text = "500";
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMax.Validated += new System.EventHandler(this.textBoxMax_Validated);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.labelEnergy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBoxEnergy);
            this.panel1.Controls.Add(this.textBoxVal);
            this.panel1.Controls.Add(this.textBoxMax);
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 82);
            this.panel1.TabIndex = 17;
            // 
            // labelEnergy
            // 
            this.labelEnergy.BackColor = System.Drawing.Color.Transparent;
            this.labelEnergy.ForeColor = System.Drawing.Color.White;
            this.labelEnergy.Location = new System.Drawing.Point(21, 10);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(110, 30);
            this.labelEnergy.TabIndex = 16;
            this.labelEnergy.Text = "行動力";
            this.labelEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEnergy
            // 
            this.pictureBoxEnergy.Location = new System.Drawing.Point(21, 10);
            this.pictureBoxEnergy.Name = "pictureBoxEnergy";
            this.pictureBoxEnergy.Size = new System.Drawing.Size(110, 30);
            this.pictureBoxEnergy.TabIndex = 15;
            this.pictureBoxEnergy.TabStop = false;
            // 
            // auraTimer1
            // 
            this.auraTimer1.IsOpen = false;
            this.auraTimer1.AuraStateChanged += new System.EventHandler(this.auraTimer1_AuraStateChanged);
            this.auraTimer1.SecondChanged += new System.EventHandler(this.auraTimer1_SecondChanged);
            this.auraTimer1.MinutesChanged += new System.EventHandler(this.auraTimer1_MinutesChanged);
            // 
            // AuraPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "AuraPanel";
            this.Size = new System.Drawing.Size(150, 308);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuraState)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnergy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAuraTime;
        private System.Windows.Forms.PictureBox pictureBoxAuraState;
        private System.Windows.Forms.Label labelAuraState;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxVal;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.PictureBox pictureBoxEnergy;
        private AuraTimer auraTimer1;
    }
}
