using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;

namespace evetool.core
{
    public static class EVEData
    {
        public static void LoadData(string path)
        {
            var location = System.Reflection.Assembly.GetEntryAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(location);
            Console.WriteLine("正在加载EVE数据库");
            var file = File.ReadAllText(directory+"/"+path);
            DeserializerBuilder bu = new DeserializerBuilder();
            bu.IgnoreUnmatchedProperties();
            var deserializer = bu.Build();
            ShipNames = deserializer.Deserialize<Dictionary<int, typeIDs>>(file);
            Console.WriteLine("加载完成");
        }
        public static Dictionary<int, typeIDs> ShipNames { get; set; }

    }
    public class typeIDs
    {
        public name name { get; set; }

        public double volume { get; set; }
        //public int groupID { get; set; }

        //public double mass { get; set; }

        //public int portionSize { get; set; }

        //public bool published { get; set; }

        //public decimal radius { get; set; }

        //public int graphicID { get; set; }

        //public int soundID { get; set; }

        //public int iconID { get; set; }

        //public int raceID { get; set; }

        //public string sofFactionName { get; set; }

        //public decimal basePrice { get; set; }

        //public int marketGroupID { get; set; }

        //public double capacity { get; set; }

        //public int factionID { get; set; }
    }
    public class name
    {
        public string de { get; set; }
        public string en { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        public string ru { get; set; }
        public string zh { get; set; }

    }
}
