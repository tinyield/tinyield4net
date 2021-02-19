using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBenchmarks.Every
{
    public class EveryBenchString : BenchmarkBase
    {
        public List<String> lstA;
        public List<String> lstB;

        [GlobalSetup]
        public void GlobalSetup() {
            lstB = new List<String>(Count);
            lstA = System.Linq.Enumerable
                .Range(1, Count)
                .Select(v => v.ToString())
                .ToList();
            lstA.ForEach(v => lstB.Add(v));
        }

        [Benchmark]
        public bool ForeachLoop() {
            IEnumerator<String> iterB = lstB.GetEnumerator();
            foreach (String a in lstA) {
                if (!iterB.MoveNext()) return false;
                if(!a.Equals(iterB.Current)) return false;
            }
            return true;
        }

        bool TRUE = true;

        [Benchmark]
        public bool Linq()
        {
            return lstA
                .Zip(lstB, (a, b) => a.Equals(b))
                .All(TRUE.Equals);
        }

        [Benchmark]
        public bool LinqAF()
        {
            return global::LinqAF.IEnumerableExtensionMethods.Zip(lstA, lstB, (a, b) => a.Equals(b))
                .All(TRUE.Equals);
        }

        [Benchmark]
        public bool HyperLinq()
        {
            return ListBindings
                .Select<String, String>(lstA, v => v)
                .Zip(lstB, (a, b) => a.Equals(b))
                .All(TRUE.Equals);
        }

        [Benchmark]
        public bool Tinyield()
        {
            Query<String> b = Query.FromEnumerable(lstB);
            return Query
                .FromEnumerable(lstA)
                .Zip(b, (a, b) => a.Equals(b))
                .AllMatch(TRUE.Equals);
        }
    }
}
