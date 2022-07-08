﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop 迴圈示範
            for (int i = 1; i <= 20; i += 1) //step 步進1
            {
                Console.WriteLine("i:" + i); 
            }
            Console.WriteLine("----------------------------");

            for (int i = 2; i <= 100; i += 2) //偶數 2...100
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("----------------------------");
            //輸出 10...1
            for (int i = 10; i >= 1; i -= 1)
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("----------------------------");

            for (int i = 1; i <= 20; i += 1)
            {
                if (i > 9)
                {
                    break; //中斷迴圈;
                }
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("----------------------------");

            for (int i = 1; i <= 20; i += 1)
            {
                if (i == 8)
                {
                    continue; //跳過此次迴圈;
                }
                Console.WriteLine("i:" + i);
            }

            for (int i = 1; i <= 5; i += 1)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine("----------------------------");

            for (int i = 1; i <= 5; i += 1)
            {
                for (int j = 1; j <= 10; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");

            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");

            for (int i = 1; i <= 9; i += 1)
            {
                for (int j = 1; j <= 9; j += 1)
                {
                    //Console.Write("{0} x {1} = {2},", i, j, i * j);
                    Console.Write($"{i}*{j}=" + i * j);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
         

            Console.WriteLine("----------------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}
