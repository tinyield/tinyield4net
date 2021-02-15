using LinqBenchmarks.SameFringe;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinyield4netTest
{
    public class SameFringeTest
    {
		[Test]
		public void TestTraverserAndAdvancer()
		{
			var rnd = new Random(110456);
			var randList = Enumerable.Range(0, 20).Select(i => rnd.Next(1000)).ToList();
			var bt1 = new BinTree<int>(randList);
			var adv = bt1.Advancer();
			bt1.Traverse(item1 =>
			{
                bool res = adv(item2 => Assert.AreEqual(item1, item2));
				Assert.True(res);
			});
			Assert.False(adv(ignore => { }));
		}


		[Test]
        public void TestSameFringe()
        {
			var rnd = new Random(110456);
			var randList = Enumerable.Range(0, 20).Select(i => rnd.Next(1000)).ToList();
			var bt1 = new BinTree<int>(randList);
			// Shuffling will create a tree with the same values but different topology
			Shuffle(randList, 428);
			var bt2 = new BinTree<int>(randList);
			Assert.AreEqual(true, bt1.CompareTo(bt2));
			bt1.Insert(0);
			Assert.AreEqual(false, bt1.CompareTo(bt2));

		}

		static void Shuffle<T>(List<T> values, int seed)
		{
			var rnd = new Random(seed);

			for (var i = 0; i < values.Count - 2; i++)
			{
				var iSwap = rnd.Next(values.Count - i) + i;
				var tmp = values[iSwap];
				values[iSwap] = values[i];
				values[i] = tmp;
			}
		}
	}
}
