namespace _2chReader
{
    partial class popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скачатьВсеИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собратьВсеПостыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.схоронитьТредToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.схоронитьТредСПодливойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьТредToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какПлейлистYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadImg = new System.Windows.Forms.PictureBox();
            this.lThread = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.слушатьТредToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ContextMenuStrip = this.contextMenuStrip2;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "000000000000000000000000\r\n000000000000000000000000\r\n000000000000000000000000\r\n000" +
    "000000000000000000000\r\n000000000000000000000000\r\n000000000000000000000000\r\n00000" +
    "0000000000000000000\r\n";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скачатьВсеИзображенияToolStripMenuItem,
            this.собратьВсеПостыToolStripMenuItem,
            this.схоронитьТредToolStripMenuItem,
            this.схоронитьТредСПодливойToolStripMenuItem,
            this.закрытьТредToolStripMenuItem,
            this.какПлейлистYouTubeToolStripMenuItem,
            this.слушатьТредToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(227, 180);
            // 
            // скачатьВсеИзображенияToolStripMenuItem
            // 
            this.скачатьВсеИзображенияToolStripMenuItem.Name = "скачатьВсеИзображенияToolStripMenuItem";
            this.скачатьВсеИзображенияToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.скачатьВсеИзображенияToolStripMenuItem.Text = "Скачать все изображения...";
            // 
            // собратьВсеПостыToolStripMenuItem
            // 
            this.собратьВсеПостыToolStripMenuItem.Name = "собратьВсеПостыToolStripMenuItem";
            this.собратьВсеПостыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.собратьВсеПостыToolStripMenuItem.Text = "Собрать все посты...";
            // 
            // схоронитьТредToolStripMenuItem
            // 
            this.схоронитьТредToolStripMenuItem.Name = "схоронитьТредToolStripMenuItem";
            this.схоронитьТредToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.схоронитьТредToolStripMenuItem.Text = "Схоронить тред в архив...";
            this.схоронитьТредToolStripMenuItem.Click += new System.EventHandler(this.схоронитьТредToolStripMenuItem_Click);
            // 
            // схоронитьТредСПодливойToolStripMenuItem
            // 
            this.схоронитьТредСПодливойToolStripMenuItem.Name = "схоронитьТредСПодливойToolStripMenuItem";
            this.схоронитьТредСПодливойToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.схоронитьТредСПодливойToolStripMenuItem.Text = "Схоронить тред с подливой";
            this.схоронитьТредСПодливойToolStripMenuItem.Click += new System.EventHandler(this.схоронитьТредСПодливойToolStripMenuItem_Click);
            // 
            // закрытьТредToolStripMenuItem
            // 
            this.закрытьТредToolStripMenuItem.Name = "закрытьТредToolStripMenuItem";
            this.закрытьТредToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.закрытьТредToolStripMenuItem.Text = "Закрыть тред";
            this.закрытьТредToolStripMenuItem.Click += new System.EventHandler(this.закрытьТредToolStripMenuItem_Click);
            // 
            // какПлейлистYouTubeToolStripMenuItem
            // 
            this.какПлейлистYouTubeToolStripMenuItem.Name = "какПлейлистYouTubeToolStripMenuItem";
            this.какПлейлистYouTubeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.какПлейлистYouTubeToolStripMenuItem.Text = "Как плейлист YouTube";
            this.какПлейлистYouTubeToolStripMenuItem.Click += new System.EventHandler(this.какПлейлистYouTubeToolStripMenuItem_Click);
            // 
            // threadImg
            // 
            this.threadImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.threadImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threadImg.ContextMenuStrip = this.contextMenuStrip2;
            this.threadImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threadImg.Location = new System.Drawing.Point(2, 13);
            this.threadImg.Name = "threadImg";
            this.threadImg.Size = new System.Drawing.Size(78, 48);
            this.threadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threadImg.TabIndex = 1;
            this.threadImg.TabStop = false;
            this.threadImg.Click += new System.EventHandler(this.threadImg_Click);
            this.threadImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.threadImg_MouseClick);
            // 
            // lThread
            // 
            this.lThread.AutoSize = true;
            this.lThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lThread.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lThread.ForeColor = System.Drawing.Color.White;
            this.lThread.Location = new System.Drawing.Point(-1, 1);
            this.lThread.Name = "lThread";
            this.lThread.Size = new System.Drawing.Size(200, 11);
            this.lThread.TabIndex = 5;
            this.lThread.Text = "Thread Thread Thread Thread Thread ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2chReader.Properties.Resources.c12;
            this.pictureBox1.Location = new System.Drawing.Point(234, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lCount.ForeColor = System.Drawing.Color.White;
            this.lCount.Location = new System.Drawing.Point(203, 1);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(13, 13);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "0";
            this.lCount.Click += new System.EventHandler(this.lCount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 64);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // слушатьТредToolStripMenuItem
            // 
            this.слушатьТредToolStripMenuItem.Name = "слушатьТредToolStripMenuItem";
            this.слушатьТредToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.слушатьТредToolStripMenuItem.Text = "Слушать тред...";
            this.слушатьТредToolStripMenuItem.Click += new System.EventHandler(this.слушатьТредToolStripMenuItem_Click);
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(248, 64);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lThread);
            this.Controls.Add(this.threadImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "popup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.popup_Load);
            this.Shown += new System.EventHandler(this.popup_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.threadImg_MouseClick);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.threadImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox threadImg;
        private System.Windows.Forms.Label lThread;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem скачатьВсеИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собратьВсеПостыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem схоронитьТредToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьТредToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какПлейлистYouTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem схоронитьТредСПодливойToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem слушатьТредToolStripMenuItem;
    }
}