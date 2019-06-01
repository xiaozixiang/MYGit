using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37小鸟游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitailGame();
            InitializeComponent();
        }

        private GuangDao gdup;
        private GuangDao gddown;
        public void InitailGame() {
        SingleObject.GetSingle().AddGameObject(new Bird(50, 200, 0));
        gdup = new GuangDao(100, -600,GuangDao.GDDiration.up);
        gddown = new GuangDao(100, 400, GuangDao.GDDiration.down);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SingleObject.GetSingle().BirdDraw(e.Graphics);
            gdup.DrawGD(e.Graphics);
            gddown.DrawGD(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                SingleObject.GetSingle().SingleBird.Move();
                SingleObject.GetSingle().SingleBird.speed = 10f;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            SingleObject.GetSingle().SingleBird.Move();
            SingleObject.GetSingle().SingleBird.speed = 10f;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var height = ZhongLi.GetHeight(SingleObject.GetSingle().SingleBird.speed, SingleObject.GetSingle().SingleBird.DurationTime*0.001f);
            int y = SingleObject.GetSingle().SingleBird.Y + (int)height;
            y = y < 0 ? 0 : y;
            y = y > this.Size.Height - pictureBox1.Height - 60 ? this.Size.Height - pictureBox1.Height - 60 : y;
            SingleObject.GetSingle().SingleBird.Y = y;
            SingleObject.GetSingle().SingleBird.speed = SingleObject.GetSingle().SingleBird.speed + ZhongLi.G * SingleObject.GetSingle().SingleBird.DurationTime * 0.001f;
        }

        public void GDMove() {
            gdup.X -= 10;
            gddown.X -= 10;
            if (gdup.X < -128) {
                gdup.X = this.Width * 4 / 3 - 128;
                gddown.X = this.Width * 4 / 3 - 128;
                gdup.GDHeight = setRandom();
                gddown.GDHeight = this.Size.Height - pictureBox1.Height - GDDistance - gdup.GDHeight;
                gdup.Y = gdup.GDHeight - 830;
                gddown.Y = gdup.GDHeight + GDDistance;
            }
        }
        public static int GDDistance = 150;

        private void timer3_Tick(object sender, EventArgs e)
        {
            GDMove();
        }

        public int setRandom() {

            Random r = new Random();
            int totalheight = this.Size.Height - pictureBox1.Height;
            return r.Next(90, totalheight - 90 - GDDistance);
        }
    }
}
