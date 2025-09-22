using System.Collections.Generic;
using Domain;

namespace Application {
    public interface IWeatherForecastService {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}
