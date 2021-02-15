﻿using BenchmarkDotNet.Attributes;
using com.tinyield;
using LinqBenchmarks.Every;
using NetFabric.Hyperlinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBenchmarks.SameFringe
{
    public class SameFringeBench : BenchmarkBase
    {
        public BinTree<Value> btA;
        public BinTree<Value> btB;

        [GlobalSetup]
        public void GlobalSetup() {
            Random rnd = new Random(110456);
            List<Value> randList = System.Linq.Enumerable
                            .Range(0, Count).Select(i => rnd.Next(1000))
                            .Select(v => new Value(v))
                            .ToList();
            btA = new BinTree<Value>(randList);
            Shuffle(randList, 428);
            btB = new BinTree<Value>(randList);
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

        bool TRUE = true;

        [Benchmark]
        public bool ForeachLoop()
        {
            IEnumerator<Value> a = btA.GetLeaves().GetEnumerator();
            IEnumerator<Value> b = btB.GetLeaves().GetEnumerator();
            while (a.MoveNext()) {
                if (!b.MoveNext()) return false;
                if (a.Current.CompareTo(b.Current) != 0) return false;
            }
            if (b.MoveNext()) return false;
            return true;
        }


        [Benchmark]
        public bool Linq()
        {
            return btA
                .GetLeaves()
                .Zip(btB.GetLeaves(), (t1, t2) => t1.CompareTo(t2) == 0)
                .All(f => f);
        }

        [Benchmark]
        public bool HyperLinq()
        {
            return EnumerableExtensions
                .AsValueEnumerable(btA.GetLeaves())
                .Zip(btB.GetLeaves(), (t1, t2) => t1.CompareTo(t2) == 0)
                .All(f => f);
        }

        [Benchmark]
        public bool Tinyield()
        {
            return btA
                .GetLeavesQuery()
                .Zip(btB.GetLeavesQuery(), (t1, t2) => t1.CompareTo(t2) == 0)
                .AllMatch(TRUE.Equals);
        }
    }
}
