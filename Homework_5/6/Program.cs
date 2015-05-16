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
            int[,] myArray = new int[5, 6];

            int a = 30;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myArray[i, j] = (a - (i + j));
                }
                a = a - 5;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (myArray[i, j] < 10)
                    {
                        Console.Write(" " + myArray[i, j] + " ");
                    }

                    else Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
