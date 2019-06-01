using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11demo
{
    class Person
    {


        public Person(String name,String password) {
            this.Name = name;
            this.Password = password;
        }

        public Person() { 
        
        }
        //垃圾自动回收
        ~Person() {
            Console.WriteLine("我是析构函数！");
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _name;

        public String Name  
        {
            get { return _name; }
            set { _name = value; }
        }
        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
    }
}
