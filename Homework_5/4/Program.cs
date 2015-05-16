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
            Console.Write("Please enter the Array length: ");
            int[] myArray = new int [int.Parse(Console.ReadLine())];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Please enter number " + (i + 1) + ": ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Please enter which number you are looking for: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= myArray.Length; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("The index of the number is: " + (i-1));
                }
            }
            Console.ReadKey();
        }
    }
}
