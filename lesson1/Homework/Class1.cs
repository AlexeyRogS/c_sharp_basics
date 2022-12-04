using System;

namespace Homework
{
    public class Class1
    {
        public static int Task2(int a, int b) {
            // max between two
            return Math.Max(a, b);
        }

        public static int Task4(int a, int b, int c) {
            // max between three
            return Math.Max(a, Math.Max(b, c));
        }

        public static bool Task6(int a) {
            // is even
            return a % 2 == 0;
        }

        public static string Task8(int N) {
            // all even up to N
            int length = N / 2;
            var evenDigits = new int[length];
            for (int i = 0; i < length; i++) {
                evenDigits[i] = 2*(i+1);
            }
            string result = string.Join(" ", evenDigits);
            Console.WriteLine(result);
            return result;
        }
    }
}
