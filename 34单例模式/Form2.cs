using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34单例模式
{
    public partial class Form2 : Form
    {
        public static Form2 fom2single = null;

        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 getsingle() {
            if (fom2single == null) {
                fom2single = new Form2();
            }
            
            return fom2single;
        }
    }
}
