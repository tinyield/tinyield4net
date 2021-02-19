using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using StructLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBenchmarks.Weather
{
    public class QueryNrOfTemperatureTransitions : BenchmarkBase
    {

        string[] source;

        [GlobalSetup]
        public void GlobalSetup()
            => source = File.ReadAllLines(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\..\\..\\Weather\\Resources\\q-Lisbon_format-csv_date-2020-05-08_enddate-2020-11-08"));

        [Benchmark(Baseline = true)]
        public int ForLoop()
        {
            var array = source;
            var isOdd = false;
            object prev = null;
            var count = 0;
            for (var index = 1; index < array.Length; index++)
            {
                if(array[index].First() != '#')
                {
                    if (isOdd)
                    {
                        var temp = Int32.Parse(array[index].Substring(14, 2));
                        if (prev == null || !prev.Equals(temp))
                        {
                            prev = temp;
                            count++;
                        }
                    }
                    isOdd = !isOdd;
                }
            }
            return count;
        }

        [Benchmark]
        public int ForeachLoop()
        {
            var isOdd = false;
            var first = true;
            object prev = null;
            var count = 0;
            foreach (var item in source)
            {
                if(first)
                {
                    first = false;
                } else
                {
                    if (item.First() != '#')
                    {
                        if (isOdd)
                        {
                            var temp = Int32.Parse(item.Substring(14, 2));
                            if(prev == null || !prev.Equals(temp))
                            {
                                prev = temp;
                                count++;
                            }
                        }
                        isOdd = !isOdd;
                    }
                }
            }
            return count;
        }

        [Benchmark]
        public int Linq()
        {
            return System.Linq.Enumerable.Where(source, s => s.First() != '#')
                .Skip(1)
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Collapse()
                .Count();
        }

        [Benchmark]
        public int LinqAF()
        {
            return global::LinqAF.ArrayExtensionMethods.Where(source, s => s.First() != '#')
                .Skip(1)
                .AsEnumerable()
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Collapse()
                .Count();
        }

        [Benchmark]
        public int Hyperlinq()
        {
            return ArrayExtensions.Where(source, s => s.First() != '#')
                .Skip(1)
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Collapse()
                .Count();
        }

        [Benchmark]
        public long Tinyield()
        {
            return Query.Of(source)
                .Filter(s => s.First() != '#')
                .Skip(1)
                .Then(Extensions.OddLines)
                .Map(s => Int32.Parse(s.Substring(14, 2)))
                .Then(Extensions.Collapse)
                .Count();
        }
    }
}
