namespace _2chReader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvThreadList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.остановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьТредToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обнулитьЗакрытыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlThread = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.тредМенеджерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvThreadList
            // 
            this.lvThreadList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvThreadList.ContextMenuStrip = this.contextMenuStrip1;
            this.lvThreadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThreadList.GridLines = true;
            this.lvThreadList.Location = new System.Drawing.Point(0, 0);
            this.lvThreadList.Name = "lvThreadList";
            this.lvThreadList.Size = new System.Drawing.Size(795, 333);
            this.lvThreadList.TabIndex = 0;
            this.lvThreadList.UseCompatibleStateImageBehavior = false;
            this.lvThreadList.View = System.Windows.Forms.View.Details;
            this.lvThreadList.SelectedIndexChanged += new System.EventHandler(this.lvThreadList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 54;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Оп-пост";
            this.columnHeader2.Width = 305;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.остановитьToolStripMenuItem,
            this.звукToolStripMenuItem,
            this.скачатьТредToolStripMenuItem,
            this.тредМенеджерToolStripMenuItem,
            this.обнулитьЗакрытыеToolStripMenuItem,
            this.показатьОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 180);
            // 
            // остановитьToolStripMenuItem
            // 
            this.остановитьToolStripMenuItem.CheckOnClick = true;
            this.остановитьToolStripMenuItem.Name = "остановитьToolStripMenuItem";
            this.остановитьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.остановитьToolStripMenuItem.Text = "Остановить";
            this.остановитьToolStripMenuItem.CheckedChanged += new System.EventHandler(this.остановитьToolStripMenuItem_CheckedChanged);
            this.остановитьToolStripMenuItem.Click += new System.EventHandler(this.остановитьToolStripMenuItem_Click);
            // 
            // звукToolStripMenuItem
            // 
            this.звукToolStripMenuItem.Checked = true;
            this.звукToolStripMenuItem.CheckOnClick = true;
            this.звукToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.звукToolStripMenuItem.Name = "звукToolStripMenuItem";
            this.звукToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.звукToolStripMenuItem.Text = "Звук";
            this.звукToolStripMenuItem.CheckedChanged += new System.EventHandler(this.звукToolStripMenuItem_CheckedChanged);
            // 
            // скачатьТредToolStripMenuItem
            // 
            this.скачатьТредToolStripMenuItem.Name = "скачатьТредToolStripMenuItem";
            this.скачатьТредToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.скачатьТредToolStripMenuItem.Text = "Скачать тред";
            this.скачатьТредToolStripMenuItem.Click += new System.EventHandler(this.скачатьТредToolStripMenuItem_Click);
            // 
            // обнулитьЗакрытыеToolStripMenuItem
            // 
            this.обнулитьЗакрытыеToolStripMenuItem.Name = "обнулитьЗакрытыеToolStripMenuItem";
            this.обнулитьЗакрытыеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.обнулитьЗакрытыеToolStripMenuItem.Text = "Обнулить закрытые";
            this.обнулитьЗакрытыеToolStripMenuItem.Click += new System.EventHandler(this.обнулитьЗакрытыеToolStripMenuItem_Click);
            // 
            // показатьОкноToolStripMenuItem
            // 
            this.показатьОкноToolStripMenuItem.Name = "показатьОкноToolStripMenuItem";
            this.показатьОкноToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.показатьОкноToolStripMenuItem.Text = "Показать окно";
            this.показатьОкноToolStripMenuItem.Click += new System.EventHandler(this.показатьОкноToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dlThread
            // 
            this.dlThread.WorkerReportsProgress = true;
            this.dlThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dlThread_DoWork);
            this.dlThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.dlThread_ProgressChanged);
            this.dlThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dlThread_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "M2Ch Reader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // тредМенеджерToolStripMenuItem
            // 
            this.тредМенеджерToolStripMenuItem.Name = "тредМенеджерToolStripMenuItem";
            this.тредМенеджерToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.тредМенеджерToolStripMenuItem.Text = "ТредМенеджер...";
            this.тредМенеджерToolStripMenuItem.Click += new System.EventHandler(this.тредМенеджерToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 333);
            this.Controls.Add(this.lvThreadList);
            this.Name = "Form1";
            this.Text = "Тредлист";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThreadList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.ComponentModel.BackgroundWorker dlThread;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обнулитьЗакрытыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скачатьТредToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тредМенеджерToolStripMenuItem;
    }
}

