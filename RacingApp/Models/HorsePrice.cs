using Newtonsoft.Json;

namespace RacingApp.Models
{
    public class HorsePrice
    {
        [JsonProperty(PropertyName="@number")]
        public int HorseNumber { get; set; }
        [JsonProperty(PropertyName = "@Price")]
        public decimal Price { get; set; }
    }
}