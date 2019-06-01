using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace _35创建XML
{
    class Program
    {
        static void Main(){
           XmlDocument doc = new XmlDocument();
           XmlDeclaration des=doc.CreateXmlDeclaration("1.0","utf-8",null);
           XmlElement Books = doc.CreateElement("Books");

           XmlElement book1 = doc.CreateElement("Book");
           Books.AppendChild(book1);

           XmlElement name1 = doc.CreateElement("Name");
           name1.SetAttribute("count", "2");
           name1.InnerText = "水浒传";
           book1.AppendChild(name1);

           XmlElement price1 = doc.CreateElement("Price");
           price1.InnerText = "20";
           book1.AppendChild(price1);

           XmlElement des1 = doc.CreateElement("Des");
           des1.SetAttribute("Name", "水浒传");
           des1.InnerText = "好看";
           book1.AppendChild(des1);

            
           doc.AppendChild(des);
           doc.AppendChild(Books);

           doc.Save("Books.xml");
           Console.WriteLine("保存成功");
           Console.ReadKey();

           /*//向XML文件追加内容

           if (File.Exists("Books.xml"))
           {
               doc.Load("Bookx.xml");
               XmlElement elements = doc.DocumentElement;

           }*/





            //读取Xml文件
           doc.Load("Books.xml");
           XmlElement roots = doc.DocumentElement;
           XmlNodeList childelement=roots.ChildNodes;
           foreach (XmlNode item in childelement)
           {
               Console.WriteLine(item.InnerText);
           }
           Console.ReadKey();
        }
    }
}
