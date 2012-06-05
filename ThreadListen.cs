using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace _2chReader
{
    public partial class ThreadListen : Form
    {
        public ThreadListen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> strs = new List<string>();
            string procstr;
            if(Media.Player.GetPlayer().IsOpen())Media.Player.GetPlayer().Close();
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1.5) Gecko/20091102 Firefox/3.5.5");
            int count;
            count = 1;
            while (tSpeak.Text.Count() != 0)
            {
                    try
                    {
                        procstr = tSpeak.Text.Substring(0, 90);
                    }
                    catch (Exception ex)
                    {
                        procstr = tSpeak.Text.Substring(0, tSpeak.Text.Count());

                    }

                    if (procstr == "")
                    {
                        count--;
                        break;
                    }

                    try
                    {
                        tSpeak.Text = tSpeak.Text.Substring(90);
                    }
                    catch (Exception ex)
                    {
                        tSpeak.Text = tSpeak.Text.Substring(tSpeak.Text.Count());

                    }


                    webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1.5) Gecko/20091102 Firefox/3.5.5");
                    webClient.DownloadFile("http://translate.google.com/translate_tts?q=" + procstr + "&tl=ru", "speak" + count.ToString() + ".mp3");
                    count++;

                }
            int i = 0;
                while (i <= count)
                {
                    if (!Media.Player.GetPlayer().IsOpen())
                    {
                        i++;
                        if (Program.sound) Media.Player.GetPlayer().Play("speak" + i.ToString() + ".mp3");
                    }

                    if (!Media.Player.GetPlayer().IsPlaying())
                        Media.Player.GetPlayer().Close();
                }

           // webBrowser1.Navigate(tLink.Text);
            //webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            /*
            try
            {
                HtmlElement textArea = webBrowser1.Document.All["shampoo"];
                if (textArea != null)
                {
                    textArea.InnerText = "ded";
                }
                webBrowser1.Document.GetElementById("captcha").InvokeMember("click");
                //webBrowser1.Document.GetElementById("submit_instant_list").InvokeMember("click");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
             * */
        }
    }
}
