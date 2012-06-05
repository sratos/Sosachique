namespace _2chReader
{
    partial class ThreadListen
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
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.tLink = new System.Windows.Forms.TextBox();
            this.tSpeak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Адрес негожего треда:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(319, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(573, 287);
            this.webBrowser1.TabIndex = 10;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Открыть тред";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tLink
            // 
            this.tLink.Location = new System.Drawing.Point(12, 33);
            this.tLink.Name = "tLink";
            this.tLink.Size = new System.Drawing.Size(234, 20);
            this.tLink.TabIndex = 8;
            // 
            // tSpeak
            // 
            this.tSpeak.Location = new System.Drawing.Point(68, 100);
            this.tSpeak.Multiline = true;
            this.tSpeak.Name = "tSpeak";
            this.tSpeak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tSpeak.Size = new System.Drawing.Size(245, 114);
            this.tSpeak.TabIndex = 12;
            // 
            // ThreadListen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 321);
            this.Controls.Add(this.tSpeak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tLink);
            this.Name = "ThreadListen";
            this.Text = "ThreadListen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tLink;
        private System.Windows.Forms.TextBox tSpeak;
    }
}