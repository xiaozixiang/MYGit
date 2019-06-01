using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class SupperMaket
    {

        CangKu ck = new CangKu();
        public SupperMaket() {
            ck.GetProduct("Acer", 1000);
            ck.GetProduct("Sumsang", 1000);
            ck.GetProduct("JianYou", 1000);
            ck.GetProduct("Banana", 1000);
        }

        public void AskBuying() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("欢迎光临,请问你需要什么？");
            Console.WriteLine("我们有弘基，三星，酱油，香蕉");
            Console.ForegroundColor = ConsoleColor.White;
            String type = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("你需要多少？");
            Console.ForegroundColor = ConsoleColor.White;
            int count = Convert.ToInt32(Console.ReadLine());
           
            ProductFather[] pros=  ck.QuProduct(type, count);
            double realMoney = GetMoney(pros);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("你总共应付{0}元",realMoney);
            Console.WriteLine("请选择你的打折方式 ：1--不打折 2--大85折 3--打九折 4--买300送50 5--买500送100");
            Console.ForegroundColor = ConsoleColor.White;
            String input=Console.ReadLine();

            CalFather cal=GetCal(input);
           double totalmonet= cal.TotalMoney(realMoney);
           Console.WriteLine("打折后的价钱是{0}",totalmonet);
            Console.WriteLine("一下是你的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称："+item.Name+" 货物单价"+item.Price+" 货物编号"+item.ID);
            }
      }

       

        public void ShowProduct() {
            ck.ShowProduct();
        }
  
     public CalFather GetCal(String input) {

            CalFather cal = null;
            switch(input){
                case "1": cal = new CalNormal(); break;
                case "2": cal = new CalRate(0.85); break;
                case "3": cal = new CalRate(0.9); break;
                case "4": cal = new CalMN(300, 50); break;
                case "5": cal = new CalMN(500, 100); break;
            }
            return cal;
        }

        public double GetMoney(ProductFather[] pros) {

            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
    }

}
