using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace _2chReader
{
    public class AXMLDataStorage
    {

        public XmlDocument doc;
        string path;
        string value;

        public bool readFile(string pth)
        {
            doc = new XmlDocument();
            path = pth;
            if (!File.Exists(pth)) writeValue("nul", "0");
            doc.LoadXml(System.IO.File.ReadAllText(pth));

            return true;
        }

        public string readValue(string item)
        {
            value = "";
            XmlNodeList items = doc.GetElementsByTagName("cfg");
            foreach (XmlNode x in items)
            {
                if (x.Attributes[0].Name == item) value = x.Attributes[0].Value.ToString();
            }
            return value;
        }

        public bool writeValue(string item, string value,bool isAppend=false)
        {
            XmlElement newitem = doc.CreateElement("cfg");
            XmlAttribute idattr = doc.CreateAttribute(item);
            idattr.Value = value;
            newitem.SetAttributeNode(idattr);

            if(!isAppend) doc.RemoveAll();
            doc.AppendChild(newitem);
            doc.Save(path);
            return true;
        }


    }
}
