using System;
using Xunit;
using Homework;
using System.Collections.Generic;

namespace HomeworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.False(Class1.task19(14212));
            Assert.True(Class1.task19(12821));
            Assert.True(Class1.task19(23432));
        }

        [Fact]
        public void Test2()
        {
            var points = new List<Tuple<float[], float[], float>>();
            points.Add(new Tuple<float[], float[], float>(
                new float[] {3, 6, 8}, new float[] {2, 1, -7}, (float)15.84)
                );
            points.Add(new Tuple<float[], float[], float>(
                new float[] {7, -5, 0}, new float[] {1, -1, 9}, (float)11.53)
                );
            foreach(var ppd in points) {
                Assert.Equal(Class1.task21(ppd.Item1, ppd.Item2), ppd.Item3, 2);
            }
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(Class1.task23(3), new int[] {1, 8, 27});
            Assert.Equal(Class1.task23(5), new int[] {1, 8, 27, 64, 125});
        }
    }
}
