using System;
using Homework;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace HomeworkTest
{

    public class PointComparer : IEqualityComparer<Tuple<double, double>>
    {
        private int precision;
        public int Precision {get {return precision;} set {precision = value;}}
        
        public PointComparer(int precision) {
            Precision = precision;
        }

        public bool Equals(Tuple<double, double> x, Tuple<double, double> y)
        {
            double x_diff = Math.Abs(x.Item1 - y.Item1);
            double y_diff = Math.Abs(x.Item2 - y.Item2);
            double max_error = 1 / Math.Pow(10, this.precision);
            return (x_diff < max_error) & (y_diff < max_error);
        }

        public int GetHashCode(Tuple<double, double> obj)
        {
            return obj.Item1.GetHashCode() % obj.Item2.GetHashCode();
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, Class1.CountPositive(input:new StringReader("0, 7, 8, -2, -2")));
            Assert.Equal(4, Class1.CountPositive(input:new StringReader("1, -7, 567, 89, 223")));
        }

        [Fact]
        public void Test2()
        {
            var data = new List<Tuple<double, double>[]> ();
            data.Add(new Tuple<double, double>[] {Tuple.Create(-0.5, -0.5),
                                                  Tuple.Create(5.0, 2.0), 
                                                  Tuple.Create(9.0, 4.0)});
            
            data.Add(new Tuple<double, double>[] {Tuple.Create(-2.13, 21.2),
                                                  Tuple.Create(6.0, 34.0), 
                                                  Tuple.Create(-9.0, 2.0)});             
            foreach (var pll in data) {
                Assert.Equal(pll[0], Class1.GetIntercectionPoint(pll[1], pll[2]), new PointComparer(2));
            }
        }
    }
}
