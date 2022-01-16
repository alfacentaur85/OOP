using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(3, 5);
            Rational r2 = new Rational(7, 6);
            Rational r3 = new Rational(6, 10);
            Rational r4 = new Rational(12, 10);
            Rational r5 = new Rational(1, 10);

            Console.WriteLine(r1.ToString());

            
            Console.WriteLine(r1.Equals(r2));
            Console.WriteLine(r1.Equals(r3));

            Console.WriteLine((r1 + r2).ToString());

            Console.WriteLine((r1 - r2).ToString());

            Console.WriteLine((r1 * r2).ToString());

            Console.WriteLine((r1 / r2).ToString());

            Console.WriteLine((r1 > r2));

            Console.WriteLine(r1 < r2);

            Console.WriteLine(r1 >= r3);

            Console.WriteLine(r1 <= r3);
            
            Rational r = r1++;
            Console.WriteLine(r.ToString());
            Console.WriteLine(r1.ToString());

            r = r4--;
            Console.WriteLine(r.ToString());
            Console.WriteLine(r4.ToString());

            int i = r5;
            Console.WriteLine(i.ToString());
            i = r1;
            Console.WriteLine(i.ToString());

            float f = r1;
            Console.WriteLine(f.ToString());


        }
    }
}
