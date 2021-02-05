using com.tinyield;
using NUnit.Framework;
using System;
using System.Collections.Generic;

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
                .Of("ola", "super", "isel", "tinyield")
                .Map(word => word.Length)
                .ToList();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSorted()
        {
            int expected = 8;
            int actual = Query
                .Of("ola", "super", "isel", "tinyield")
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
                .Map(word => word.Length)
                .Filter(i => i > 4)
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
        public void TestConcatNoneFalse()
        {
            Assert.IsFalse(Query.Of(6, 8).Concat(Query.Of(8, 5)).NoneMatch(i => i < 10));
        }

        [Test]
        public void TestConcatAll()
        {
            Assert.IsTrue(Query.Of(6, 8).Concat(Query.Of(8, 5)).AllMatch(i => i < 10));
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
                .FlatMap(i => Query.Of(i))
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
    }
}