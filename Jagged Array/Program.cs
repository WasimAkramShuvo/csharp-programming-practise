using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            var jaggedArray = new int[3][];
            // declare array size
            jaggedArray[0] = new int[5];    
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            // or
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4 };
            jaggedArray[2] = new int[] { 1, 2, 3 };
            
            Console.WriteLine(jaggedArray[0][4]);   // Output = 5;
            Console.WriteLine(jaggedArray[1][2]);   // Output = 3;
            Console.WriteLine(jaggedArray[2][1]);   // Output = 2;
            #endregion

            #region Example 2
            var jaggedArray_1 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3 }
            };
            #endregion

            #region Example 3
            // here don't use var 
            int[][] jaggedArray_2 = 
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3 }
            };
            #endregion

            #region Example 4 
            var jaggedArray_3 = new int[4][];
            // how to asiign value in jaggedarray
            jaggedArray_3[0][1] = 10;   // assign 10 to the 2nd element [1] of the 1st array [0]  
            jaggedArray_3[1][5] = 100;  // assign 100 to the 6th element [1] of the 2nd array [0] 
            jaggedArray_3[2][4] = 20;   // assign 20 to the 3rdd element [1] of the 3rd array [0] 
            jaggedArray_3[3][3] = 200;  // assign 200 to the 4th element [1] of the 4th array [0] 
            #endregion

            #region Example 5 -> JaggedArray with 2D Array 
            var jaggedArray_4 = new int[4][,]
            {
                new int[,] { { 1, 2 }, { 2, 3 } },
                new int[,] { { 1, 2, 4 }, { 2, 3, 5 } },
                new int[,] { { 1, 2, 6 }, { 2, 3, 8 }, { 2, 5, 10 } },
                new int[,] { { 1 }, { 2 } },
            };
            #endregion
        }
    }
}
