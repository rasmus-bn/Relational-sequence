using System;
using System.Linq;

namespace Rational_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Relationals.GetRational(20));

            var r1 = new Relationals(0, 50);
            foreach(Fraction f in r1)
            {
                Console.WriteLine($"{f.ToString()} = {f.GetValue()}");
            }
        }
    }
}
