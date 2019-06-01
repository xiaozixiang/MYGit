using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class CalRate:CalFather
    {

        public double Rate
        {
            set;
            get;
        }
        public CalRate(double rate) {

            this.Rate = rate;
        }
        public override double TotalMoney(double realMoney)
        {
            return realMoney * this.Rate;

        }
    }
}
