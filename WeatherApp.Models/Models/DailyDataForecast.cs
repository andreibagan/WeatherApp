using Newtonsoft.Json;

namespace WeatherApp.Models.Models
{
    public class DailyDataForecast : ForecastDataBase
    {
        [JsonProperty("temperatureLow")]
        public double TemperatureLow { get; set; }

        [JsonProperty("temperatureHigh")]
        public double TemperatureHigh { get; set; }
    }
}
