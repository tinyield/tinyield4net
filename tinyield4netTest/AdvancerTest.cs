using com.tinyield;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace tinyield4netTest
{
    public class AdvancerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMap()
        {
            int[] expected = { 3, 5, 4, 8 };
            Query<int> query = Query
                .Of("ola", "super", "isel", "tinyield")
                .Map(word => word.Length);
            int actual = default;
            int index = 0;
            while (query.TryAdvance(i => actual = i))
            {
                Assert.AreEqual(expected[index], actual);
                index++;
            }
        }

        [Test]
        public void TestSorted()
        {
            int[] expected = { 3, 4, 5, 8 };
            Query<int> query = Query
                .Of("ola", "super", "isel", "tinyield")
                .Map(word => word.Length)
                .Sorted((a, b) => a - b);
            int actual = default;
            int index = 0;
            while (query.TryAdvance(i => actual = i))
            {
                Assert.AreEqual(expected[index], actual);
                index++;
            }
        }

        [Test]
        public void TestFilter()
        {
            int expected1 = 5,
                expected2 = 8;
            int actual1 = 0, actual2 = 0;
            Query<int> source = Query
                .Of("ola", "super", "isel", "tinyield")
                .Map(word => word.Length)
                .Filter(i => i > 4);
            Assert.IsTrue(source.TryAdvance(i => actual1 = i));
            Assert.IsTrue(source.TryAdvance(i => actual2 = i));
            Assert.IsFalse(source.TryAdvance(i => actual2 = i));
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [Test]
        public void TestSkipLimitAny()
        {
            int expected = 5;
            int actual = Query
                .Iterate(0, i => i + 1)
                .Skip(5)
                .Limit(3)
                .FindAny();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPeekTakeWhile()
        {
            List<int> peeked = new List<int>(5);
            int i = 0;
            long expectedSize = 5;
            Query<int> query = Query
                .Generate(() => i++)
                .Peek(elem => peeked.Add(elem))
                .TakeWhile(elem => elem < 5);

            int[] expected = { 0, 1, 2, 3, 4 };
            int actual = default;
            int index = 0;
            while (query.TryAdvance(i => actual = i))
            {
                Assert.AreEqual(expected[index], actual);
                Assert.IsTrue(peeked.Exists(i => i == expected[index]));
                index++;
            }

            Assert.AreEqual(expectedSize + 1, peeked.Count);
            Assert.AreEqual(expectedSize, index);
        }

        [Test]
        public void TestFlatMapDropWhile()
        {
            int expected = 4;
            int expectedCount = 1;
            int count = 0;
            int actual = default;
            Query<int> query = Query.Of(1, 2, 3, 4)
                .FlatMap(i => Query.Of(i))
                .DropWhile(i => i < 4);
            while (query.TryAdvance(i =>
            {
                actual = i;
                count++;
            }))
                ;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, count);
        }

        [Test]
        public void TestZipDistinct()
        {
            long expected = 1;
            long actual = 0;
            Query<int> query = Query.Of(1, 2, 3, 4)
                .Zip(Query.Of(1, 2, 3, 4), (a, b) => a - b)
                .Distinct();
            while (query.TryAdvance(i => actual++)) ;
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(query.TryAdvance(i => actual++));
        }

        [Test]
        public void TestThenAdvancerTraverser()
        {
            int expected = 2;
            int actual = Query.FromEnumerable(new List<int>() { 1, 2 })
                .Concat(Query.Of(3, 4))
                .Then<int>(
                    q => yld => q.TryAdvance(i => yld(i * 2)),
                    q => yld => q.Traverse(i => yld(i * 2))
                )
                .FindAny();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestThenTraverser()
        {
            Query<int> query = Query.Of(1, 2, 3, 4)
                .Then<int>(q => yld => q.Traverse(i => yld(i * 2)));
            Assert.Throws<InvalidOperationException>(() => query.TryAdvance(i => { }));
        }

    }
}