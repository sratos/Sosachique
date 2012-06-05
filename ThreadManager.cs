using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2chReader
{
    public partial class ThreadManager : Form
    {
        public ThreadManager()
        {
            InitializeComponent();
        }

        private void tStart_Click(object sender, EventArgs e)
        {

            Thread2 t2 = new Thread2();
            t2.downloadThread(tSave.Text, isSource.Checked, false,"b");
        }

        private void tSaveBoard_Click(object sender, EventArgs e)
        {
            ANetPage pg = new ANetPage();
            string threadCount=" ";
            pg = ANet.getPage("http://m2-ch.ru/" + tRas.Text + "/");
            string pageText = pg.data;
            pageText = AStringHelper.ExtractString(pageText, "<div class=\"fl_l thread\">", "class=\"bmenu\">");
            string allpages="";
            string lastGoodThreadCount="";
            while (pageText != null)
            {
                threadCount = AStringHelper.ExtractString(pageText, tRas.Text + "/", ".html");
                pageText = AStringHelper.ExtractFromString(pageText, tRas.Text + "/", ".html");
                if(threadCount!=null)lastGoodThreadCount = threadCount;
            }
            for (int i = 0; i < Int16.Parse(lastGoodThreadCount); i++)
            {
                pg = ANet.getPage("http://m2-ch.ru/" + tRas.Text + "/" + i + ".html");
                allpages += pg.data;
            }
            List<string> ll = new List<string>();

            while (allpages != null)
            {
                threadCount = AStringHelper.ExtractString(allpages, "\"z\" href=\"", "#end\">");
                allpages = AStringHelper.ExtractFromString(allpages, "\"z\" href=\"", "#end\">");
                ll.Add("http://2ch.so/" + threadCount);
            }


            Thread2 t2 = new Thread2();

            for (int i = 0; i < ll.Count(); i++)
            {
                ll[i].ToString();
                t2.downloadThread(ll[i].ToString(), true, false,tRas.Text);
            }

        }
    }
}
