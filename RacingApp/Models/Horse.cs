using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RacingApp.Models
{
    public class Horse
    {
        [JsonProperty(PropertyName = "@name")]
        public string name { get; set; }
        public string country { get; set; }
        public string age { get; set; }
        public string sex { get; set; }
        public string colour { get; set; }
        public string foaling_date { get; set; }
        public string id { get; set; }       
        public int number { get; set; }
        public Trainer trainer { get; set; }
        public string training_location { get; set; }
        public string owners { get; set; }
        public string colours { get; set; }
        public string current_blinker_ind { get; set; }
        public string prizemoney_won { get; set; }
        public Jockey jockey { get; set; }
        public string barrier { get; set; }
        public Weight weight { get; set; }
        public string last_four_starts { get; set; }
        public string last_ten_starts { get; set; }
        [JsonProperty(PropertyName = "@Price")]
        public decimal Price { get; set; }
    }
}
