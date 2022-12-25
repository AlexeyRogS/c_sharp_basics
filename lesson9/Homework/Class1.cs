using System;
using System.IO;

namespace Homework
{
    public class Class1
    {
        // Writes numbers in console: N, N-1, N-2, ..., 1
        // implement with recursion
        public static void Task64(int N, StringWriter s=null) {
            if (N < 1) throw new ArgumentException("N is supposed to be a natural number");
            if (s != null) Console.SetOut(s);
            if (N == 1) {
                Console.Write(N);
            } else {
                Console.Write(N + ", ");
                Task64(N-1);
            }
        }

        // Returns sum of numbers in the interval: M + (M+1) + ... + (N-1) + N
        // N >= M; we will implement it using recursion (though it is not wise to do so here)
        public static int Task66(int M, int N) {
            if (M > N) throw new ArgumentException("N is supposed to be not smaller than M");
            if (M == N) return M;
            return M + Task66(M + 1, N);
        }

        // Akkernam's function (slices the titans up or smth)
        public static int Task68(int m, int n) {
            if (m == 0) return n + 1;
            if (n == 0) return Task68(m-1, 1);
            return Task68(m-1, Task68(m, n-1));
        }
    }
}
