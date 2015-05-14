using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int k = int.Parse(Console.ReadLine());

            int a = n-k;

            decimal factoriel_N = 1;
            decimal factoriel_K = 1;
            decimal factoriel_a = 1;

            while (true)
            {
                if (n < 1)
                {
                    break;
                }
                factoriel_N *= n;
                n--;
            }

            while (true)
            {
                if (k < 1)
                {
                    break;
                }
                factoriel_K *= k;
                k--;
            }

            while (true)
            {
                if (a < 1)
                {
                    break;
                }
                factoriel_a *= a;
                a--;
            }


            Console.WriteLine("N!*K!/(N-K)!= " + (factoriel_N * factoriel_K / factoriel_a));

            Console.ReadKey();
        }
    }
}
