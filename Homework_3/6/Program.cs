using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не съм сигурен дали е правилно....

            Console.WriteLine("Please enter the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Your result is: " + a / b);
            Console.ReadKey();
        }
    }
}
