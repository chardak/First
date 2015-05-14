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
            Console.WriteLine("Please enter the number bigger than 2: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number lower than first one but bigger than 1: ");
            int k = int.Parse(Console.ReadLine());

            decimal factoriel_N = 1;
            decimal factoriel_K = 1;

            while (true)
            {
                if (n<1)
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
            Console.WriteLine("N!/K!= " + (factoriel_N / factoriel_K));

            Console.ReadKey();
        }
    }
}
