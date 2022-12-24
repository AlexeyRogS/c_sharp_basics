using System;
using Homework;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var arr = new int[,,] {{{66, 27}, {25, 90}},
                                   {{34, 26}, {41, 55}}};
            Class1.Task60(arr);
        }
    }
}
