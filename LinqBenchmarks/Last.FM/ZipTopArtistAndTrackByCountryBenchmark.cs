using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using StructLinq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBenchmarks.Last.FM
{
    public class ZipTopArtistAndTrackByCountryBenchmark : BenchmarkBase
    {
        private const string ENGLISH = "en";
        private Countries countries;
        private Artists artists;
        private Tracks tracks;

        [GlobalSetup]
        public void GlobalSetup()
        {
            countries = new Countries();
            artists = new Artists(countries);
            tracks = new Tracks(countries);
        }

        [Benchmark(Baseline = true)]
        public int ForeachLoop()
        {
            var count = 0;
            var artistsByCountry = new List<Tuple<Country, Artist[]>>();
            var tracksByCountry = new List<Tuple<Country, Track[]>>();
            foreach (var country in countries.data)
            {
                bool isNonEnglishSpeaking = true;
                for (int i = 0; i < country.languages.Count() && isNonEnglishSpeaking; i++)
                {
                    isNonEnglishSpeaking = isNonEnglishSpeaking && !ENGLISH.Equals(country.languages[i].iso639_1);
                }

                if (isNonEnglishSpeaking)
                {
                    if (artists.data.ContainsKey(country.name) && !artists.data[country.name].IsEmpty())
                    {
                        artistsByCountry.Add(Tuple.Create(country, artists.data[country.name]));
                    }

                    if (tracks.data.ContainsKey(country.name) && !tracks.data[country.name].IsEmpty())
                    {
                        tracksByCountry.Add(Tuple.Create(country, tracks.data[country.name]));
                    }
                }
            }

            var artistsNames = new HashSet<string>();
            List<Tuple<Country, Artist, Track>> query = new List<Tuple<Country, Artist, Track>>();
            for (int i = 0; i < artistsByCountry.Count && i < tracksByCountry.Count; i++)
            {
                var tuple = Tuple.Create(artistsByCountry[i].Item1, artistsByCountry[i].Item2.First().Value, tracksByCountry[i].Item2.First().Value);

                if (artistsNames.Add(tuple.Item2.name))
                {
                    query.Add(tuple);
                }
            }

            foreach (var item in query)
            {
                count++;
            }
            return count;
        }

        [Benchmark]
        public int Linq()
        {
            var count = 0;
            Predicate<Country> isNonEnglishSpeaking = country => !System.Linq.Enumerable
                .Select(country.languages, language => language.iso639_1)
                .Any(language => ENGLISH.Equals(language));

            var artistsByCountry = System.Linq.Enumerable
                .Where(countries.data, country => isNonEnglishSpeaking(country))
                .Where(country => artists.data.ContainsKey(country.name) && !artists.data[country.name].IsEmpty())
                .Select(country => Tuple.Create(country, artists.data[country.name]));
            var tracksByCountry = System.Linq.Enumerable
                .Where(countries.data, country => isNonEnglishSpeaking(country))
                .Where(country => tracks.data.ContainsKey(country.name) && !tracks.data[country.name].IsEmpty())
                .Select(country => Tuple.Create(country, tracks.data[country.name]));

            var query = artistsByCountry
                .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2.First().Value, r.Item2.First().Value))
                .Distinct(item => item.Item2.name);
            foreach (var item in query)
            {
                count++;
            }
            return count;
        }

        [Benchmark]
        public int LinqAF()
        {
            var count = 0;
            Predicate<Country> isNonEnglishSpeaking = country => !global::LinqAF.LinqAFNew.List(country.languages)
                .Select(language => language.iso639_1)
                .Any(language => ENGLISH.Equals(language));

            var artistsByCountry = global::LinqAF.ArrayExtensionMethods
                .Where(countries.data, country => isNonEnglishSpeaking(country))
                .Where(country => artists.data.ContainsKey(country.name) && !artists.data[country.name].IsEmpty())
                .Select(country => Tuple.Create(country, global::LinqAF.LinqAFNew.List(artists.data[country.name])));
            var tracksByCountry = global::LinqAF.ArrayExtensionMethods
                .Where(countries.data, country => isNonEnglishSpeaking(country))
                .Where(country => tracks.data.ContainsKey(country.name) && !tracks.data[country.name].IsEmpty())
                .Select(country => Tuple.Create(country, global::LinqAF.LinqAFNew.List(tracks.data[country.name])));
            var artistNames = new HashSet<string>();
            var query = artistsByCountry
                .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2.First().Value, r.Item2.First().Value))
                .Where(tuple => artistNames.Add(tuple.Item2.name));
            foreach (var item in query)
            {
                count++;
            }
            return count;
        }

        [Benchmark]
        public int Hyperlinq()
        {
            var count = 0;
            Predicate<Country> isNonEnglishSpeaking = country => !country.languages.AsValueEnumerable()
                .Select(language => language.iso639_1)
                .Any(language => ENGLISH.Equals(language));

            var artistsByCountry = ArrayExtensions.Where(countries.data, country => isNonEnglishSpeaking(country))
                .Where(country => artists.data.ContainsKey(country.name) && !artists.data[country.name].IsEmpty())
                .Select(country => Tuple.Create(country, artists.data[country.name].AsValueEnumerable()));
            var tracksByCountry = ArrayExtensions.Where(countries.data, country => isNonEnglishSpeaking(country))
                .Where(country => tracks.data.ContainsKey(country.name) && !tracks.data[country.name].IsEmpty())
                .Select(country => Tuple.Create(country, tracks.data[country.name].AsValueEnumerable()));
            artistsByCountry
            .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2.First().Value, r.Item2.First().Value))
            .Distinct(tuple => tuple.Item2.name)
            .ForEach(elem => count++);
            return count;
        }

        [Benchmark]
        public int Tinyield()
        {
            var count = 0;
            Predicate<Country> isNonEnglishSpeaking = country => Query.FromEnumerable(country.languages)
                            .Map(language => language.iso639_1)
                            .NoneMatch(language => ENGLISH.Equals(language));

            Query<Tuple<Country, Query<Artist>>> artistsByCountry = Query.Of(countries.data)
                    .Filter(isNonEnglishSpeaking)
                    .Filter(country => artists.data.ContainsKey(country.name) && !artists.data[country.name].IsEmpty())
                    .Map(country => Tuple.Create(country, Query.Of(artists.data[country.name])));

            Query<Tuple<Country, Query<Track>>> tracksByCountry = Query.Of(countries.data)
                    .Filter(isNonEnglishSpeaking)
                    .Filter(country => tracks.data.ContainsKey(country.name) && !tracks.data[country.name].IsEmpty())
                    .Map(country => Tuple.Create(country, Query.Of(tracks.data[country.name])));
            HashSet<string> artistNames = new HashSet<string>();
            artistsByCountry
                    .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2.FindFirst(), r.Item2.FindFirst()))
                    .Filter(tuple => artistNames.Add(tuple.Item2.name))
                    .Traverse(elem => count++);
            return count;
        }
    }
}
