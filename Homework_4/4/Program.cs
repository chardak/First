using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter tne number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
