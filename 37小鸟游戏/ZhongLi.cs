using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37小鸟游戏
{
    class ZhongLi
    {
        public static float G = 9.8f;

        public static float GetHeight(float speed,float DurationTime) {

            return (float)(0.5 * G * DurationTime * DurationTime) + speed * DurationTime;
        }

    }
}
