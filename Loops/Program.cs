using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 -> For Loop
            for (var i = 0; i < 10; i++)
                Console.Write("Hello ");
            Console.Write("\n");
            for (var j = 10; j > 0; j--)
                Console.Write("World ");
            Console.Write("\n\n");
            #endregion

            #region Example 2 -> While Loop
            var a = 1;
            while (a <= 10)
            {
                Console.Write("Wasim ");
                a++;
            }
            Console.Write("\n");
            var b = 10;
            while (b > 0)
            {
                Console.Write("Akram ");
                b -= 2;
            }
            Console.Write("\n");
            var c = 0;
            while (c < 10)
            {
                Console.Write("Shuvo ");
                c += 4;
            }
            Console.Write("\n\n");
            #endregion

            #region Example 3 -> do-While Loop
            var d = 1;
            do
            {
                Console.Write("East ");
                d+=2;
            } while (d <= 10);
            Console.Write("\n");
            var e = 10;
            do
            {
                Console.Write("West ");
                e--;
            } while (e > 0);
            Console.Write("\n\n");
            #endregion

            #region Example 4 -> Foreach Loop
            /* Foreeach Loop Structure
              foreach (type varivable in collection)
                Statements;
            */
            int[] numbers = { 2, 4, 6, 8, 9, 10 };
            foreach (var i in numbers)
                Console.Write("{0} " ,i);
            Console.WriteLine();
            #endregion
        }
    }
}
