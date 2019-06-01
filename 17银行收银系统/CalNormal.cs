using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class CalNormal:CalFather
    {
        public override double TotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
