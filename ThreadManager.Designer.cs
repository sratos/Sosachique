namespace _2chReader
{
    partial class ThreadManager
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
            this.tSave = new System.Windows.Forms.TextBox();
            this.tStart = new System.Windows.Forms.Button();
            this.tBoard = new System.Windows.Forms.TextBox();
            this.tSaveBoard = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.tRas = new System.Windows.Forms.TextBox();
            this.isSource = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tSave
            // 
            this.tSave.Location = new System.Drawing.Point(156, 31);
            this.tSave.Name = "tSave";
            this.tSave.Size = new System.Drawing.Size(269, 20);
            this.tSave.TabIndex = 0;
            // 
            // tStart
            // 
            this.tStart.Location = new System.Drawing.Point(431, 28);
            this.tStart.Name = "tStart";
            this.tStart.Size = new System.Drawing.Size(107, 23);
            this.tStart.TabIndex = 1;
            this.tStart.Text = "Архивнуть тред";
            this.tStart.UseVisualStyleBackColor = true;
            this.tStart.Click += new System.EventHandler(this.tStart_Click);
            // 
            // tBoard
            // 
            this.tBoard.Location = new System.Drawing.Point(21, 116);
            this.tBoard.Name = "tBoard";
            this.tBoard.Size = new System.Drawing.Size(240, 20);
            this.tBoard.TabIndex = 0;
            // 
            // tSaveBoard
            // 
            this.tSaveBoard.Location = new System.Drawing.Point(366, 116);
            this.tSaveBoard.Name = "tSaveBoard";
            this.tSaveBoard.Size = new System.Drawing.Size(124, 23);
            this.tSaveBoard.TabIndex = 1;
            this.tSaveBoard.Text = "Слить весь раздел";
            this.tSaveBoard.UseVisualStyleBackColor = true;
            this.tSaveBoard.Click += new System.EventHandler(this.tSaveBoard_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 154);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(502, 156);
            this.resultBox.TabIndex = 2;
            // 
            // tRas
            // 
            this.tRas.Location = new System.Drawing.Point(267, 116);
            this.tRas.Name = "tRas";
            this.tRas.Size = new System.Drawing.Size(64, 20);
            this.tRas.TabIndex = 3;
            this.tRas.Text = "b";
            // 
            // isSource
            // 
            this.isSource.AutoSize = true;
            this.isSource.Location = new System.Drawing.Point(21, 35);
            this.isSource.Name = "isSource";
            this.isSource.Size = new System.Drawing.Size(129, 17);
            this.isSource.TabIndex = 4;
            this.isSource.Text = "Сорс картинок тоже";
            this.isSource.UseVisualStyleBackColor = true;
            // 
            // ThreadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 334);
            this.Controls.Add(this.isSource);
            this.Controls.Add(this.tRas);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.tSaveBoard);
            this.Controls.Add(this.tStart);
            this.Controls.Add(this.tBoard);
            this.Controls.Add(this.tSave);
            this.Name = "ThreadManager";
            this.Text = "ThreadManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSave;
        private System.Windows.Forms.Button tStart;
        private System.Windows.Forms.TextBox tBoard;
        private System.Windows.Forms.Button tSaveBoard;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox tRas;
        private System.Windows.Forms.CheckBox isSource;
    }
}