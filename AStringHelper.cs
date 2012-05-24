using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2chReader
{
    public static class AStringHelper
    {
        public static string ExtractString(string s, string startTag, string endTag, bool isNone = false)
        {
            if (s == "" || s==null) return null;
            int endIndex;
            int startIndex = s.IndexOf(startTag) + startTag.Length;

            if (!isNone)
                endIndex = s.IndexOf(endTag, startIndex);
            else
                endIndex = s.Count();
            if (endIndex == -1) return null;
            else return s.Substring(startIndex, endIndex - startIndex);

        }

        public static string ExtractFromString(string s, string startTag, string endTag)
        {
            string reslt;
            if (s == "" || s == null) return null;
            int endIndex;
            int startIndex = s.IndexOf(startTag) - startTag.Length;
            if (startIndex < 0) return "";
            endIndex = s.IndexOf(endTag, startIndex);
            endIndex = endIndex + endTag.Length;

            if (endIndex == -1) return null;
            else
            {
                reslt = s.Substring(0, startIndex);
                reslt = reslt + s.Substring(endIndex, s.Length - endIndex);
                return reslt;
            }

        }
    }
}
