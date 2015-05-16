using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array length: ");
            int[] fibonachi = new int[int.Parse(Console.ReadLine())];

            fibonachi[0] = 1;
            fibonachi[1] = 1;

            for (int i = 2; i < fibonachi.Length; i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }

            Console.WriteLine("Fibonachi numbers in the array are: ");
            for (int i = 0; i < fibonachi.Length; i++)
            {
                Console.WriteLine(fibonachi[i]);
            }
            Console.ReadKey();
        }
    }
}
