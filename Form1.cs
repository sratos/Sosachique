using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Data.SQLite;
using System.IO;

namespace _2chReader
{


    public partial class Form1 : Form
    {
        ANetPage page = new ANetPage();
        bool awaiting = false;
        public string html = "";
        List<string> closedList = new List<string>();

        //List<string> closedList = new List<string>();

        public Form1()
        {

            InitializeComponent();
            ANet.NotifyIcon = this.notifyIcon1;
            this.ShowInTaskbar = false;
            this.Opacity = 0.0f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            regetThreads();
        }

        

        private void dlThread_DoWork(object sender, DoWorkEventArgs e)
        {
            ANetPage pg = new ANetPage();
            pg = ANet.getPage("http://m2-ch.ru/b/");
            e.Result = pg;
        }

        private void dlThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void dlThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == null) return;
            bool skip = false;
            awaiting = true;

            List<c2Thread> ct = new List<c2Thread>();
            page = (ANetPage)e.Result;
            html = page.data;
            ct=ThreadList(html);
            if (ct == null) return; //херня случилась, уходим
            for(int i=0;i<ct.Count;i++)
            {
                if (Program.ex) break;

                for (int j = 0; j < Lst.closeList.Count; j++)
                {
                    if (ct[i].thread_num == Lst.closeList[j].ToString())
                    {
                        skip = true;
                        break;
                    }
                }

                if (!skip && ct[i].postcount>=50 &&  !ANet.Contains(ct[i].name,"Шерлок", StringComparison.OrdinalIgnoreCase))
                {
                    popup pfrm = new popup(ct[i].thread_num, ct[i].op, ct[i].oppic,ct[i].name,ct[i].postcount);
                    pfrm.ShowDialog();

                    /*
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ct[i].thread_num;
                    lvi.SubItems.Add(ct[i].op);
                    lvi.Tag = ct[i];
                    lvThreadList.Items.Add(lvi);
                     * */
                }
               awaiting = false;
            }
        }


        public List<c2Thread> ThreadList(string rawdata)
        {
            List<c2Thread> c2t = new List<c2Thread>();
            string str = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            while(str!=null)
            {
                c2Thread t = new c2Thread();

                str = AStringHelper.ExtractString(rawdata, "<small class=\"op\">", "</small>");
                str2 = AStringHelper.ExtractString(rawdata, "<a class=\"bg\" href=\"b/res/", ".html");
                str3 = AStringHelper.ExtractString(rawdata, "style=\"background-image: url('b/thumb/", "');\">");
                str4 = AStringHelper.ExtractString(rawdata, "[", "]");
                str5 = AStringHelper.ExtractString(rawdata, "<a class=\"oz\" href=\"b/res/" + str2 + ".html\">", "</a>");
                //str = str
                t.thread_num = str2;
                t.op = str;
                t.oppic = str3;
                t.name = str5;
                if (str4 != null)
                {
                    try
                    {
                        t.postcount = Int16.Parse(str4);
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
                else t.postcount = 0;
                rawdata = AStringHelper.ExtractFromString(rawdata, "<small class=\"op\">", "</small>");
                rawdata = AStringHelper.ExtractFromString(rawdata, "<a class=\"bg\" href=\"b/res/", ".html");
                rawdata = AStringHelper.ExtractFromString(rawdata, "style=\"background-image: url('b/thumb/", "');\">");
                rawdata = AStringHelper.ExtractFromString(rawdata, "[", "]");
                if (str == "" || str2 == "" || str3=="" || str4=="") break;
                c2t.Add(t);
            }
            return c2t;
        }

        private void lvThreadList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void regetThreads()
        {
            if (!dlThread.IsBusy && !awaiting) dlThread.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            regetThreads();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
        }

        private void остановитьToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = !остановитьToolStripMenuItem.Checked;
        }

        private void показатьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1.0f;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void звукToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Program.sound = звукToolStripMenuItem.Checked;
        }

        private void обнулитьЗакрытыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lst.closeList.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Program.ex = true;
        }

        private void скачатьТредToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadDL tdl = new ThreadDL();
            tdl.Show();
        }

        private void остановитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void скачатьВсеИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void тредМенеджерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadManager tmfrm = new ThreadManager();
            tmfrm.Show();
        }

    }
}
