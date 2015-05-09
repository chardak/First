using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the base of the triangle");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter height pointing the base");
            float h = float.Parse(Console.ReadLine());

            Console.WriteLine("The Area of the triange is:" + (b * h) / 2);
        }
    }
}
