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
    public partial class ThreadWipe : Form
    {
        List<string> proxyList = new List<string>();
        public ThreadWipe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tLink.Text);
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                try
                {
                    HtmlElement textArea = webBrowser1.Document.All["shampoo"];
                    if (textArea != null)
                    {
                        textArea.InnerText = wipeText.Text;
                    }
                    webBrowser1.Document.GetElementById("captcha").InvokeMember("click");
                    //webBrowser1.Document.GetElementById("submit_instant_list").InvokeMember("click");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }
    }
}
