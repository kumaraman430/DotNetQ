using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Arrays
{
    class SingleDimensional_Array
    {
        //static void Main(string[] args)
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

    class Passing_array_to_function
    {
        //void printArray(int[] arr)
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

    class Passing_array_to_function_Min_Num
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
        //static void Main(string[] args)
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

    class MultiDimensional_Rectangular_Array
    {
        //static void Main(string[] args)
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

    class Jagged_Array
    {
        //    static void Main(string[] args)
        //    {
        //    //int[][] jaggedArray = new int[2][];

        //    //jaggedArray[0] = new int[4] { 11, 21, 56, 78 };
        //    //jaggedArray[1] = new int[6] { 42, 61, 37, 41, 59, 63 };

        //    //jaggedArray[0] = new int[] { 11, 21, 56, 78 };
        //    //jaggedArray[1] = new int[] { 42, 61, 37, 41, 59, 63 };

        //        int[][] jaggedArray = new int[3][]
        //        {
        //            new int[] {11,21,56,68},
        //            new int[] {2,5,98},
        //            new int[] {11,21,78}
        //        };

        //        int value = jaggedArray[1][0]; // Accesses the first element of the second inner array (which is 2)
        //        int outerLength = jaggedArray.Length; // Number of inner arrays
        //        int innerLength = jaggedArray[0].Length; // Length of the first inner array

        //        for (int i = 0; i < jaggedArray.Length; i++)
        //        {
        //            for (int j = 0; j < jaggedArray[i].Length; j++)
        //            {
        //                Console.Write(jaggedArray[i][j] + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.ReadKey();
        //    }
    }

    class Params_Array
    {
        //public void Show1(params int[] val)
        //{
        //    for (int i = 0; i < val.Length; i++)
        //    {
        //        Console.WriteLine(val[i]);
        //    }
        //}
        //public void Show2(params object[] items)
        //{
        //    for(int i = 0;i < items.Length; i++)
        //    {
        //        Console.WriteLine(items[i]);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Params_Array params_Array = new Params_Array();
        //    params_Array.Show1(2, 4, 6, 8, 10, 12, 14);
        //    params_Array.Show2(2, "Aman", 6, "Kumar", 10, 12, 14);

        //    Console.ReadKey();
        //}
    }

    class Array_Class
    {
        //static void Main(string[] args)
        //{
        //    // Creating One-Dimensional array
        //    int[] arr1 = new int[] { 10, 21, 333, 46, 455, 68 };

        //    // Creating an empty array
        //    int[] arr2 = new int[6];

        //    // Creating a Multi-Dimensional array
        //    int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        //    // Display original array
        //    Console.WriteLine("Original first array:");
        //    PrintArray(arr1);

        //    // Display Length of Array
        //    Console.WriteLine("\nLength of first array: " + arr1.Length);

        //    // Finding Index of array
        //    Console.WriteLine("\nIndex position of 21 is : " + Array.IndexOf(arr1,21));

        //    // Sorting the array
        //    Array.Sort(arr1);
        //    Console.WriteLine("\nSorted array:");
        //    PrintArray(arr1);

        //    // Reverse the array
        //    Array.Reverse(arr1);
        //    Console.WriteLine("\nReverse array:");
        //    PrintArray(arr1);

        //    // Coping first array to empty array
        //    Array.Copy(arr1, arr2, arr1.Length);
        //    Console.WriteLine("\nSecond array:");
        //    PrintArray(arr2);

        //    // Displaying multi-dimensional array
        //    Console.WriteLine("\nMulti-Dimensional array:");
        //    PrintMultiDimensionalArray(matrix);

        //    Console.ReadKey();
        //}
        //static void PrintArray(int[] numbers)
        //{
        //    foreach (int i in numbers)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        //static void PrintMultiDimensionalArray(int[,] matrix)
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            Console.Write(matrix[i, j] + " ");
        //        }
        //    }
        //}
    }

    class Command_Line_Argument
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Argument length:" + args.Length);
        //    Console.WriteLine("Supplied Arguments are: ");

        //    foreach (Object obj in args)
        //    {
        //        Console.WriteLine(obj);
        //    }
        //    Console.ReadKey();
        //}
    }
}