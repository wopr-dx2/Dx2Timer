namespace Dx2Timer
{
    partial class NozuchiPanel
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxResist = new System.Windows.Forms.PictureBox();
            this.pictureBoxRare = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxBinded = new System.Windows.Forms.PictureBox();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(131)))), ((int)(((byte)(169)))));
            this.labelTitle.Location = new System.Drawing.Point(33, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 27);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "ノズチ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("メイリオ", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "©SEGA\r\n©ATLUS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBoxResist
            // 
            this.pictureBoxResist.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxResist.BackgroundImage = global::Dx2Timer.Properties.Resources.resist_nozuchi;
            this.pictureBoxResist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxResist.Location = new System.Drawing.Point(15, 181);
            this.pictureBoxResist.Name = "pictureBoxResist";
            this.pictureBoxResist.Size = new System.Drawing.Size(120, 88);
            this.pictureBoxResist.TabIndex = 25;
            this.pictureBoxResist.TabStop = false;
            // 
            // pictureBoxRare
            // 
            this.pictureBoxRare.BackgroundImage = global::Dx2Timer.Properties.Resources.nozuchi_rare;
            this.pictureBoxRare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRare.Location = new System.Drawing.Point(20, 74);
            this.pictureBoxRare.Name = "pictureBoxRare";
            this.pictureBoxRare.Size = new System.Drawing.Size(110, 128);
            this.pictureBoxRare.TabIndex = 28;
            this.pictureBoxRare.TabStop = false;
            this.pictureBoxRare.Visible = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BackgroundImage = global::Dx2Timer.Properties.Resources.nozuchi_komugiko;
            this.pictureBoxResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxResult.Location = new System.Drawing.Point(20, 74);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(110, 128);
            this.pictureBoxResult.TabIndex = 26;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Visible = false;
            // 
            // pictureBoxBinded
            // 
            this.pictureBoxBinded.BackgroundImage = global::Dx2Timer.Properties.Resources.nozuchi_binded;
            this.pictureBoxBinded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBinded.Location = new System.Drawing.Point(20, 74);
            this.pictureBoxBinded.Name = "pictureBoxBinded";
            this.pictureBoxBinded.Size = new System.Drawing.Size(110, 128);
            this.pictureBoxBinded.TabIndex = 14;
            this.pictureBoxBinded.TabStop = false;
            this.pictureBoxBinded.Visible = false;
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.BackgroundImage = global::Dx2Timer.Properties.Resources.nozuchi_normal;
            this.pictureBoxNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNormal.Location = new System.Drawing.Point(20, 74);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(110, 128);
            this.pictureBoxNormal.TabIndex = 13;
            this.pictureBoxNormal.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Dx2Timer.Properties.Resources.shibaboo;
            this.button1.Location = new System.Drawing.Point(65, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 81);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NozuchiPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(58)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxResist);
            this.Controls.Add(this.pictureBoxRare);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxBinded);
            this.Controls.Add(this.pictureBoxNormal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "NozuchiPanel";
            this.Size = new System.Drawing.Size(150, 308);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxResist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBinded;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxRare;
    }
}
