﻿using BenchmarkDotNet.Attributes;
using com.tinyield;
using JM.LinqFaster;
using NetFabric.Hyperlinq;
using StructLinq;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.Array.Int32
{
    public partial class ArrayInt32WhereSelectToList : ArrayInt32BenchmarkBase
    {
        [Benchmark(Baseline = true)]
        public List<int> ForLoop()
        {
            var list = new List<int>();
            var array = source;
            for (var index = 0; index < array.Length; index++)
            {
                var item = array[index];
                if (item.IsEven())
                    list.Add(item * 2);
            }
            return list;
        }

        [Benchmark]
        public List<int> ForeachLoop()
        {
            var list = new List<int>();
            foreach (var item in source)
            {
                if (item.IsEven())
                    list.Add(item * 2);
            }
            return list;
        }

        [Benchmark]
        public List<int> Linq()
            => System.Linq.Enumerable.Where(source, item => item.IsEven()).Select(item => item * 2).ToList();

        [Benchmark]
        public List<int> LinqFaster()
            => new List<int>(source.WhereSelectF(item => item.IsEven(), item => item * 2));

        [Benchmark]
        public List<int> LinqAF()
            => global::LinqAF.ArrayExtensionMethods.Where(source, item => item.IsEven()).Select(item => item * 2).ToList();

        [Benchmark]
        public List<int> StructLinq()
            => source.ToStructEnumerable()
                .Where(item => item.IsEven())
                .Select(item => item * 2)
                .ToList();

        [Benchmark]
        public List<int> StructLinq_IFunction()
        {
            var predicate = new Int32IsEven();
            var selector = new DoubleOfInt32();
            return source.ToStructEnumerable()
                .Where(ref predicate, x => x)
                .Select(ref selector, x => x, x => x)
                .ToList(x => x);
        }

        [Benchmark]
        public List<int> Hyperlinq()
            => ArrayExtensions.Where(source, item => item.IsEven()).Select(item => item * 2).ToList();

        [Benchmark]
        public List<int> Hyperlinq_IFunction()
            => ArrayExtensions.Where<int, Int32IsEven>(source).Select<int, DoubleOfInt32>().ToList();

        [Benchmark]
        public IList<int> Tinyield()
        {
            return Query.Of(source)
                .Filter(i => i.IsEven())
                .Map(item => item * 2)
                .ToList();
        }
    }
}