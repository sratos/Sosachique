using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Timers;

namespace _2chReader
{
    public static class ANet
    {
        public static System.Windows.Forms.NotifyIcon NotifyIcon;


        public static void balloonTip( string header, string text)
        {
            NotifyIcon.BalloonTipText = text;
            NotifyIcon.BalloonTipTitle = header;
            //NotifyIcon.Icon = 
            NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(3);
        }

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        //if returned null then there was an error
        public static ANetPage getPage(string str)
        {
            ANetPage anpage;

            anpage = new ANetPage();
            anpage.path = str;

            HttpWebRequest myRequest;
            myRequest = (HttpWebRequest)WebRequest.Create(str);

            myRequest.Method = "GET";
            myRequest.Timeout = 5000;

          // balloonTip("Thread list", "Download started");
           // try
          //  {
                using (WebResponse myResponse = myRequest.GetResponse())
                {
                    StreamReader sr = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                    anpage.data = sr.ReadToEnd();
                    sr.Close();
                    myResponse.Close();
                }

          //  }
            /*
            catch (Exception e)
            {
                balloonTip("Ошибка", e.Message.ToString());
                anpage.error = e.Message.ToString();
                return null;
            }
             * */

            return anpage;
        }

    }
}
