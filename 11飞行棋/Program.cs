using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11飞行棋
{
    class Program
    {

        static  int[] maps=new int[100];
        static int[] playerpos = new int[2];
        static String[] playernames = new String[2];
        static void Main(string[] args)
        {
            GrameShow();
            inintialMaps();
            #region 玩家输入姓名
            Console.WriteLine("请输入玩家A的姓名");
            playernames[0] = Console.ReadLine();
            while (playernames[0] == "")
            {
                Console.WriteLine("玩家A不能为空，请重新输入");
                playernames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            playernames[1] = Console.ReadLine();
            while (playernames[1] == "" || playernames[1] == playernames[0])
            {
                if (playernames[1] == "")
                {
                    Console.WriteLine("玩家B不能为空，请重新输入");
                    playernames[1] = Console.ReadLine();
                }
                if (playernames[1] == playernames[0])
                {
                    Console.WriteLine("玩家B不能跟玩家A的姓名相同，请重新输入");
                    playernames[1] = Console.ReadLine();
                }
            }
            #endregion
            Console.Clear();

            GrameShow();

            Console.WriteLine("{0}的士兵用A表示", playernames[0]);
            Console.WriteLine("{0}的士兵用B表示", playernames[1]);
            drawMap();

            while (playerpos[0] < 99 && playerpos[1] < 99)
            {
                playGrames(0);
                playGrames(1);

            }//while
            Console.ReadKey();
        }

        public static void GrameShow() {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*****肖自翔的飞行棋*****");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("************************");
        
        }

        public static void inintialMaps(){ 
        
            int[] luckturn={6,23,40,55,69,83};
                for (int i = 0; i < luckturn.Length; i++)
                {
                    int index = luckturn[i];
                    maps[index] = 1;
   
                }
            int[] landmine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
                for (int i = 0; i < landmine.Length; i++)
                {
                    maps[landmine[i]] = 2;
                }
            int[] pause = { 9, 27, 60, 93 };
             for (int i = 0; i < pause.Length; i++)
                {
                    maps[pause[i]] = 3;
                
                }
            int[] timennel = { 20, 25, 45, 63, 72, 88, 90 };
                 for (int i = 0; i < timennel.Length; i++)
                {
                    maps[timennel[i]] = 4;
                }
        }

        public static void drawMap()
        {
            Console.WriteLine("图例：幸运轮盘：▲  地雷：◎  暂停：卍  时空隧道：♀");
            #region 画第一横行
            draw();
            #endregion
            Console.WriteLine();
            #region 画第一竖行
            for (int i = 29; i <34; i++)
            {
                for (int j = 0; j <29; j++)
                {
                    Console.Write("  ");
                }
                if (playerpos[0] == playerpos[1] && playerpos[0] == i)
                {
                    Console.Write("<>");
                }
                else if (playerpos[0] == i)
                {
                    Console.Write("A");
                }
                else if (playerpos[1] == i)
                {
                    Console.WriteLine("B");
                }
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□"); break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("▲"); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("◎"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("卍"); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("♀"); break;
                }
                Console.WriteLine();
            }

            #endregion
            #region 画第二横行
            for (int i =64; i >34; i--)
            {
                if (playerpos[0] == playerpos[1] && playerpos[0] == i)
                {
                    Console.Write("<>");
                }
                else if (playerpos[0] == i)
                {
                    Console.Write("A");
                }
                else if (playerpos[1] == i)
                {
                    Console.WriteLine("B");
                }
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□"); break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("▲"); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("◎"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("卍"); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("♀"); break;
                }
            }
            #endregion
            Console.WriteLine();
            #region 画第二竖行
            for (int i = 64; i <69; i++)
            {

                if (playerpos[0] == playerpos[1] && playerpos[0] == i)
                {
                    Console.Write("<>");
                }
                else if (playerpos[0] == i)
                {
                    Console.Write("A");
                }
                else if (playerpos[1] == i)
                {
                    Console.WriteLine("B");
                }
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□"); break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("▲"); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("◎"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("卍"); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("♀"); break;
                }
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine();
            }


            #endregion
            #region 画第三横行
            for (int i = 69; i <99; i++)
            {
                if (playerpos[0] == playerpos[1] && playerpos[0] == i)
                {
                    Console.Write("<>");
                }
                else if (playerpos[0] == i)
                {
                    Console.Write("A");
                }
                else if (playerpos[1] == i)
                {
                    Console.WriteLine("B");
                }
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□"); break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("▲"); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("◎"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("卍"); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("♀"); break;
                }
            }

            #endregion
            Console.WriteLine();
        }

        private static void draw()
        {
            for (int i = 0; i < 29; i++)
            {
                if (playerpos[0] == playerpos[1] && playerpos[0] == i)
                {
                    Console.Write("<>");
                }
                else if (playerpos[0] == i)
                {
                    Console.Write("A");
                }
                else if (playerpos[1] == i)
                {
                    Console.WriteLine("B");
                }
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□"); break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("▲"); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("◎"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("卍"); break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("♀"); break;
                }
            }
        }

        public static void playGrames(int playerNumber) {

            Random r = new Random();
            int rnumber=r.Next(1,7);
            Console.WriteLine("{0}按任意键掷骰子", playernames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}掷出了{1}", playernames[playerNumber],rnumber);
            playerpos[playerNumber] += rnumber;
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", playernames[playerNumber]);
            Console.ReadKey(true);
            if (playerpos[playerNumber] == playerpos[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退6格", playernames[playerNumber], playernames[1 - playerNumber], playernames[1 - playerNumber]);
                playerpos[1 - playerNumber] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                switch (maps[playerpos[0]])
                {
                    case 0: Console.WriteLine("玩家{0}猜到了方块 安全", playernames[playerNumber]); Console.ReadKey(true); break;
                    case 1: Console.WriteLine("玩家{0}猜到了幸运轮盘 请选择1---交换位置 2--轰炸对方", playernames[playerNumber]); Console.ReadKey(true);
                        String strinput = Console.ReadLine();
                        int input = 0;
                        try
                        {
                            input = Convert.ToInt32(strinput);
                        }
                        catch
                        {
                            Console.WriteLine("输入有误,请重新输入");
                            strinput = Console.ReadLine();
                        }
                        if (input == 1)
                        {
                            Console.WriteLine("玩家A和玩家B交换位置", playernames[playerNumber], playernames[1 - playerNumber]);
                            Console.ReadKey(true);
                            int temp = playerpos[playerNumber];
                            playerpos[playerNumber] = playerpos[1 - playerNumber];
                            playerpos[1 - playerNumber] = temp;
                            Console.WriteLine("交换完成！！ 按任意键继续！！");
                            Console.ReadKey(true);
                            break;
                        }
                        if (input == 2)
                        {
                            Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退6格", playernames[playerNumber], playernames[1 - playerNumber], playernames[1 - playerNumber]);
                            Console.ReadKey(true);
                            playerpos[1 - playerNumber] -= 6;
                            Console.WriteLine("玩家{0}退了6格", playernames[1 - playerNumber]);
                            break;
                        }
                        break;
                    case 2: Console.WriteLine("玩家{0}猜到了地雷 退6格", playernames[playerNumber]);
                        Console.ReadKey(true);
                        playerpos[playerNumber] -= 6;
                        break;
                    case 3: Console.WriteLine("玩家{0}猜到了暂停 暂停一回合", playernames[playerNumber]);

                        Console.ReadKey(true); break;
                    case 4: Console.WriteLine("玩家{0}猜到了时空隧道 前进10格", playernames[playerNumber]);
                        Console.ReadKey(true);
                        playerpos[playerNumber] += 10;
                        break;
                }//switch
            }//else
            changpos();
            Console.Clear();
            drawMap();
        }

        public static void changpos() {
            if (playerpos[0] < 0) {
                playerpos[0] = 0;
            }
            if (playerpos[0] > 99) {
                playerpos[0] = 99;
            }
            if (playerpos[1] < 0)
            {
                playerpos[1] = 0;
            }
            if (playerpos[1] > 99)
            {
                playerpos[1] = 99;
            }
        }
         
    }
}
