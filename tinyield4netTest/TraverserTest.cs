using com.tinyield;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace tinyield4netTest
{
    public class TraverserTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMap()
        {
            int[] expected = { 3, 5, 4, 8 };
            IList<int> actual = Query
                .Of("super", "isel", "tinyield")
                .Prepend("ola")
                .Map(word => word.Length)
                .ToList();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestLast()
        {
            string expected = "tinyield";
            string actual = Query
                .Of("super", "isel", "tinyield")
                .Prepend("ola")
                .LastOrDefault();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSorted()
        {
            int expected = 8;
            int actual = Query
                .Of("ola", "super", "isel")
                .Append("tinyield")
                .Map(word => word.Length)
                .Sorted((a, b) => a - b)
                .Max((a, b) => b - a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestLimit()
        {
            Assert.Throws<InvalidOperationException>(() => Query.Of(0).Limit(0).Traverse(i => { }));
        }

        [Test]
        public void TestFilter()
        {
            int[] expected = { 5, 8 };

            ISet<int> actual = Query
                .FromEnumerable(new List<string>() { "ola", "super", "isel", "tinyield" })
                .Map(word => word.Length)
                .Filter(i => i > 4)
                .ToSet();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestEmptyCount()
        {
            Assert.AreEqual(Query.Empty<object>().Count(), 0);
        }

        [Test]
        public void TestSkipLimit()
        {
            int[] expected = { 5, 6, 7 };
            int[] actual = Query
                .Iterate(0, i => i + 1)
                .Skip(5)
                .Limit(3)
                .ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void TestCount()
        {
            long expected = 2;
            long actual = Query
                .Of("ola", "super", "isel", "tinyield")
                .Select(word => word.Length)
                .Where(i => i > 4)
                .Cast<Int32>()
                .Count();
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void TestPeekTakeWhile()
        {
            List<int> peeked = new List<int>(5);
            int i = 0;
            long expected = 5;
            long actual = Query
                .Generate(() => i++)
                .Peek(elem => peeked.Add(elem))
                .TakeWhile(elem => elem < 5)
                .Count();
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected + 1, peeked.Count);
        }

        [Test]
        public void TestConcatMin()
        {
            int expected = 5;
            int actual = Query.Of(6, 8).Concat(Query.Of(8, 5)).Min((a, b) => b - a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestConcatNone()
        {
            Assert.IsTrue(Query.Of(6, 8).Concat(Query.Of(8, 5)).NoneMatch(i => i > 10));
        }

        [Test]
        public void TestConcatAnyFalse()
        {
            Assert.IsFalse(Query.Of(6, 8).Concat(Query.Of(8, 5)).Any(i => i > 10));
        }

        [Test]
        public void TestConcatNoneFalse()
        {
            Assert.IsFalse(Query.Of(6, 8).Concat(Query.Of(8, 5)).NoneMatch(i => i < 10));
        }

        [Test]
        public void TestConcatAny()
        {
            Assert.IsTrue(Query.Of(6, 8).Concat(Query.Of(8, 5)).Any(i => i < 10));
        }

        [Test]
        public void TestConcatAll()
        {
            Assert.IsTrue(Query.Of(6, 8).Concat(Query.Of(8, 5)).All(i => i < 10));
        }

        [Test]
        public void TestConcatAllFalse()
        {
            Assert.IsFalse(Query.Of(6, 8).Concat(Query.Of(8, 5)).AllMatch(i => i > 10));
        }

        [Test]
        public void TestFlatMapDropWhile()
        {
            int expected = 4;
            int expectedCount = 1;
            int count = 0;
            int actual = default;
            Query.Of(1, 2, 3, 4)
                .Skip(1)
                .SelectMany(i => Query.Of(i))
                .DropWhile(i => i < 4)
                .ForEach(i =>
                {
                    actual = i;
                    count++;
                });
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, count);
        }

        [Test]
        public void TestZipDistinct()
        {
            long expected = 1;
            long actual = Query.Of(1, 2, 3, 4)
                .Zip(Query.Of(1, 2, 3, 4), (a, b) => a - b)
                .Distinct()
                .Count();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestJoin()
        {
            string expected = "1234";
            string actual = Query.Of(1, 2, 3, 4).Join();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAggregate()
        {
            string expected = "1234";
            string actual = Query.Of(1, 2, 3, 4)
                .Select(elem => Convert.ToString(elem))
                .Aggregate(() => new StringBuilder(), (sb, elem) => sb.Append(elem))
                .ToString();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReduce()
        {
            int expected = 10;
            int actual = Query.Of(1, 2, 3, 4).Reduce((a, b) => a + b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestThenTraverser()
        {
            string expected = "2468";
            string actual = Query.Of(1, 2, 3, 4)
                .Then<int>(q => yld => q.Traverse(i => yld(i * 2)))
                .Join();
            Assert.AreEqual(expected, actual);
        }

        Traverser<T> Collapse<T>(Query<T> src)  {
            return yld => {
                T prev = default(T);
                src.ForEach(item => {
                    if (prev.Equals(default(T)) || !prev.Equals(item))
                    {
                        prev = item;
                        yld(item);
                    }
                });
            };
        }

        [Test]
        public void TestThenCollapse()
        {
            List<int> expected = new List<int>(new int[] { 7, 9, 11, 7 });
            int[] arrange = new int[] { 7, 7, 8, 9, 9, 11, 11, 7 };
            List<int> actual = new List<int>();
            Query.Of(arrange)
                .Then(n => Collapse(n))
                .Where(n => n % 2 != 0)
                .ForEach(value => actual.Add(value));

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestThenAdvancerTraverser()
        {
            string expected = "2468";
            string actual = Query.Of(1, 2, 3, 4)
                .Then<int>(
                    q => yld => q.TryAdvance(i => yld(i * 2)),
                    q => yld => q.Traverse(i => yld(i * 2))
                )
                .Join();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestTakeWhile()
        {
            long expected = 3;
            long actual = Query.Iterate(0, i => i + 1)
                .TakeWhile(i => i < 3)
                .Count();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTake()
        {
            long expected = 3;
            long actual = Query.Range(0, 1000)
                .Take(3)
                .Count();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSumInt()
        {
            long expected = 10;
            long actual = Query.Repeat<int>(1, 10)
                .Sum();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSumDouble()
        {
            double expected = 10;
            double actual = Query.Repeat<double>(1, 10)
                .Sum();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSumFloat()
        {
            float expected = 10;
            float actual = Query.Repeat<float>(1, 10)
                .Sum();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAverageInt()
        {
            double expected = 1;
            double actual = Query.Repeat<int>(1, 10)
                .Average();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAverageDouble()
        {
            double expected = 1;
            double actual = Query.Repeat<double>(1, 10)
                .Average();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAverageFloat()
        {
            double expected = 1;
            double actual = Query.Repeat<float>(1, 10)
                .Average();
            Assert.AreEqual(expected, actual);
        }
    }
}