using System;
using Homework;

namespace App
{
    class Program
    {
        static void DisplayArray<T>(T[] arr) {
            if (arr.Length == 0) {
                Console.Write("[]");
                return;
            }
            Console.Write("[");
            for (int i=0; i<arr.Length-1; i++) {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr[arr.Length - 1] + "]");
        }

        static void Main(string[] args)
        {
            DisplayArray(Class1.GenerateRandomDoubleArray(5));
            DisplayArray(Class1.GenerateRandomDoubleArray(5, min:0, max:100));
            DisplayArray(Class1.GenerateRandomDoubleArray(5, min:-100, max:0));

            DisplayArray(Class1.GenerateRandomIntegerArray(3, true, 4));
            DisplayArray(Class1.GenerateRandomIntegerArray(10, true, 3));
            DisplayArray(Class1.GenerateRandomIntegerArray(5, false, 3));
            DisplayArray(Class1.GenerateRandomIntegerArray(8, false, 2));
        }
    }
}
