using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 練習輸出:等腰三角形 菱形
            //課程作業加分題: 請輸出 聖誕樹 彩色 有裝飾
            //可任意輸入聖誕樹高度
            /*
                        *
                       **+
                      **+*
                     **+***
                    **+*****
                       |||
                    ---------
             */

            Console.Write("請輸入聖誕樹高度:");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            int q = 0;

            for (int i = 1; i <= x; i++)
            {

                for (int j = 1; j <= x - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (i > 1 && k == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("+");
                    }
                    else
                    {
                        if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("*");

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("*");
                        }
                    }
                    q = k / 2 - 2;
                }
                Console.Write("\n");
            }
            for(int c = 0; c<=1; c++)
            {
                for (int d = 0; d <= q; d++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("||||");

            }

            Console.ForegroundColor = ConsoleColor.Cyan;          
            Console.ResetColor();
            Console.WriteLine("=====================================================================");
            Console.WriteLine("\n");
            //練習 便當選單 輸入便當名稱 告訴使用者有沒有賣 多少錢
            //EX雞腿飯 80  咖哩便當 沒賣
            //建立2維string陣列 儲存便當名稱跟價格做搜尋
            //至少十種便當 string[20,2] 20種類 2價格

            string[,] arrayfood_string = {
                { "炸雞腿", "100" }, { "滷雞腿", "90"  }, { "炸排骨", "85"  },
                { "滷排骨", "80" },{ "炸雞排", "75"  }, { "炸魚排", "95"   },
                { "香腸", "70"  }, { "糖醋雞", "70"  }, { "水煮雞胸肉", "90"  }, { "五菜", "60"  }};

            do
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("請輸入要購買的便當口味(輸入完成請按ENTER)");
                string str搜尋便當 = Console.ReadLine();
                bool is有這便當 = false;
                try
                {
                    for (int i = 0; i <= arrayfood_string.GetUpperBound(0); i += 1)
                    {

                        for (int j = 0; j <= arrayfood_string.GetUpperBound(1); j += 1)
                        {

                            if (arrayfood_string[i, j] == str搜尋便當)
                            {

                                Console.WriteLine("你購買的{0}便當:{1}元", arrayfood_string[i, j], arrayfood_string[i, j + 1]);

                                is有這便當 = true;
                                break;
                            }

                        }
                    }
                }
                catch (Exception error)
                {
                    is有這便當 = true;
                    Console.WriteLine("沒有賣這個口味");
                }

                if (is有這便當 == false)
                {
                    Console.WriteLine("沒有賣這個口味");
                }

                Console.WriteLine("==========================================");
                Console.WriteLine("(離開請按x 或 任意鍵繼續)");
                string xx = Console.ReadLine();
                if (xx == "x")
                {
                    break;
                }

            } while (true);

          

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
            for (int i = 1; i <= 10 / 2 + 1; i++)
            {//打印上半部分
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)//打印星星
                {

                    Console.Write("*");

                }

                Console.Write("\n");
            }
            for (int i = 10 / 2; i >= 1; i--)
            { //打印下半部分
                for (int j  = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j  = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
