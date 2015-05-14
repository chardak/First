using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter tne number:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter tne number:");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter tne number:");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter tne number:");
            int a4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter tne number:");
            int a5 = int.Parse(Console.ReadLine());

            if (a1<a2 && a1<a3 && a1<a4 && a1<a5)
            {
                Console.WriteLine("Lowest Number is: " + a1);
            }
            else if (a1>a2 && a1>a3 && a1>a4 && a1>a5)
            {
                Console.WriteLine("Biggest Number is: " + a1);
            }

            if (a2 < a1 && a2 < a3 && a2 < a4 && a2 < a5)
            {
                Console.WriteLine("Lowest Number is: " + a2);
            }
            else if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            {
                Console.WriteLine("Biggest Number is: " + a2);
            }

            if (a3 < a2 && a3 < a1 && a3 < a4 && a3 < a5)
            {
                Console.WriteLine("Lowest Number is: " + a3);
            }
            else if (a3 > a2 && a3 > a1 && a3 > a4 && a3 > a5)
            {
                Console.WriteLine("Biggest Number is: " + a3);
            }

            if (a4 < a2 && a4 < a3 && a4 < a1 && a4 < a5)
            {
                Console.WriteLine("Lowest Number is: " + a4);
            }
            else if (a4 > a2 && a4 > a3 && a4 > a1 && a4 > a5)
            {
                Console.WriteLine("Biggest Number is: " + a4);
            }

            if (a5 < a2 && a5 < a3 && a5 < a4 && a5 < a1)
            {
                Console.WriteLine("Lowest Number is: " + a1);
            }
            else if (a5 > a2 && a5 > a3 && a5 > a4 && a5 > a1)
            {
                Console.WriteLine("Biggest Number is: " + a5);
            }

            Console.ReadKey();
        }
    }
}
