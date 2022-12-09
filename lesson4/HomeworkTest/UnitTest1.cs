using System;
using Xunit;
using Homework;
using Xunit.Abstractions;
using System.IO;
using System.Collections.Generic;

namespace HomeworkTest
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(Class1.task25(3, 5), 243);
            Assert.Equal(Class1.task25(2, 4), 16);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(Class1.task27(452), 11);
            Assert.Equal(Class1.task27(82), 10);
            Assert.Equal(Class1.task27(9012), 12);
        }

        [Fact]
        public void Test3()
        {
            var data = new List<Tuple<int[], string>> ();
            data.Add(new Tuple<int[], string>(new int[] {1, 2, 3}, "[1, 2, 3]"));
            data.Add(new Tuple<int[], string>(new int[] {1, 2, 5, 7, 19}, "[1, 2, 5, 7, 19]"));
            data.Add(new Tuple<int[], string>(new int[] {6, 1, 33}, "[6, 1, 33]"));
            foreach (var e in data) {
                var stringWriter = new StringWriter();
                Class1.task29(e.Item1, writer:stringWriter);
                Assert.Equal(e.Item2, stringWriter.ToString());
            }
        }
    }
}
