using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27石头剪刀布
{
    public enum Result{
        玩家赢,
        电脑赢,
        平手
    
    }
    class Judge
    {

        public static Result result(int PlayerNumber,int ComputerNumber) {
            if (PlayerNumber - ComputerNumber == -1 || PlayerNumber - ComputerNumber == 2) {
                return Result.玩家赢;
            }
            else if (PlayerNumber - ComputerNumber == 0)
            {
                return Result.平手;
            }
            else {
                return Result.电脑赢;
            }
        }
    }
}
