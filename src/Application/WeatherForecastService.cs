using System;
using System.Collections.Generic;
using Domain;

namespace Application {
    public class WeatherForecastService : IWeatherForecastService {
        public IEnumerable<WeatherForecast> GetForecasts() {
            return new List<WeatherForecast> {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Warm" },
                new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 28, Summary = "Hot" }
            };
        }
    }
}
