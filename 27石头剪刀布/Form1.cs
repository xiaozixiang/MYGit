using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            
            String str = "石头";
            PlayerGames(str);
        }

        private void PlayerGames(String str)
        {
            lblPlaer.Text = str;
            Player player = new Player();
            int PlayerNumber = player.showfist(str);
            Computer cmp = new Computer();
            int ComputerNumber = cmp.showfist();
            lblcomouter.Text = cmp.Fist;
            Result.Text = Judge.result(PlayerNumber, ComputerNumber).ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            String str = "剪刀";
            PlayerGames(str);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            String str = "布";
            PlayerGames(str);
        }
    }
}
