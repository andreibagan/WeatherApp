using Newtonsoft.Json;

namespace WeatherApp.Models.Models
{
    public class Weather
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("currently")]
        public CurrentDataForecast CurrentForecast { get; set; }

        [JsonProperty("daily")]
        public DailyDataForecast DailyForecast { get; set; }
    }
}
