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

            int a = new int();
            int b = new int();
            int c = new int();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
  //pozvolih si da sloja tova ograni4enie za da e po vidimo na oko, ina4e e rand.Next()
                a = rand.Next(-100, 100);
                b = rand.Next(-100, 100);
                c = rand.Next(-100, 100);

                Calculate(a, b, c);                
            }

            Console.ReadKey();
        }

        static void Calculate(int a, int b, int c)
        {
            int d = a * b * c;
            Console.WriteLine("{0} x {1} x {2} = {3}", a, b, c, d);
        }

    }
}
