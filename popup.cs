using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Data.SQLite;
using System.IO;
    
namespace _2chReader
{
    public partial class popup : Form
    {

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
                _HttpWebRequest.Referer = "about:blank";

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
                _WebStream.Close();
            }
            catch (Exception _Exception)
            {
                // Error
                Console.WriteLine("Exception caught in process: {0}", _Exception.ToString());
                return null;
            }

            return _tmpImage;
        }


        public popup()
        {
            InitializeComponent();
        }

        string thread_num, thread_body, thread_img,thread_name;
        int thread_count;

        public popup(string num, string body, string image, string name, int postcount)
        {
            thread_num = num;
            thread_body = body;
            thread_img = image;
            thread_name = name;
            thread_count = postcount;

            InitializeComponent();


        }

        public void move()
        {

            while (this.Top > Screen.PrimaryScreen.Bounds.Height-170)
            {
                this.Refresh();
                this.Top=this.Top-10;
                Thread.Sleep(1);
            }
        }

        private void popup_Load(object sender, EventArgs e)
        {
            lThread.Text = thread_name;
            lCount.Text = thread_count.ToString();
            label1.Text = thread_body;
            label1.Text=label1.Text.Replace("<br />", "");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

                
        }

        private void popup_Shown(object sender, EventArgs e)
        {
            Point p = new Point(Screen.PrimaryScreen.Bounds.Width - 350, Screen.PrimaryScreen.Bounds.Height);
            this.Location = p;
            this.Opacity = 1;
            move();
            if (Program.sound) Media.Player.GetPlayer().Play("notify.mp3");
            threadImg.Image = DownloadImage("http://2ch.so/b/thumb/" + thread_img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Lst.closeList.Add(thread_num);
            this.Close();
        }

        private void threadImg_Click(object sender, EventArgs e)
        {
        }

        private void lCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            }
        }

        private void threadImg_MouseClick(object sender, MouseEventArgs e)
        {

                Process.Start("http://2ch.so/b/res/" + thread_num + ".html");
                // WebBrowser wb = new WebBrowser("http://2ch.so/b/res/" +thread_num + ".html");
                // wb.Show();
        }

        private void popup_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void закрытьТредToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lst.closeList.Add(thread_num);
            this.Close();
        }

        private void какПлейлистYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser("",thread_num);
            wb.Show();
        }

        private void схоронитьТредToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread2 t2 = new Thread2();
            t2.downloadThread("http://2ch.so/b/res/" + thread_num + ".html", false, false);
        }

        private void схоронитьТредСПодливойToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Thread2 t2 = new Thread2();
            t2.downloadThread("http://2ch.so/b/res/" + thread_num + ".html", true, false);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }





        
    }
}
