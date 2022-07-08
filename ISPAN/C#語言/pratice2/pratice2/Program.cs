using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //用條件判斷式, 隨意輸入三個數字比大小;
            int a = 100;
            int b = 600;
            int c = 20;
            do {
                Console.WriteLine("請輸入三個數字:");
                Console.Write("a:"); 
                int aa = int.Parse(Console.ReadLine());
                Console.Write("b:");
                int bb = int.Parse(Console.ReadLine());
                Console.Write("c:");
                int cc = int.Parse(Console.ReadLine());

                a = aa;
                b = bb;
                c = cc;

                if (a >= b && a >= c)
                {
                    if (a == b && a == c)
                    {
                        Console.WriteLine("a = b = c");

                    }
                    else if (a == b)
                    {
                        Console.WriteLine("a = b > c");

                    }
                    else if (a == c)
                    {
                        Console.WriteLine("a = c > b");

                    }
                    else if (b == c)
                    {
                        Console.WriteLine("a > b = c");

                    }
                    else if (b > c)
                    {
                        Console.WriteLine("a > b > c");

                    } else
                    {
                        Console.WriteLine("a > c > b");
                    }
                } else if (b >= c && b >= a)
                {
                    if (b == a && b == c)
                    {
                        Console.WriteLine("b = a = c");

                    }
                    else if (b == c)
                    {
                        Console.WriteLine("b = c > a");

                    }
                    else if (b == a)
                    {
                        Console.WriteLine("b = a > c");

                    }
                    else if (c > a)
                    {
                        Console.WriteLine("b > c > a");

                    } else if (c == a)
                    {
                        Console.WriteLine("b > c = a");
                    }
                    else
                    {
                        Console.WriteLine("b > a > c");
                    }
                } else if (c >= a && c >= b)
                {
                    if (c == a && c == b)
                    {
                        Console.WriteLine("c = a = b");

                    }
                    else if (c == a)
                    {
                        Console.WriteLine("c = a > b");

                    }
                    else if (c == b)
                    {
                        Console.WriteLine("c = b > a");

                    }else if(a == b)
                    {
                        Console.WriteLine("c > a = b");

                    }
                    else if (c > a && a > b)
                    {
                        Console.WriteLine("c > a > b");

                    }
                    else
                    {
                        Console.WriteLine("c > b > a");

                    }
                }

                Console.WriteLine("按X離開 按任意鍵繼續");
                string x = Console.ReadLine();

                if (x == "x")
                {
                    break;
                }
                }

                while (true);
        }
    }
}

