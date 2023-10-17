using Newtonsoft.Json;

namespace WeatherApp.Models.Models
{
    public class CurrentDataForecast : ForecastDataBase
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
    }
}
