using com.tinyield;
using NUnit.Framework;
using System.Collections.Generic;

namespace tinyield4netTest
{
    public class Tests
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
        public void TestFilterBulk()
        {
            int[] expected = { 5, 8 };
            IList<int> actual = Query
                .Of("ola", "super", "isel", "tinyield")
                .Map(word => word.Length)
                .Filter(i => i > 4)
                .ToList();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFilterAdvance()
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
    }
}