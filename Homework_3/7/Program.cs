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
            Console.WriteLine("Please type something and press Enter");
            string a = Console.ReadLine();

            Console.WriteLine("Please type something else and press Enter");
            string b = Console.ReadLine();

            Console.WriteLine(a.Contains(b));
            Console.ReadLine();
        }
    }
}
