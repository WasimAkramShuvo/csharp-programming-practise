using System;

namespace Multidimentional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 -> One Dimentional Array
            // value not assign
            int[] array1D;
            // set array size
            var array1D_1 = new int[4]; // int[] array1D_1 = new int[4];
            // declare another way
            int[] array1D_2 = { 1, 2, 3, 4, 5, 6 };
            // srting type 1D array element
            string[] daysOfWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday" };
            Console.WriteLine(daysOfWeek[3]);
            #endregion

            #region Example 2 -> Two Dimentional Array
            // value not assign
            int[] array2D;
            // set array size
            var array2D_1 = new int[5, 4];  //int[,] array2D_1 = new int[5, 4];
            array2D_1[1, 2] = 10;
            var x = array2D_1[1, 2];
            Console.WriteLine(x);
            // declare another way (4*2) matrix [row*col]
            var array2D_2 = new int[,]      // int[,] array2D_2 = new int[,] 
            { 
                { 2, 3 }, 
                { 0, 0 }, 
                { 4, 5 }, 
                { 1, 7 }
            };
            // Or, declare another way(2 * 4) matrix[row * col]
            var array2D_3 = new int[2,4]
            {
                { 2, 3, 1, 4 },
                { 0, 0, 2, 3 },
            };
            // srting type 2D array element
            string[,] array2D_4 =
            {
                { "one","two","three" },
                { "four","five","six" },
                { "seven","eight","nine" }
            };
            // anoter way srting type 2D array element
            var array2D_5 = new string[3,3] // string[,] array2D_5 = new string[3,3]
            {
                { "one","two","three" },
                { "four","five","six" },
                { "seven","eight","nine" }
            };
            #endregion

            #region Example 3 -> Three Dimentional Array
            // value not assign
            int[] array3D;
            // set array size
            var array3D_1 = new int[5, 4, 2];   //int[,,] array3D_1 = new int[5, 4, 2];
            array3D_1[1, 2, 1] = 15;
            array3D_1[1, 0, 0] = 20;
            var y = array3D_1[1, 2, 1];
            var z = array3D_1[1, 0, 0];
            Console.WriteLine("{0}\n{1}", y, z);
            // declare another way (3*3*3) matrix[3][3][3]
            var array3D_2 = new int[,,] // int[,,] array3D_2 = new int[,,]

            {
                { 
                    { 2, 3, 3 },
                    { 0, 0, 6 },
                    { 1, 2, 7 }
                },
                {
                    { 1, 2, 3 },
                    { 0, 0, 0 },
                    { 5, 1, 2 }
                },
                {
                    { 5, 2, 3 },
                    { 6, 0, 0 },
                    { 7, 1, 2 },
                },

            };
            // Or, declare another way 
            var array3D_4 = new int[3, 2, 2]    // here, [3] = length {},{},{} * [2] = row * [2] = column
            {
                {
                    { 2, 3 },
                    { 0, 1 }
                },
                {
                    { 2, 3 },
                    { 0, 1 }
                },
                {
                    { 2, 3 },
                    { 0, 1 }
                },
            };

            // Or, declare another way  
            var array3D_3 = new int[3, 3, 3]    // here, [3] = length {},{},{} * [3] = row * [3] = column
            {
                {
                    { 2, 3, 3 },
                    { 0, 0, 6 },
                    { 1, 2, 7 }
                },
                {
                    { 1, 2, 3 },
                    { 0, 0, 0 },
                    { 5, 1, 2 }
                },
                {
                    { 5, 2, 3 },
                    { 6, 0, 0 },
                    { 7, 1, 2 },
                },
            };
            // Or, declare another way 
            var array3D_5 = new int[1, 2, 3] // here, [1] = length {} * [2] = row * [3] = column
            {
                {
                    { 2, 3, 5 },
                    { 0, 1, 8 }
                },
            };

            // srting type 3D array element size = [2, 3, 3]
            string[,,] array3D_6 =
            {
                {
                    { "one","two","three" },
                    { "four","five","six" },
                    { "seven","eight","nine" }
                },
                {
                    { "on","tw","th" },
                    { "fo","fi","si" },
                    { "se","ei","ni" }
                },
            };
            // anoter way srting type 3D array element
            var array3D_7 = new string[1, 1, 2] //string[,,] array3D_7 = new string[1, 1, 2]
            {

                {
                    { "one","two" }
                },

            };
            #endregion

        }
    }
}
