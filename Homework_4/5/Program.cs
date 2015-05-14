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
            Console.WriteLine("Please enter tne number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i%3 != 0 || i%7 != 0)
                {
                    Console.WriteLine(i);
                }
                //Ne znam shto ne raboti, ako slojish znak za ravenstvo otpe4atva tezi koito se delqt, a pri neravenstvo ne stava??????
            }

        }
    }
}
