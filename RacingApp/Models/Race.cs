using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RacingApp.Models
{
    public class Race
    {
        public string number { get; set; }
        [JsonProperty(PropertyName = "@name")]
        public string name { get; set; }
        public string id { get; set; }
        public string Status { get; set; }
        public string NumberOfRunners { get; set; }
        public string start_time { get; set; }
        public Distance distance { get; set; }
        public Horses horses { get; set; }
        public Prices prices { get; set; }
    }
}
