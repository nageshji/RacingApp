using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace RacingApp.Models
{
    public class Price
    {
        public string priceType { get; set; }

        [JsonProperty(PropertyName="horses")]
        public HorsePrices HorsePrices { get; set; }
    }
}
