using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the square matrix dimension: ");
            int n = int.Parse(Console.ReadLine());

            int[,] myArray = new int[n, n];

            int a = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArray[i, j] = (a + (i + j));
                }
                a = (a + n - 1);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (myArray[j, i] < 10)
                    {
                        Console.Write(" " + myArray[j, i] + " ");
                    }

                    else Console.Write(myArray[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
