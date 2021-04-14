using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._04._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1
            Console.WriteLine("введите число");
            double x = Convert.ToDouble(Console.ReadLine());
        //    Math.Pow(Math.Sin(x), 2);

            if (x > 0)
            {
                 double y = Math.Pow(Math.Sin(x), 2);
                Console.WriteLine(y);
            }
            else
            {
                double y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
                Console.WriteLine(y);
            }

            //4.6 б
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            //4.9
            Console.WriteLine("введите скорость в км/ч k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите скорость в м/с m");
            double m = Convert.ToDouble(Console.ReadLine());
            double k1 = k * 1000 / 3600;
            if (k>m) {
                Console.WriteLine(k+"км/ч");
            }
            else
            {
                Console.WriteLine(m+"м/c");
            }

            //4.10 
            Console.WriteLine("Введите первое число");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double r = Convert.ToDouble(Console.ReadLine());
            double s1 = (a * a);
            double s2 = (2 * 3.14 * Math.Pow(r, 2));
            if (s1 > s2)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(r);
            }



            Console.ReadKey();
        }
    }
}
