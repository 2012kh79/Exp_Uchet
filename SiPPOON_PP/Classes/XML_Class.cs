using System;
using System.Xml;
using System.IO;
using System.Text;

namespace SiPPOON_PP.Classes
{
    class XML_Class
    {
        public void XML_Write(string Path_File, string Path_Folder)
        {
            if (!File.Exists("Настройки.xml"))
            {
                XmlTextWriter textWritter = new XmlTextWriter("Настройки.xml", Encoding.UTF8);
                textWritter.WriteStartDocument();
                textWritter.WriteStartElement("Settings");
                textWritter.WriteEndElement();
                textWritter.Close();
            }
                XmlDocument doc = new XmlDocument();
                doc.Load("Настройки.xml");
                Console.WriteLine(new string('-', 40));
                XmlElement xRoot = doc.DocumentElement;
                XmlElement userElem = doc.CreateElement("Result_Issledovaniya");
                XmlElement el1 = doc.CreateElement("Path_File");
                XmlElement el2 = doc.CreateElement("Path_Folder");
                XmlText el1Text = doc.CreateTextNode(Path_File.ToString());
                XmlText el2Text = doc.CreateTextNode(Path_Folder.ToString());
                el1.AppendChild(el1Text);
                userElem.AppendChild(el1);
                el2.AppendChild(el2Text);
                userElem.AppendChild(el2);
                xRoot.AppendChild(userElem);
                doc.Save("Настройки.xml");
        }
    }
}
