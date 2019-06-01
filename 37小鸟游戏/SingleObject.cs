using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37小鸟游戏
{
    class SingleObject
    {

        public static SingleObject _singleobject = null;
        private SingleObject() { }
        public static SingleObject GetSingle() {
            if (_singleobject == null) {
                _singleobject = new SingleObject();
            }
            return _singleobject;
        }
        public Bird SingleBird
        {
            set;
            get;
        }

        public void AddGameObject(GameObject go) {
            SingleBird = (Bird)go;
        }
        public void BirdDraw(Graphics g) {
            SingleBird.Draw(g);
        }
    }
}
