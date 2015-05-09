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
            Console.WriteLine("Write something and press Enter");
            string a = Console.ReadLine();

            Console.WriteLine("which symbol you want to see");
            int b = int.Parse(Console.ReadLine());

            b--;

            Console.WriteLine();
            Console.WriteLine("O.K. Here it is: " + a[b]);

            Console.ReadKey();
        }
    }
}
