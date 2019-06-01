using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37小鸟游戏
{
    class Bird:GameObject
    {
        public static Image[] imgs = { Properties.Resources._0, Properties.Resources._1, Properties.Resources._2 };

        public int BirdIndex
        {
            set;
            get;
        }
        public float speed
        {
            set;
            get;
        }
        public int DurationTime
        {
            set;
            get;
        }

        public Bird(int x,int y,int birdindex):base(x,y,imgs[0].Width,imgs[1].Height){
        
            this.BirdIndex=birdindex;
            this.speed = 0f;
            this.DurationTime = 100;
        }


        public override void Move()
        {
            this.Y-=40;
            if(this.Y<=0){
                this.Y=0;
            }
        }

        public override void Draw(Graphics g)
        {
            switch(BirdIndex){
                case 0:g.DrawImage(imgs[0],this.X,this.Y);break;
                case 1:g.DrawImage(imgs[1],this.X,this.Y);break;
                case 2:g.DrawImage(imgs[1],this.X,this.Y);break;
            }
            BirdIndex++;
            if(BirdIndex>=3){
                BirdIndex=0;
            }
        }
    }
}
