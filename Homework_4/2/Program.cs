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
            Console.WriteLine("Please enter your score - must be between 1 and 9: ");
            byte Score = byte.Parse (Console.ReadLine());

            if (Score > 0 && Score < 4)
            {
                Console.WriteLine("Your Bonus Score is: " + Score * 5);
            }

            else if (Score > 3 && Score < 7)
            {
                Console.WriteLine("Your Bonus Score is: " + Score * 10);
            }

            else if (Score > 6 && Score < 10)
            {
                Console.WriteLine("Your Bonus Score is: " + Score * 50);
            }

            else
            {
                Console.WriteLine("Your input is wrong");
            }
            Console.ReadKey();
        }
    }
}
