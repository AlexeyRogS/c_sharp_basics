using System;
using Xunit;

namespace HomeworkTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(7, Homework.Class1.Task2(4, 7));
            Assert.Equal(10, Homework.Class1.Task2(2, 10));
            Assert.Equal(-3, Homework.Class1.Task2(-9, -3));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(7, Homework.Class1.Task4(2, 3, 7));
            Assert.Equal(78, Homework.Class1.Task4(44, 5, 78));
            Assert.Equal(22, Homework.Class1.Task4(22, 3, 9));
        }

        [Fact]
        public void Test3()
        {
            Assert.True(Homework.Class1.Task6(4));
            Assert.False(Homework.Class1.Task6(-3));
            Assert.False(Homework.Class1.Task6(7));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("2 4", Homework.Class1.Task8(5));
            Assert.Equal("2 4 6 8", Homework.Class1.Task8(8));
        }
    }
}
