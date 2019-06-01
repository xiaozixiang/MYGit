using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27石头剪刀布
{
    class Computer
    {
        public String Fist
        {
            set;
            get;
        }

        public int showfist() {
            Random r = new Random();
            int computerNumber=r.Next(1,4);
            switch (computerNumber) {

                case 1: this.Fist = "石头"; break;
                case 2: this.Fist = "剪刀"; break;
                case 3: this.Fist = "布"; break;
            }
            return computerNumber;
        }
    }
}
