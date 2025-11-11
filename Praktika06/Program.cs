using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double a = 5 * Math.Sin(x) - 7 * Math.Cos(x);
            Console.WriteLine($"х = {x}, F = {F}.");
            Console.ReadKey();
        }
    }
}