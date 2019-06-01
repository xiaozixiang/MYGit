using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37小鸟游戏
{
    class GuangDao
    {

     public    enum GDDiration { 
            up,
            down
        }
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
        public int GDWidth
        {
            set;
            get;
        }
        public int GDHeight
        {
            set;
            get;
        }
        public GDDiration GD
        {
            set;
            get;
        }
        public GuangDao(int x, int y, GDDiration gd) {
            this.X = x;
            this.Y = y;
            this.GD = gd;
        }

        public Image img = Properties.Resources.flappy_packer;

        public Image GetImage(int x, int y) {
            Bitmap bmp = new Bitmap(128, 830);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, 128, 830), new Rectangle(x, y, 128, 830), GraphicsUnit.Pixel);
            return bmp;
        }

        public void DrawGD(Graphics g) {
            switch (this.GD) {
                case GDDiration.up: g.DrawImage(GetImage(160, 495), this.X, this.Y); break;
                case GDDiration.down: g.DrawImage(GetImage(10, 495), this.X, this.Y); break;
            }
        
        }
    }
}
