using System;
using Homework;
using System.Collections.Generic;
using Xunit;

namespace HomeworkTest
{

    class MyComparer : IEqualityComparer<double[]>
    {
        private int precision;
        public int Precision {
            get {return precision;}
            set {precision = value;}
        }

        public MyComparer(int precision) {
            this.precision = precision;
        }

        public bool Equals(double[] b1, double[] b2)
        {
            if (b1.Length != b2.Length) return false;
            var len = b1.Length;
            for (int i=0; i<len; i++) {
                var diff = Math.Abs(b1[i] - b2[i]);
                if (diff * Math.Pow(10, this.precision) >= 1) return false;
            }
            return true;
        }

        public int GetHashCode(double[] obj)
        {
            return obj.GetHashCode();
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var arrs = new List<int[,]> ();
            var indeces = new List<Tuple<int, int>> ();
            var values = new List<object> ();

            arrs.Add(new int[,] {{1, 2}, {1, 4}});
            indeces.Add(Tuple.Create(1, 1));
            values.Add(4);

            arrs.Add(new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}});
            indeces.Add(Tuple.Create(1, 7));
            values.Add("No such element");

            arrs.Add(new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}});
            indeces.Add(Tuple.Create(1, 3));
            values.Add(3);

            for (int i=0; i<arrs.Count; i++) {
                Class1.IntArray = arrs[i];
                var point = indeces[i];
                Assert.Equal(Class1.Task50(point.Item1, point.Item2), values[i]);
            }
        }

        [Fact]
        public void Test2()
        {
            var arrs = new List<int[,]> ();
            var mean_vals = new List<double[]> ();
            arrs.Add(new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}});
            mean_vals.Add(new double[] {4.6, 5.6, 3.6, 3});
            arrs.Add(new int[,] {{1, 2, 3}, {2, 1, 2}, {3, 3, 1}});
            mean_vals.Add(new double[] {2, 2, 2});

            for (int i=0; i<arrs.Count; i++) {
                Class1.IntArray = arrs[i];
                Assert.Equal(Class1.Task52(), mean_vals[i], new MyComparer(1));
            }
        }
    }
}
