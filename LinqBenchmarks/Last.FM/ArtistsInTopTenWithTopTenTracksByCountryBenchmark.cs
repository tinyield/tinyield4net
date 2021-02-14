using BenchmarkDotNet.Attributes;
using com.tinyield;
using NetFabric.Hyperlinq;
using StructLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBenchmarks.Last.FM
{
    public class ArtistsInTopTenWithTopTenTracksByCountryBenchmark : BenchmarkBase
    {
        private const string ENGLISH = "en";
        private const int TEN = 10;
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

        // [Benchmark(Baseline = true)]
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

                if(isNonEnglishSpeaking)
                {
                    if(artists.data.ContainsKey(country.name) && !artists.data[country.name].IsEmpty())
                    {
                        artistsByCountry.Add(Tuple.Create(country, artists.data[country.name]));
                    }

                    if(tracks.data.ContainsKey(country.name) && !tracks.data[country.name].IsEmpty())
                    {
                        tracksByCountry.Add(Tuple.Create(country, tracks.data[country.name]));
                    }
                }
            }

            List<Tuple<Country,List < Artist >>> query = new List<Tuple<Country, List<Artist>>>();
            for(int i = 0; i < artistsByCountry.Count && i < tracksByCountry.Count; i++)
            {
                List<string> topTenSongsArtistsNames = new List<string>();
                for(int j = 0; j < TEN && j < tracksByCountry[i].Item2.Length; j++)
                {
                    topTenSongsArtistsNames.Add(tracksByCountry[i].Item2[j].artist.name);
                }
                List<Artist> topTenArtists = new List<Artist>();
                for (int j = 0; j < TEN && j < artistsByCountry[i].Item2.Length; j++)
                {
                    if (topTenSongsArtistsNames.Contains(artistsByCountry[i].Item2[j].name))
                    {
                        topTenArtists.Add(artistsByCountry[i].Item2[j]);
                    }
                }
                query.Add(Tuple.Create(artistsByCountry[i].Item1, topTenArtists));
            }

            foreach (var item in query)
            {
                count++;
            }
            return count;
        }

        // [Benchmark]
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
                .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2, r.Item2))
                .Select(triplet => {
                    List<string> topTenSongsArtistsNames = System.Linq.Enumerable.Take(triplet.Item3, TEN)
                                        .Select(track => track.artist.name)
                                        .ToList();

                    List<Artist> topTenArtists = System.Linq.Enumerable.Take(triplet.Item2, TEN)
                                        .Where(artist => topTenSongsArtistsNames.Contains(artist.name))
                                        .ToList();
                    return Tuple.Create(triplet.Item1, topTenArtists);
                });
            foreach (var item in query)
            {
                count++;
            }
            return count;
        }

        // [Benchmark]
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

            var query = artistsByCountry
                .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2, r.Item2))
                .Select(triplet => {
                    List<string> topTenSongsArtistsNames = global::LinqAF.ListExtensionMethods.Take(triplet.Item3, TEN)
                                        .Select(track => track.artist.name)
                                        .ToList();

                    List<Artist> topTenArtists = global::LinqAF.ListExtensionMethods.Take(triplet.Item2, TEN)
                                        .Where(artist => topTenSongsArtistsNames.Contains(artist.name))
                                        .ToList();
                    return Tuple.Create(triplet.Item1, topTenArtists);
                });
            foreach (var item in query)
            {
                count++;
            }
            return count;
        }

        // [Benchmark]
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
            .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2, r.Item2))
            .Select(triplet => {
                List<string> topTenSongsArtistsNames = triplet.Item3
                                    .Take(TEN)
                                    .Select(track => track.artist.name)
                                    .ToList();

                List<Artist> topTenArtists = triplet.Item2
                                    .Take(TEN)
                                    .Where(artist => topTenSongsArtistsNames.Contains(artist.name))
                                    .ToList();
                return Tuple.Create(triplet.Item1, topTenArtists);
            }).ForEach(elem => count++);
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

            artistsByCountry
                    .Zip(tracksByCountry, (l, r) => Tuple.Create(l.Item1, l.Item2, r.Item2))
                    .Map(triplet => {
                IList<String> topTenSongsArtistsNames = triplet.Item3
                        .Limit(TEN)
                        .Map(track => track.artist.name)
                        .ToList();

                IList<Artist> topTenArtists = triplet.Item2
                        .Limit(TEN)
                        .Filter(artist => topTenSongsArtistsNames.Contains(artist.name))
                        .ToList();
                return Tuple.Create(triplet.Item1, topTenArtists);
            }).Traverse(elem => count ++);
            return count;
        }
    }
}
