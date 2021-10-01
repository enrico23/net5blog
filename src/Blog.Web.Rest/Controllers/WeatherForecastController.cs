using System.Collections.Concurrent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Web.Rest.Representations;
using Microsoft.Extensions.Options;

namespace Blog.Web.Rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly PositionOptions _options;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IOptions<PositionOptions> options)
        {
            _logger = logger;
            _options = options.Value;
        }

        [HttpGet]
        public IEnumerable<LocalizedWeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new LocalizedWeatherForecast
            {
                Title = _options.Title,
                Name = _options.Name,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
