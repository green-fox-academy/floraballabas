using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;
            // make it bigger by 10

            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            // make it smaller by 7

            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            // please double c's value

            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            // please divide by 5 d's value

            Console.WriteLine(d);

            int e = 8;
            e = e * e * e;
            // please cube of e's value

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;

            Console.WriteLine(f1 >= f2);
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;

            Console.WriteLine( g2 * g2 >= g1);
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            long h = 1357988018575474;
            Console.WriteLine(h % 11 == 0);
            // tell if it has 11 as a divisor (print as a boolean)

            int i1 = 10;
            int i2 = 3;

            Console.WriteLine(i1 >= i2 * i2 && i1 <= i2 * i2 *i2);
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;
            Console.WriteLine(j % 3 == 0 || j % 5 == 0);
            // tell if j is dividable by 3 or 5 (print as a boolean)

            string k = "Apple";
            Console.WriteLine(k+k+k+k);
            //fill the k variable with its cotnent 4 times
        }
    }
}
