using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a1, a2, b1, b2;
            x1 = 12d;
            x2 = 13d;
            y1 = 11d;
            y2 = 10d;
            a1 = 1d;
            a2 = 3d;
            b1 = 1d;
            b2 = 10d;
            var length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            var length2 = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine(length1);
            Console.WriteLine(length2);
            if (length1 <= length2)
            {
                Console.WriteLine("Line2 is longer than Line1");
            }
            else if(length1 >= length2)
            {
                Console.WriteLine("Line1 is longer than Line2");
            }
            else
            {
                Console.WriteLine("Line1 and Line2 are of same length");
            }
        }
    }
}
