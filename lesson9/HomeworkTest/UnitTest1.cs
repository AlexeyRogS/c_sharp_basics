using System;
using Xunit;
using System.IO;
using Homework;
using System.Collections.Generic;

namespace HomeworkTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ans = new Dictionary<int, string> ();
            ans.Add(5, "5, 4, 3, 2, 1");
            ans.Add(8, "8, 7, 6, 5, 4, 3, 2, 1");
            ans.Add(2, "2, 1");
            ans.Add(1, "1");
            foreach (var e in ans) {
                var s = new StringWriter();
                Class1.Task64(e.Key, s);
                Assert.Equal(e.Value, s.ToString());
            }
        }

        [Fact]
        public void Test2()
        {
            var ans = new Dictionary<Tuple<int,int>, int> ();
            ans.Add(Tuple.Create(1, 15), 120);
            ans.Add(Tuple.Create(4, 8), 30);
            ans.Add(Tuple.Create(4, 4), 4);
            foreach (var e in ans) {
                int M = e.Key.Item1;
                int N = e.Key.Item2;
                Assert.Equal(e.Value, Class1.Task66(M, N));
            }
        }

        [Fact]
        public void Test3()
        {
            var ans = new Dictionary<Tuple<int,int>, int> ();
            ans.Add(Tuple.Create(2, 3), 9);
            ans.Add(Tuple.Create(3, 2), 29);
            foreach (var e in ans) {
                int M = e.Key.Item1;
                int N = e.Key.Item2;
                Assert.Equal(e.Value, Class1.Task68(M, N));
            }
        }
    }
}
