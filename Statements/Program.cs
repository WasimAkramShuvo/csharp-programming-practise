using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;
            var c = -30;
            Console.WriteLine(Average(a, b, c));

            var p = 100;
            var q = 2;
            var r = 300;
            Console.WriteLine(Average1(p, q, r));

            var x = 1000;
            var y = 20.5;
            var z = 10.005;
            Console.WriteLine(Average1(x, y, z));
        }
        static int Average(int num1, int num2, int num3)
        {
            var avg = (num1 + num2 + num3) / 3;
            return avg;
        } 
        static double Average1(double num4, double num5, double num6)
        {
            var avg1 = (num4 + num5 + num6) / 3;
            return avg1;
        }
    }
}
