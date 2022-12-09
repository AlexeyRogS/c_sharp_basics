using System;
using System.IO;

namespace Homework
{
    public class Class1
    {
        public static int task25(int num, int power) {
            int result = num;
            for (int i=1; i<power; i++) result = result * num;
            return result;
        }

        public static int task27(int num) {
            int sum = 0;
            string num_s = num.ToString();
            for (int i=0; i<num_s.Length; i++) {
                sum = sum + (num_s[i] - '0');
            }
            return sum;
        }

        public static void task29(int[] arr, StringWriter writer = null) {
            if (writer != null) Console.SetOut(writer);
            if (arr.Length == 0) {
                Console.Write("[]");
                return;
            }

            Console.Write('[');
            for (int i=0; i<arr.Length - 1; i++) {
                Console.Write(arr[i] + ", ");
            }
            Console.Write(arr[arr.Length-1] + "]");
        }
    }
}
