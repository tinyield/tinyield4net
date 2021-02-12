using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using StructLinq;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBenchmarks.Weather
{
    public class QueryMaxTemp : BenchmarkBase
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
            var max = Int32.MinValue;
            for (var index = 1; index < array.Length; index++)
            {
                if(array[index].First() != '#')
                {
                    if (isOdd)
                    {
                        var val = Int32.Parse(array[index].Substring(14, 2));
                        if (val > max)
                        {
                            max = val;
                        }
                    }
                    isOdd = !isOdd;
                }
            }
            return max;
        }

        [Benchmark]
        public int ForeachLoop()
        {
            var isOdd = false;
            var first = true;
            var max = Int32.MinValue;
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
                            var val = Int32.Parse(item.Substring(14, 2));
                            if (val > max)
                            {
                                max = val;
                            }
                        }
                        isOdd = !isOdd;
                    }
                }
            }
            return max;
        }

        [Benchmark]
        public int Linq()
        {
            return System.Linq.Enumerable.Where(source, s => s.First() != '#')
                .Skip(1)
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Max();
        }

        [Benchmark]
        public int LinqAF()
        {
            return global::LinqAF.ArrayExtensionMethods.Where(source, s => s.First() != '#')
                .Skip(1)
                .AsEnumerable()
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Max();
        }

        [Benchmark]
        public int StructLinq()
        {
            return source.ToStructEnumerable()
                .Where(s => s.First() != '#')
                .Skip(1)
                .ToEnumerable()
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Max();
        }

        [Benchmark]
        public int Hyperlinq()
        {
            return ArrayExtensions.Where(source, s => s.First() != '#')
                .Skip(1)
                .OddLines<string>()
                .Select(s => Int32.Parse(s.Substring(14, 2)))
                .Max();
        }

        [Benchmark]
        public int Tinyield()
        {
            return Query.Of(source)
                .Filter(s => s.First() != '#')
                .Skip(1)
                .Then(Extensions.OddLines)
                .Map(s => Int32.Parse(s.Substring(14, 2)))
                .Max((a, b) => b - a);
        }
    }
}
