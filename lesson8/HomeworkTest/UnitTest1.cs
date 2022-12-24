using System;
using System.Collections.Generic;
using Homework;
using Xunit;

namespace HomeworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var input = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
            var answer = new int[,] {{7, 4, 2, 1}, {9, 5, 3, 2}, {8, 4, 4, 2}};
            Assert.Equal(answer, Class1.Task54(input));
        }

        [Fact]
        public void Test2()
        {
            var input = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
            Assert.Equal(0, Class1.Task56(input));
        }

        [Fact]
        public void Test3()
        {
            var arr1 = new int[,] {{2, 4}, {3, 2}};
            var arr2 = new int[,] {{3, 4}, {3, 3}};
            var ans = new int[,] {{18, 20}, {15, 18}};
            Assert.Equal(ans, Class1.Task58(arr1, arr2));
        }

        [Fact]
        public void Test4()
        {
            var answers = new Dictionary<int, int[,]> ();
            answers.Add(2, new int[,] {{1, 2}, {4, 3}});
            answers.Add(3, new int[,] {{1, 2, 3}, {8, 9, 4}, {7, 6, 5}});
            answers.Add(4, new int[,] {{1, 2, 3, 4}, {12, 13, 14, 5}, {11, 16, 15, 6}, {10, 9, 8, 7}});
            foreach (var k in answers.Keys) {
                Assert.Equal(answers[k], Class1.Task62(k));
            }

        }
    }
}
