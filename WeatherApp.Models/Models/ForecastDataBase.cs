using Newtonsoft.Json;

namespace WeatherApp.Models.Models
{
    public class ForecastDataBase
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }
}
