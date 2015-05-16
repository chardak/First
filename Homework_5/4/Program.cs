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
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Please enter number between 0 and 9: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("The index of the number is: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
