using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number - must be lower than first: ");
            int a = int.Parse(Console.ReadLine());

            int[] myArray = new int[b - a];

            for (int i = 0; i < (b-a); i++)
            {
                myArray[i] = a + i;
            }

            Console.WriteLine();

            for (int i = 0; i < (b-a); i++)
            {
                if (myArray[i] % 3 == 0)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
        }
    }
}
