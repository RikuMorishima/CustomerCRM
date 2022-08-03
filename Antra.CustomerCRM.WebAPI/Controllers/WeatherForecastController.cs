using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        [Route("getname/{name}")]
        public string GetMessageWithName(string name)
        {
            return $"Welcome {name}";
        }

        [HttpGet]
        [Route("GetList")]
        public IActionResult GetList()
        {
            return Ok(new List<string>() { "1","2","3" });

        }

        [HttpGet]
        [Route("GetById/{id:int:max(5):min(1)}")]
        public IActionResult GetById(int id)
        {
            return Ok(id);
        }

        [HttpGet]
        [Route("GetByParams")]
        public IActionResult GetByParams(int id=-1, string name="na")
        {
            return Ok($"name={name},id={id}");
        }

        [HttpPost]
        [Route("InsertValue")]
        public IActionResult InsertValue(int value)
        {
            return Ok($"Value Recieved: {value}");
        }

        [HttpPost]
        [Route("InsertValueBody")]
        public IActionResult InsertValueBody([FromBody]int value)
        {
            return Ok($"Value Recieved: {value}");
        }

    }
}