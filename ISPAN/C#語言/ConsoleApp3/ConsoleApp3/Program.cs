using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //算術運算子
            int x = 9;
            int y = 4;
            int z;
            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;
            z = x % y;
            z = -y;
            z = x + y * y;
            z = (x - y) / y;

            int x2 = 5;
            double y2 = 1.1234;
            double z2;
            z2 = x2 * y2;
            z2 = x2 / y2;

            Console.WriteLine("z的值為:" + z);
            Console.WriteLine("z2的值為:" + z2);
            Console.WriteLine("----------------");

            //算數指定運算子
            int c = 250;
            int d = 100;
            // c = c + 3;
            // c += 3;
            // c-= 3;
            //c /= 3;
            //c *= 3;
            //c %= 3;
            c += d;
            Console.WriteLine("c的值為:" + c);
            Console.WriteLine("----------------");

            //遞增遞減運算子
            int r = 8;
            r++; // r = r + 1
            r--; // r = r - 1
            Console.WriteLine("r的值為:" + r);
            Console.WriteLine("---------------");

            //關係運算子
            double m = 85.23;
            double n = 45.64;
            bool compare;

            compare = m == n;
            compare = m != n;
            compare = m >= n;
            compare = m > n;
            compare = m <= n;
            compare = m < n;



            Console.WriteLine("compare: " + compare);
            Console.WriteLine("--------------");


            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();



        }
    }
}
