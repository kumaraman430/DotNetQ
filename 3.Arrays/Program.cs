using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Arrays
{
    public class SingleDimensional_Array
    {
        //public static void Main(string[] args)
        //{
        //    //int[] arr = new int[5];
        //    //arr[0] = 10;
        //    //arr[2] = 20;
        //    //arr[4] = 30;
        //    //OR
        //    //int[] arr = new int[5] { 10, 20, 30, 40, 50 };
        //    //OR
        //    //int[] arr = new int[] { 10, 20, 30, 40 };
        //    //OR
        //    int[] arr = { 10, 20, 30, 40, 50 };

        //    // Traversal using for loop
        //    //for (int i = 0; i < arr.Length; i++)
        //    //{
        //    //    Console.WriteLine(arr[i]);
        //    //}

        //    // Traversal using foreach loop
        //    foreach (int i in arr)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadKey();
        //}
    }

    public class Passing_array_to_function
    {
        //static void printArray(int[] arr)
        //{
        //    Console.WriteLine("Printing array elements");
        //    foreach (int i in arr)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    int[] arr1 = { 25, 10, 20, 15, 40, 50 };
        //    int[] arr2 = { 12, 23, 44, 11, 54 };

        //    printArray(arr1);
        //    printArray(arr2);

        //    Console.ReadKey();
        //}
    }

    public class Passing_array_to_function_Min_Num
    {
        //static void PrintMin(int[] arr)
        //{
        //    int min = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (min > arr[i])
        //        {
        //            min = arr[i];
        //        }
        //    }
        //    Console.WriteLine("Minimum Element is : " + min);
        //}
        //static void PrintMax(int[] arr)
        //{
        //    int max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (max < arr[i])
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    Console.WriteLine("Maximum Element is : " + max);
        //}
        //public static void Main(string[] args)
        //{
        //    int[] arr1 = { 25, 10, 20, 15, 40, 50 };
        //    int[] arr2 = { 12, 23, 44, 11, 54 };

        //    PrintMin(arr1);
        //    PrintMin(arr2);
        //    PrintMax(arr1);
        //    PrintMax(arr2);

        //    Console.ReadKey();
        //}
    }

    public class MultiDimensional_Array
    {
        //public static void Main(string[] args)
        //{
        //    //int[,] arr = new int[3, 3];
        //    //arr[0, 1] = 10;
        //    //arr[1, 2] = 20;
        //    //arr[2, 0] = 30;

        //    //int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //    //int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //    int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}
    }

    public class Jagged_Array
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            //arr[0] = new int[4] { 11, 21, 56, 78 };
            //arr[1] = new int[6] { 42, 61, 37, 41, 59, 63 };

            arr[0] = new int[] { 11, 21, 56, 78 };
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}