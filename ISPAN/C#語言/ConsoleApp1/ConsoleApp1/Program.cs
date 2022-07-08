using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //單行註解
            /*
              多行註解
                12345
             */
            System.Console.WriteLine("Hello World!!");
            System.Console.WriteLine("HI 這是第一個Console程式");
            Console.WriteLine("C# 語言第一個示範");
            Console.WriteLine("C# Demo");
            Console.ForegroundColor = ConsoleColor.Yellow; //字體顏色
            Console.BackgroundColor = ConsoleColor.Blue; //背景顏色
            Console.WriteLine("1. 主控應用程式");
            Console.WriteLine("2. WindowsForm 應用程式");
            Console.WriteLine("3. Web 主控應用程式");
            Console.WriteLine();
            Console.ResetColor(); //重製顏色
            Console.WriteLine("特殊字元符號");
            Console.WriteLine("\"雙引號\""); //特殊符號顯示用反斜線\
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\t\t\t縮排");
            Console.WriteLine("換行\n\n\n");
            
            Console.WriteLine("按Enter結束程式");

            System.Console.ReadLine(); //等待使用者輸入ENTER
        }
    }
}
