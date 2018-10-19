namespace Dx2Timer
{
    partial class FormMain
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNextFullMoon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpToNextFullMoon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClose = new AntiFocusedButton();
            this.buttonHide = new AntiFocusedButton();
            this.buttonInfo = new AntiFocusedButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxTopMost = new AntiFocusedCheckBox();
            this.checkTagNozuchi = new Dx2Timer.CheckTag();
            this.moonBox1 = new Dx2Timer.MoonBox();
            this.moonPanel1 = new Dx2Timer.MoonPanel();
            this.agesPanel1 = new Dx2Timer.AgesPanel();
            this.nozuchiPanel1 = new Dx2Timer.NozuchiPanel();
            this.contextMenuStripNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "満月 5分前";
            this.notifyIcon1.BalloonTipTitle = "Dx2";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dx2 Timer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemNextFullMoon,
            this.toolStripMenuItemUpToNextFullMoon,
            this.toolStripMenuItem1,
            this.toolStripMenuItemExit});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(182, 130);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(181, 30);
            this.toolStripMenuItemShow.Text = "表示(&S)";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripMenuItemNextFullMoon
            // 
            this.toolStripMenuItemNextFullMoon.Name = "toolStripMenuItemNextFullMoon";
            this.toolStripMenuItemNextFullMoon.Size = new System.Drawing.Size(181, 30);
            this.toolStripMenuItemNextFullMoon.Text = "次の満月(&N)";
            // 
            // toolStripMenuItemUpToNextFullMoon
            // 
            this.toolStripMenuItemUpToNextFullMoon.Name = "toolStripMenuItemUpToNextFullMoon";
            this.toolStripMenuItemUpToNextFullMoon.Size = new System.Drawing.Size(181, 30);
            this.toolStripMenuItemUpToNextFullMoon.Text = "次の満月まで";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(181, 30);
            this.toolStripMenuItemExit.Text = "終了(&X)";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(123, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "r";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.ForeColor = System.Drawing.Color.White;
            this.buttonHide.Location = new System.Drawing.Point(90, 3);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(32, 32);
            this.buttonHide.TabIndex = 4;
            this.buttonHide.TabStop = false;
            this.buttonHide.Text = "0";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Location = new System.Drawing.Point(6, 131);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(52, 60);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.TabStop = false;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            this.buttonInfo.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
            this.buttonInfo.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxTopMost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.checkBoxTopMost.FlatAppearance.BorderSize = 0;
            this.checkBoxTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxTopMost.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.checkBoxTopMost.ForeColor = System.Drawing.Color.White;
            this.checkBoxTopMost.Location = new System.Drawing.Point(55, 3);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(32, 32);
            this.checkBoxTopMost.TabIndex = 16;
            this.checkBoxTopMost.TabStop = false;
            this.checkBoxTopMost.Text = "ë";
            this.checkBoxTopMost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTopMost.UseVisualStyleBackColor = false;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMostTopMost_CheckedChanged);
            // 
            // checkTagNozuchi
            // 
            this.checkTagNozuchi.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTagNozuchi.FlatAppearance.BorderSize = 0;
            this.checkTagNozuchi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTagNozuchi.Image = ((System.Drawing.Image)(resources.GetObject("checkTagNozuchi.Image")));
            this.checkTagNozuchi.Location = new System.Drawing.Point(131, 72);
            this.checkTagNozuchi.Name = "checkTagNozuchi";
            this.checkTagNozuchi.Size = new System.Drawing.Size(21, 54);
            this.checkTagNozuchi.TabIndex = 20;
            this.checkTagNozuchi.TabStop = false;
            this.checkTagNozuchi.UseVisualStyleBackColor = true;
            this.checkTagNozuchi.CheckedChanged += new System.EventHandler(this.checkTagNozuchi_CheckedChanged);
            // 
            // moonBox1
            // 
            this.moonBox1.Image = ((System.Drawing.Image)(resources.GetObject("moonBox1.Image")));
            this.moonBox1.Location = new System.Drawing.Point(0, 0);
            this.moonBox1.MoonAge = Dx2Timer.MoonAges.none;
            this.moonBox1.Name = "moonBox1";
            this.moonBox1.Size = new System.Drawing.Size(156, 202);
            this.moonBox1.TabIndex = 11;
            this.moonBox1.TabStop = false;
            // 
            // moonPanel1
            // 
            this.moonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.moonPanel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moonPanel1.Location = new System.Drawing.Point(3, -108);
            this.moonPanel1.MoonAge = Dx2Timer.MoonAges.F5N;
            this.moonPanel1.Name = "moonPanel1";
            this.moonPanel1.Size = new System.Drawing.Size(150, 308);
            this.moonPanel1.TabIndex = 12;
            this.moonPanel1.TimerEnabled = false;
            this.moonPanel1.ShowMessage += new Dx2Timer.MoonPanel.MessageEentHandler(this.moonPanel1_ShowMessage);
            this.moonPanel1.MoonAgeChanged += new Dx2Timer.MoonPanel.MoonAgeEventHandler(this.moonPanel1_MoonAgeChanged);
            this.moonPanel1.SecondChanged += new System.EventHandler(this.moonPanel1_SecondChanged);
            // 
            // agesPanel1
            // 
            this.agesPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.agesPanel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.agesPanel1.IsInitialized = false;
            this.agesPanel1.Location = new System.Drawing.Point(3, -108);
            this.agesPanel1.Name = "agesPanel1";
            this.agesPanel1.NextFullMoon = new System.DateTime(((long)(0)));
            this.agesPanel1.Size = new System.Drawing.Size(150, 308);
            this.agesPanel1.TabIndex = 19;
            // 
            // nozuchiPanel1
            // 
            this.nozuchiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.nozuchiPanel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nozuchiPanel1.Location = new System.Drawing.Point(3, -108);
            this.nozuchiPanel1.Name = "nozuchiPanel1";
            this.nozuchiPanel1.Size = new System.Drawing.Size(150, 308);
            this.nozuchiPanel1.TabIndex = 18;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(176, 730);
            this.Controls.Add(this.checkTagNozuchi);
            this.Controls.Add(this.checkBoxTopMost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.moonBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moonPanel1);
            this.Controls.Add(this.agesPanel1);
            this.Controls.Add(this.nozuchiPanel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.contextMenuStripNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private AntiFocusedButton buttonClose;
        private AntiFocusedButton buttonHide;
        private AntiFocusedButton buttonInfo;
        private MoonBox moonBox1;
        private MoonPanel moonPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AntiFocusedCheckBox checkBoxTopMost;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNextFullMoon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpToNextFullMoon;
        private NozuchiPanel nozuchiPanel1;
        private AgesPanel agesPanel1;
        private CheckTag checkTagNozuchi;
    }
}

