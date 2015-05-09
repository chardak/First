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

            Console.WriteLine("Please type Hello and press Enter");
            string a = Console.ReadLine();
            string b = "Hello";

            Console.WriteLine(a.Contains(b));
        }
    }
}
