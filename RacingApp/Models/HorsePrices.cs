using Newtonsoft.Json;

namespace RacingApp.Models
{
    public class HorsePrices
    {
        [JsonProperty(PropertyName = "horse")]
        public HorsePrice[] HorsePrice { get; set; }
    }
}