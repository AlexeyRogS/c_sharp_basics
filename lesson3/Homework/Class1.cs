using System;

namespace Homework
{
    public class Class1
    {
        public static bool task19(int num) {
            // "Returns truth if the given five digit number is a palindrome"
            string num_s = num.ToString();
            for (int i=0; i<num_s.Length; i++) {
                if (num_s[i] != num_s[num_s.Length-i-1]) return false;
            }
            return true;
        }

        public static float task21(float[] x, float[] y) {
            // given two points coordinate computer distance between them
            if (x.Length != y.Length) throw new AggregateException("Arrays lengths mismatched");

            float running_sum = 0;
            for (int i=0; i<x.Length; i++) {
                running_sum += (y[i] - x[i]) * (y[i] - x[i]);
            }
            return (float)Math.Sqrt(running_sum);
        }
        
        public static int[] task23(int N) {
            // N is a positive number. The method returns an array of cubes of numbers from 1 to N
            int[] result = new int[N];
            for (int i=0; i<N; i++) {
                result[i] = (int)Math.Pow(i+1, 3);
            }
            return result;
        }
    }
}
