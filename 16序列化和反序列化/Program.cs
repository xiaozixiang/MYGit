using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _16序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            /*person p=new person();
            p.Name="肖自翔";
            p.Age=22;
            p.Sex="男";
            //序列化p对象 用于传输数据
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write)) {
                bf.Serialize(fs, p);
            
            }
            Console.WriteLine("序列化成功");
            Console.ReadKey();*/


            //反序列化 用于对方电脑接收对象
            using(FileStream fs=new FileStream(@"C:\Users\Administrator\Desktop\111.txt",FileMode.Open,FileAccess.Read)){
                BinaryFormatter bf=new BinaryFormatter();
               person p=(person) bf.Deserialize(fs);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.Sex);
                Console.ReadKey();
            }
        }
    }

    [Serializable]
    public class person {

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private String _sex;

        public String Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
