using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqBenchmarks.Last.FM
{

    public class Tracks
    {
        public readonly Dictionary<String, Track[]> data;

        public Tracks(Countries countries)
        {
            data = new Dictionary<string, Track[]>();
            countries.data.ForEach(country =>
            {
                string name = country.name;
                Track[] tracks = new Track[0];
                try
                {
                    tracks = System.Text.Json.JsonSerializer.Deserialize<Track[]>(File.ReadAllLines(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\..\\..\\Last.FM\\Resources\\Tracks\\" + name + ".json")).Aggregate((s1, s2) => s1 + s2));
                }
                catch (Exception e)
                {
                    // Console.Error.WriteLine("Could not load data for country: " + name);
                }
                data.Add(country.name, tracks);
            }
            );
        }
    }

    public class Streamable
    {
        [JsonProperty("#text")]
        public string Text { get; set; }
        public string fulltrack { get; set; }
    }

    public class Attr
    {
        public string rank { get; set; }
    }

    public class Track
    {
        public string name { get; set; }
        public string duration { get; set; }
        public string listeners { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public Streamable streamable { get; set; }
        public Artist artist { get; set; }
        public List<Image> image { get; set; }
        [JsonProperty("@attr")]
        public Attr Attr { get; set; }
    }


}
