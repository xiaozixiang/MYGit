using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37小鸟游戏
{
    public abstract class GameObject
    {
        public int X
        {
            set;
            get;
        }
        public int Y
        {
            set;
            get;
        }
        public int Width
        {
            set;
            get;
        }
        public int Height
        {
            set;
            get;
        }

        public GameObject(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public abstract void Move();
        public abstract void Draw(Graphics g);
    }
}
