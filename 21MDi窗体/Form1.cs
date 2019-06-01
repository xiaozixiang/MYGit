using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21MDi窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 创建新窗体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
          
            Form3 frm3 = new Form3();
          
            Form4 frm4 = new Form4();
          
            //foreach (var item in this.MdiChildren)
            //{
            //    if (item.Name == frm2.Name  )
            //    {
            //        frm2.Activate();
            //        frm2.Dispose();
                   
            //    }
            //    if(item.Name == frm3.Name )
            //    {
            //        frm3.Activate();
            //         frm3.Dispose();
            //    }
            //    if(item.Name == frm4.Name)
            //    {
            //        frm4.Activate();
            //        frm4.Dispose();
            //    }
            //    else 
            //    {
                    frm2.MdiParent = this;
                    frm2.Show();
                    frm3.MdiParent = this;
                    frm3.Show();
                    frm4.MdiParent = this;
                    frm4.Show();
            //    }
            //}
        }

        private void 横向排列ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 纵向排列ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

    }
}
