using Homework;
using System;

namespace App
{
    class Program
    {
        static void Display1dArray<T>(T[] arr) {
            if (arr.Length == 0) {
                Console.WriteLine("[]");
            }
            Console.Write("[");
            for (int i=0; i<arr.Length-1; i++) {
                Console.Write(arr[i]);
                Console.Write(", ");
            }
            Console.Write(arr[arr.Length-1]);
            Console.WriteLine("]");
        }

        static void Display2dArray<T>(T[,] arr) {
            var n_rows = arr.GetLength(0);
            var n_cols = arr.GetLength(1);
            for (int i=0; i<n_rows; i++) {
                var row = new T[n_cols];
                for (int j=0; j<n_cols; j++) {
                    row[j] = arr[i,j];
                }
                Display1dArray(row);
            }
        }
        static void Main(string[] args)
        {
            Display2dArray(Class1.Task47(3, 2, 0, 10));
            Display2dArray(Class1.Task47(3, 3, 10, 50));
            Display2dArray(Class1.Task47(2, 2, -100, 100));
        }
    }
}
