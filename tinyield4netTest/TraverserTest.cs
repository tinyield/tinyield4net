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
                .of("ola", "super", "isel", "tinyield")
                .Map(word => word.Length)
                .ToList();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}