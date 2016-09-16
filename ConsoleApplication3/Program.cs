using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning1

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            //övning2
            for (int a = 20; a > 0; a--)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("");

            //övning3

            for (int b = 0; b <= 50; b = b + 2)
            {
                Console.WriteLine(b);
            }
            
        }
    }
}
