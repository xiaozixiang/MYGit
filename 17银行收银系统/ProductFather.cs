using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class ProductFather
    {
        public double Price
        {
            set;
            get;
        }
        public String ID
        {
            set;
            get;
        }
        public double Count
        {
            set;
            get;
        }
        public String Name
        {
            set;
            get;
        }
        public ProductFather(String id,String name,double price){
            this.Name = name;
            this.ID=id;
            this.Price=price;
        }
    }
}
