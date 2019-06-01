using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
        public CangKu() {
            //弘基电脑
            list.Add(new List<ProductFather>());
            //三星手机
            list.Add(new List<ProductFather>());
            //酱油
            list.Add(new List<ProductFather>());
            //香蕉
            list.Add(new List<ProductFather>());
        }
        //进货
        public void GetProduct(String type,int count) {

            for (int i = 0; i < count; i++)
            {
                switch (type) {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(),"弘基",4000)); break;
                    case "Sumsang": list[1].Add(new Sumsang(Guid.NewGuid().ToString(), "Sumsang", 5000)); break;
                    case "JianYou": list[2].Add(new JianYou(Guid.NewGuid().ToString(), "老抽", 30)); break;
                    case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), "香蕉", 4)); break;
                }
            }
        }

        //取货
        public ProductFather[] QuProduct(String type, int count) {

            ProductFather[] pro = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (type) {
                    case "弘基": pro[i] = list[0][0]; list[0].RemoveAt(0);break ;
                    case "三星": pro[i] = list[1][0]; list[1].RemoveAt(0); break;
                    case "酱油": pro[i] = list[2][0]; list[2].RemoveAt(0); break;
                    case "香蕉": pro[i] = list[3][0]; list[3].RemoveAt(0); break;
                }
            }
            return pro;
        }
        //展示货物
        public void ShowProduct() {
            foreach (var item in list)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("我们超市有："+item[0].Name+",\t"+"有"+item[0].Count+"个"+",\t 每个"+item[0].Price+"元\t");
            }
        
        }
    }
}
