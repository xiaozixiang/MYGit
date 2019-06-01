using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27石头剪刀布
{
    class Player
    {

        public int showfist(String fist) {

            int playerNumber = 0;
            switch (fist) {
                case "石头": playerNumber = 1; break;
                case "剪刀": playerNumber = 2; break;
                case "布": playerNumber = 3; break;
            
            }
            return playerNumber;
        
        }
    }
}
