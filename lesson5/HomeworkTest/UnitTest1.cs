using System;
using Homework;
using Xunit;

namespace HomeworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, Class1.Task34(new int[] {345, 897, 568, 234}));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(19, Class1.Task36(new int[] {3, 7, 23, 12}));
            Assert.Equal(0, Class1.Task36(new int[] {-4, -6, 89, 6}));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(76, Class1.Task38(new double[] {3, 7, 22, 2, 78}));
        }
    }
}
