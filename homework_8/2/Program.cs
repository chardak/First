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
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine();

            PrintGreeting(name);
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Greeting, {0}", name);
        }
    }
}
