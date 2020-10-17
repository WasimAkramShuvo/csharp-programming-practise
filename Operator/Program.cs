using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1-> Increment / Decrement Operator
            var i = 50;
            Console.WriteLine(i);   // Output = 50
            Console.WriteLine(i++); // Output = 50
            Console.WriteLine(++i); // Output = 52
            Console.WriteLine(i--); // Output = 52
            Console.WriteLine(--i); // Output = 50
            Console.WriteLine(--i); // Output = 49
            #endregion

            #region Example 2-> Unary Plus and Minus Operator
            Console.WriteLine(i+4);     // Output = 53
            Console.WriteLine(i*4);     // Output = 196
            Console.WriteLine(-+i);     // Output = -49
            Console.WriteLine(-(-i));   // Output = 49
            #endregion

            #region Example 3-> Math Operator
            Console.WriteLine(3 + 4);     // Output = 7
            Console.WriteLine(2 - 4);     // Output = -2
            Console.WriteLine(3 * -2);    // Output = -6
            Console.WriteLine(10 / 3);    // Output = 3
            Console.WriteLine(10 / 3.0);  // Output = 3.3333333333333335
            Console.WriteLine(-10 / 3);  // Output = -3

            Console.WriteLine(10.5f / 3.1f);  // Output = 3.387097
            Console.WriteLine(10.5d / 3.1d);  // Output = 3.3870967741935485
            Console.WriteLine(10.5m / 3.1m);  // Output = 3.3870967741935483870967741935

            Console.WriteLine(10 % 3);      // Output = 1
            Console.WriteLine(10 % 2);      // Output = 0
            Console.WriteLine(-10 % 3);     // Output = -1
            Console.WriteLine(10 % -3);     // Output = 1

            var j = 5;
            j += 2;
            Console.WriteLine(j);

            var k = -5;
            k -= 2;
            Console.WriteLine(k);

            var l = 5.7;
            l *= 20.5;
            Console.WriteLine(l);

            var m = 5;
            m /= 2;
            Console.WriteLine(m);
            #endregion

            #region Example 4-> Bitwise Complement Operator
            var a = 0b_0001_1010_1111_0101_1001_0110_0100_1010;
            var b = ~a;
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            // Output: 11100101000010100110100110110101

            var c = 15;
            var d = ~c;
            Console.WriteLine(Convert.ToString(d, toBase: 2));
            // Output: 11111111111111111111111111110000
            #endregion

            #region Example 5-> Shift Operator
            var e = 0b_0001_1010_1111_0101_1001_0110_0100_1010;
            Console.WriteLine($"Before: {Convert.ToString(e, toBase: 2)}");

            var f = e << 4;
            Console.WriteLine($"After: {Convert.ToString(f, toBase: 2)}");
            /* Before: 00011010111101011001011001001010
               After:  10101111010110010110010010100000
            */

            var g = 0b_0001_1010_1111;
            Console.WriteLine($"Before: {Convert.ToString(g, toBase: 2)}");

            var h = g << 4;
            Console.WriteLine($"After: {Convert.ToString(h, toBase: 2)}");
            /* Before: 000110101111
               After:  1101011110000
            */

            #endregion

            #region Example 6-> Logical Operator
            var u = 0b_0001_1010_1111_0101;
            var v = 0b_1011_0011_1001_0001;
            var w = u & v;
            var z = u | v;
            var s = u ^ v;

            Console.WriteLine(Convert.ToString(w, toBase: 2));  // Output: 1001010010001
            Console.WriteLine(Convert.ToString(z, toBase: 2));  // Output: 1011101111110101
            Console.WriteLine(Convert.ToString(s, toBase: 2));  // Output: 1010100101100100
            #endregion
        }
    }
}
