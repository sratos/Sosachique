using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace _2chReader
{
    public partial class ThreadDL : Form
    {
        public string raw;
        public int counter;
        public ANetPage page;
        public ThreadDL()
        {
            InitializeComponent();
        }
        int countOccurences(string needle, string haystack)
        {
            return (haystack.Length - haystack.Replace(needle, "").Length) / needle.Length;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(tSave.Text))
                {
                    DirectoryInfo di = Directory.CreateDirectory(tSave.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удается создать директорию.\nОшибка:" + ex.Message.ToString(), "Sosachique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tSave.Text.Substring(tSave.Text.Length - 1) != "\\") tSave.Text += "\\";
            page = new ANetPage();
            page = ANet.getPage(tLink.Text);
            raw = page.data;
            string target = "<a target=\"_blank\" href=\"";
            counter = countOccurences(target, raw);
            progressBar1.Maximum = counter;
            button1.Enabled = false;
            tSave.Enabled = false;
            tLink.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void ThreadDL_Load(object sender, EventArgs e)
        {
            counter = 0;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string lnk = "";
            int downloaded;
            downloaded = 0;
            while (lnk != null)
            {
                try
                {
                    lnk = AStringHelper.ExtractString(raw, "<a target=\"_blank\" href=\"", "\">");
                    string tmp = "<a target=\"_blank\" href=\"" + lnk + "\">";
                    raw = raw.Replace(tmp, "");
                    string nm = "";
                    nm = lnk.Replace("/b/src/", "");
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("http://2ch.so" + lnk, tSave.Text + nm);
                    //links.Add("http://2ch.so" + lnk);
                    downloaded++;
                    backgroundWorker1.ReportProgress(downloaded);
                }
                catch(Exception xx)
                {
                    return;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            this.Text = "Закачка треда - " + progressBar1.Maximum + "\\" + progressBar1.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Enabled = true;
            tSave.Enabled = true;
            tLink.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tSave.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tLink_TextChanged(object sender, EventArgs e)
        {
            if (tLink.Text != "") button1.Enabled = true;
            else button1.Enabled = false;
        }
    }
}
