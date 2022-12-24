using System;

namespace Homework
{
    public static class ArrayExt
    {
        private static T[] GetAlongAxis<T>(T[,] array, int index, int axis) {
            var size = array.GetLength((axis + 1) % 2);
            var result = new T[size];
            for (int i=0; i<size; i++) {
                if (axis==0) result[i] = array[index, i];
                else if (axis==1) result[i] = array[i, index];
                else throw new ArgumentException("axis must be 0 or 1");
            }
            return result;
        }
        public static T[] GetRow<T>(this T[,] array, int row)
        {
            return GetAlongAxis(array, row, 0);
        }

        public static T[] GetCol<T>(this T[,] array, int col)
        {
            return GetAlongAxis(array, col, 1);
        }

        public static int DotProduct(this int[] array, int[] other)
        {
            var result = 0;
            var size = array.Length;
            if (size != other.Length) throw new ArgumentException("array shape mismatch");
            for (int i=0; i<size; i++) {
                result += array[i] * other[i];
            }
            return result;
        }
   }

    public class Class1
    {
        public static int[,] Task54(int[,] arr) {
            var nrows = arr.GetLength(0);
            var ncols = arr.GetLength(1); 
            var result = new int[nrows, ncols];
            for (int i=0; i<nrows; i++) {
                var row = arr.GetRow(i);
                Array.Sort(row);
                for (int j=0; j<ncols; j++) result[i,j] = row[ncols-j-1];
            }
            return result;
        }

        public static int Task56(int[,] arr) {
            var nrows = arr.GetLength(0);
            var ncols = arr.GetLength(1);
            if (nrows == 0) {
                throw new NotSupportedException("Arrays with zero rows are not supported");
            }
            int result = -1;
            int minValue = int.MaxValue;
            for (int i=0; i<nrows; i++) {
                int sum = 0;
                for (int j=0; j<ncols; j++) sum += arr[i,j];
                if (sum < minValue) {
                    minValue = sum;
                    result = i;
                }
            }
            return result;
        }

        public static int[,] Task58(int[,] arr1, int[,] arr2) {
            var nrows = arr1.GetLength(0);
            var ncols = arr2.GetLength(1);
            var result = new int[nrows, ncols];
            if (arr1.GetLength(1) != arr2.GetLength(0)) {
                throw new ArgumentException("Shape mismatch for input arrays");
            }

            for (int i=0; i<nrows; i++) {
                for (int j=0; j<ncols; j++) {
                    var row = arr1.GetRow(i);
                    var col = arr2.GetCol(j);
                    result[i,j] = row.DotProduct(col);
                }
            }
            return result;
        }

        public static void Task60(int[,,] arr) {
            var dims = new int[3];
            for (int i=0; i<3; i++) dims[i] = arr.GetLength(i);
            for (int i=0; i<dims[0]; i++) {
                for (int j=0; j<dims[1]; j++) {
                    for (int l=0; l<dims[2]; l++) {
                        Console.WriteLine(String.Format("{0}({1},{2},{3})", arr[i,j,l], i, j, l));
                    }
                }
            }
        }

        private static Tuple<int,int> GetNextIndex(int i, int j, int n) {
            int center = (n - 1) / 2;
            if (i == n - center - 1 & j == center) return Tuple.Create(i, j);

            if (i - 1 <= j && j <= n - 2 - i) j = j+1;  // move right area
            else if (n - 1 - j <= i && i <= j - 1) i = i+1;  // move down area
            else if (n - i <= j && j <= i) j = j-1;  // move left area
            else if (2 + j <= i && i <= n - 1 - j) i = i-1;  // move up area
            else throw new Exception("i=" + i + "j=" + j);  // in case we messed up
            return Tuple.Create(i, j);
        }

        public static int[,] Task62(int n) {
            var result = new int[n,n];
            int i = 0;
            int j = 0;
            int value = 1;
            for (int step=0; step<n*n; step++) {
                result[i, j] = value;
                value = value+1;
                var newij = GetNextIndex(i, j, n);
                i = newij.Item1;
                j = newij.Item2;
            }
            return result;
        }
    }
}
