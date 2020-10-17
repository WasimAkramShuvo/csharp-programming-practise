using System;

namespace Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello {0}, Welcome to the csharp course", name);
            #endregion

            #region Example 2
            Console.WriteLine("What is your name?");
            var nam = Console.ReadLine();
            Console.WriteLine($"Hello {nam}, Welcome to the csharp course");
            #endregion
        }
    }
}
