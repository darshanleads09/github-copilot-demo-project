using System.Collections.Generic;
using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private readonly IWeatherForecastService _service;
        public WeatherForecastController(IWeatherForecastService service) {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<WeatherForecast> Get() {
            return _service.GetForecasts();
        }
    }
}
