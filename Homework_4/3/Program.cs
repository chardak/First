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
            Console.WriteLine("Please enter your card: ");
            string card = (Console.ReadLine());

            switch (card)
            {
                case "2":
                    Console.WriteLine("Valid Card");
                    break;

                case "3":
                    Console.WriteLine("Valid Card");
                    break;

                case "4":
                    Console.WriteLine("Valid Card");
                    break;

                case "5":
                    Console.WriteLine("Valid Card");
                    break;

                case "6":
                    Console.WriteLine("Valid Card");
                    break;

                case "7":
                    Console.WriteLine("Valid Card");
                    break;

                case "8":
                    Console.WriteLine("Valid Card");
                    break;

                case "9":
                    Console.WriteLine("Valid Card");
                    break;

                case "10":
                    Console.WriteLine("Valid Card");
                    break;

                case "J":
                    Console.WriteLine("Valid Card");
                    break;

                case "Q":
                    Console.WriteLine("Valid Card");
                    break;

                case "K":
                    Console.WriteLine("Valid Card");
                    break;

                case "A":
                    Console.WriteLine("Valid Card");
                    break;
                default:
                    Console.WriteLine("Invalid Card");
                    break;
            }
            Console.ReadKey();
        }
    }
}
