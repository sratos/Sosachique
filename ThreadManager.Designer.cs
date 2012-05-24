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
            this.SuspendLayout();
            // 
            // tSave
            // 
            this.tSave.Location = new System.Drawing.Point(367, 122);
            this.tSave.Name = "tSave";
            this.tSave.Size = new System.Drawing.Size(100, 20);
            this.tSave.TabIndex = 0;
            // 
            // tStart
            // 
            this.tStart.Location = new System.Drawing.Point(453, 148);
            this.tStart.Name = "tStart";
            this.tStart.Size = new System.Drawing.Size(75, 23);
            this.tStart.TabIndex = 1;
            this.tStart.Text = "button1";
            this.tStart.UseVisualStyleBackColor = true;
            this.tStart.Click += new System.EventHandler(this.tStart_Click);
            // 
            // ThreadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 271);
            this.Controls.Add(this.tStart);
            this.Controls.Add(this.tSave);
            this.Name = "ThreadManager";
            this.Text = "ThreadManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSave;
        private System.Windows.Forms.Button tStart;
    }
}