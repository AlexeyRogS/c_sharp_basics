using System;
using Xunit;

namespace HomeworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(Homework.Class1.task10(456), 5);
            Assert.Equal(Homework.Class1.task10(782), 8);
            Assert.Equal(Homework.Class1.task10(918), 1);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(Homework.Class1.task13(645), 5);
            Assert.Equal(Homework.Class1.task13(78), -1);
            Assert.Equal(Homework.Class1.task13(32679), 6);
        }

        [Fact]
        public void Test3()
        {
            Assert.True(Homework.Class1.task15(6));
            Assert.True(Homework.Class1.task15(7));
            Assert.False(Homework.Class1.task15(1));
        }
    }
}
