using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the First Value ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Value ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Value ");
            c = double.Parse(Console.ReadLine());
            if (a > c)
            {
                double tmp = c;
                c = a;
                a = tmp;


            }
            if (b > c)
            {
                double tmp = c;
                c = b;
                b = tmp;

            }
            if (c == Math.Sqrt(a * a + b * b))
            {
                Console.WriteLine("pravouhly");
            }
            else
            {
                Console.WriteLine("neni pravouhly");
            }
            Console.ReadLine();
        }

    }

}
    
       