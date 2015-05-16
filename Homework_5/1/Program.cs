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
            Console.WriteLine("Please enter the array length");
            int n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter index: " + (i+1));
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sum = sum + myArray[i];
                }
            }
            Console.WriteLine("Sum of all even numbers is: " + sum);
            Console.ReadKey();
        }
    }
}
