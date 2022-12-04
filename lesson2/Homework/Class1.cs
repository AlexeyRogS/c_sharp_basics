using System;

namespace Homework
{
    public class Class1
    {
        public static int task10(int a) {
            // a is tree digits number
            return (a % 100) / 10;
        }

        public static int task13(int a) {
            // a is a positive number
            if (a < 100) {
                return -1; // does not have third digit
            }
            return int.Parse(a.ToString().Substring(2, 1));
        }

        public static bool task15(int dayOfWeek) {
            // a is a number from 1 to 7
            if (dayOfWeek > 5) {
                return true;  // is a weekend
            }
            return false;  // not a weekend
        }
    }
}
