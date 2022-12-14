using System;

namespace Homework
{
    public class Class1
    {
        private static int GenerateIntWithConditions(int d, bool onlyPositive) {
            Random rnd = new Random();
            int num;
            if (d == 0) {
                num = rnd.Next();
            } else {
                num = rnd.Next((int)Math.Pow(10, d-1),
                               (int)Math.Pow(10, d));
            }

            if (onlyPositive || rnd.NextDouble() < 0.5) return num;
            return -num;
        }

        public static int[] GenerateRandomIntegerArray(int n, bool onlyPositive, int d=0) {
            // creates an array of n d-digit integers. 
            // if onlyPositive then the numbers will all be positive
            // if d = 0 there will not be a restriction on the numbers' digits count
            if (d < 0) throw new NotSupportedException("Valued d less than 0 are not accepted");
            var result = new int[n];
            for (int i=0; i<n; i++) {
                result[i] = GenerateIntWithConditions(d, onlyPositive);
            }
            return result;
        }

        public static double[] GenerateRandomDoubleArray(int n, double min=0, double max=1) {
            if (min > max) throw new NotSupportedException("Values min more than max are not accepted");
            var result = new double[n];
            Random rnd = new Random();

            for (int i=0; i<n; i++) {
                double x = rnd.NextDouble();
                result[i] = x*max + min - x*min;
            }
            return result;
        }

        public static int Task34(int[] x) {
            // count number of even elements
            int counter = 0;
            foreach(var e in x) {
                if (e % 2 == 0) counter += 1;
            }
            return counter;
        }

        public static int Task36(int[] x) {
            // sum of elements with odd indeces
            int counter = 0;
            for(int i=1; i<x.Length; i=i+2) {
                counter = counter + x[i];
            }
            return counter;
        }

        public static double Task38(double [] x) {
            // max(x) - min(x)
            if (x.Length == 0) {
                throw new NotSupportedException("Arrays of length 0 are not accepted");
            }
            double max_value = double.MinValue;
            double min_value = double.MaxValue;
            foreach(var e in x) {
                max_value = Math.Max(max_value, e);
                min_value = Math.Min(min_value, e);
            }
            return max_value - min_value;
        }
    }
}
