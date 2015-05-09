using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum is: " + (a + b));
            Console.ReadKey();
        }
    }
}
