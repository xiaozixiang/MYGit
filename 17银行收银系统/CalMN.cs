using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class CalMN:CalFather
    {
        public double M
        {
            set;
            get;
        }
        public double N
        {
            set;
            get;
        }
        public CalMN(double m, double n) {
            this.M = m;
            this.N = n;
        }
        public override double TotalMoney(double realMoney)
        {
            if (realMoney >=this.M)
            {
                return realMoney - (int)(realMoney/this.M)*this.N;
            }
            else {
                return realMoney;
            }
        }
    }
}
