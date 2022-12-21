using System;

namespace Homework
{
    public class Class1
    {
        private static int[,] intArray;
        public static int[,] IntArray {
            get {return intArray;}
            set {intArray = value;}
        }

        private static double GenerateRandomDouble(double min, double max) {
            Random rnd = new Random();
            double num = rnd.NextDouble();
            num = num * (max - min) + min;  // may result in overflow be careful
            return num;
        }

        private static double ComputeColumnMean(int index) {
            double result = 0;
            int n_rows = intArray.GetLength(0);
            for (int j=0; j<n_rows; j++) {
                result = result + intArray[j,index];
            }
            return result / n_rows;
        }

        public static double[,] Task47(int n, int m, double min=0, double max=1) {
            var result = new double[n,m];
            for (int i=0; i<n; i++) {
                for (int j=0; j<m; j++) {
                    result[i,j] = GenerateRandomDouble(min, max);
                }
            }
            return result;
        }

        public static dynamic Task50(int row_i, int col_i) {
            int n = intArray.GetLength(0);
            int m = intArray.GetLength(1);
            if (row_i >= n || col_i >= m) {
                return "No such element";
            }
            return intArray[row_i, col_i];
        }

        public static double[] Task52() {
            var n_cols = intArray.GetLength(1);
            var result = new double[n_cols];
            for (int i=0; i<n_cols; i++) {
                result[i] = ComputeColumnMean(i);
            }
            return result;
        }
    }
}
