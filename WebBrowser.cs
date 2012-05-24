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
    public partial class WebBrowser : Form
    {
        string url;
        string thread_num;
        public WebBrowser(string u, string thread)
        {
            thread_num = thread;
            url = u;
            InitializeComponent();

        }

        bool playOnce;
        private void WebBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://roll.io/");
            webBrowser1.ScriptErrorsSuppressed = true;
            playOnce = false;

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


            if (webBrowser1.Url.ToString().Contains("http://roll.io/") && !playOnce)
            {
                playOnce = true;
                string rr = YT.video.getVideoList(thread_num);
                try
                {
                    HtmlElement textArea = webBrowser1.Document.All["instant_list"];
                    if (textArea != null)
                    {
                        textArea.InnerText = rr;
                    }

                    webBrowser1.Document.GetElementById("submit_instant_list").InvokeMember("click");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
