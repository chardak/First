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
            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter number {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            int min = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Minimal number is [0], Maximal is {1}", min, max);

// нещо се омотах тук - не се сещам как да го направя. зациклих...
          //  MaxNumber(min, max);
            

        }

        private static int MaxNumber(int first, int second)
        {
            if (first > second)
            {
                return first;
                Console.WriteLine(first);
            }
            else
            {
                return second;
                Console.WriteLine(second);
            }

            
        }
    }
}
