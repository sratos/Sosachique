using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _2chReader
{

    public class c2Thread
    {
        public string op;
        public string oppic;
        public string thread_num;
        public int postcount;
        public bool isClosed=false;
        public string name;
    }

    public static class Lst
    {
        public static List<string> closeList = new List<string>();
    }




}
