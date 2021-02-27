using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqBenchmarks.Last.FM
{

    public class Artists
    {
        public readonly Dictionary<String, Artist[]> data;

        public Artists(Countries countries)
        {
            data = new Dictionary<string, Artist[]>();
            countries.data.ForEach(country =>
            {
                string name = country.name;
                Artist[] artists = new Artist[0];
                try
                {
                    artists = System.Text.Json.JsonSerializer.Deserialize<Artist[]>(File.ReadAllLines(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\..\\..\\Last.FM\\Resources\\artists\\" + name + ".json")).Aggregate((s1, s2) => s1 + s2));
                }
                catch (Exception e)
                {
                    // Console.Error.WriteLine("Could not load data for country: " + name);
                }
                data.Add(country.name, artists);
            }
            );
        }
    }

    public class Artist
    {
        public string name { get; set; }
        public string listeners { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public string streamable { get; set; }
        public Image[] image { get; set; }
    }

    public class Image
    {
        public string text { get; set; }
        public string size { get; set; }
    }

}
