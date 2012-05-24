using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2chReader;
namespace YT
{
    public static class video
    {
        public static string getVideoList(string s)
        {

            ANetPage pg = new ANetPage();
            pg = ANet.getPage("http://m2-ch.ru/b/res/" + s + ".html");


            string str = "";
            string raw = "";
            string rawdata = pg.data;
            while (str != null || str=="")
            {
                str = AStringHelper.ExtractString(rawdata, "http://youtu.be/", "\"><div class=\"thumb video");
                if (str == null) return raw;
                raw = raw  + "http://www.youtube.com/watch?v=" + str + "\n";

                rawdata = AStringHelper.ExtractFromString(rawdata, "http://youtu.be/", "\"><div class=\"thumb video");
            }
            return raw;
            //MessageBox.Show(raw);
        }
    }




}
