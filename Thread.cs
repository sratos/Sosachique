using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System.Net;
using Ionic.Zip;

namespace _2chReader
{
    public class Thread2
    {
        string num;//номер треда
        List<Post> posts = new List<Post>();//список постов
        string threadname; //данное название треда
        string cat; //категория

        public Image DownloadImage(string _URL)
        {
            Image _tmpImage = null;

            try
            {
                // Open a connection
                System.Net.HttpWebRequest _HttpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_URL);

                _HttpWebRequest.AllowWriteStreamBuffering = true;

                // You can also specify additional header values like the user agent or the referer: (Optional)
                _HttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                _HttpWebRequest.Referer = "http://www.google.com/";

                // set timeout for 20 seconds (Optional)
                _HttpWebRequest.Timeout = 20000;

                // Request response:
                System.Net.WebResponse _WebResponse = _HttpWebRequest.GetResponse();

                // Open data stream:
                System.IO.Stream _WebStream = _WebResponse.GetResponseStream();

                // convert webstream to image
                _tmpImage = Image.FromStream(_WebStream);

                // Cleanup
                _WebResponse.Close();
                _WebResponse.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
                return null;
            }

            return _tmpImage;
        }


        public string raw;
        public int counter;
        public ANetPage page;
        public bool downloadThread(string link, bool dlPics, bool isControled)
        {
            WebClient webClient = new WebClient();


            string lnk = " ";
            string lnk2 = " ";
            int downloaded;
            downloaded = 0;

            ZipFile zip = new ZipFile();
            page = new ANetPage();
            page = ANet.getPage(link);
            raw = page.data;
            string nm = "";
            string tmp;
            string lraw = raw;
            lraw = lraw.Replace("/b/src/", "");
            lraw = lraw.Replace("/b/thumb/", "");
            lraw = lraw.Replace("/test/js/", "");
            lraw = lraw.Replace("href=\"/b/res/", "href=\"");

            File.WriteAllText("./archive/" + link.Replace("http://2ch.so/b/res/", ""), lraw);
            zip.AddFile("./archive/" + link.Replace("http://2ch.so/b/res/", ""), ".");

            while (lnk != null)
            {
                try
                {
                    if (dlPics)
                    {
                        lnk = AStringHelper.ExtractString(raw, "<a target=\"_blank\" href=\"", "\">");
                        tmp = "<a target=\"_blank\" href=\"" + lnk + "\">";
                        raw = raw.Replace(tmp, "");
                        nm = lnk.Replace("/b/src/", "");
                        webClient.DownloadFile("http://2ch.so" + lnk, "./archive/" + nm);
                        zip.AddFile("./archive/" + nm, ".");
                    }

                    lnk = AStringHelper.ExtractString(raw, "<img src=\"/b/thumb/", "\"");
                    tmp = "<img src=\"/b/thumb/" + lnk + "\"";
                    raw = raw.Replace(tmp, "");
                    nm = lnk.Replace("/b/src/", "");
                    webClient.DownloadFile("http://2ch.so/b/thumb/" + lnk, "./archive/" + nm);
                    zip.AddFile("./archive/" + nm,".");
                    downloaded++;

                    lnk2 = AStringHelper.ExtractString(raw, "<link href=\"/test/js/", "\" type=\"text/css\" rel=\"stylesheet\"");
                    tmp = "<link href=\"/test/js/" + lnk2 + "\" type=\"text/css\" rel=\"stylesheet\"";
                    raw = raw.Replace(tmp, "");
                    if (lnk2 != null)
                    {
                        webClient.DownloadFile("http://2ch.so/test/js/" + lnk2, "./archive/" + lnk2);
                        zip.AddFile("./archive/" + lnk2, ".");
                    }
                }
                    
                catch (Exception xx)
                {
                    string ll = link.Replace("http://2ch.so/b/res/", "");
                    ll = ll.Replace(".html", "");
                    ll += ".zip";
                    zip.Save("./thread_archive/" + ll);
                    Directory.Delete("./archive/", true);
                    Directory.CreateDirectory("./archive/");
                    return false;
                }


            }

            return true;
        }

        public bool updateThread()
        {
            return true;
        }


        public bool runAutoUpdate()
        {
            return true;
        }

        public bool getPostCount()
        {
            return true;
        }

        public bool isThreadDied()
        {
            return true;
        }

        public bool getPosts()
        {
            return true;
        }

        public bool saveThread()
        {
            return true;
        }
    }
}
