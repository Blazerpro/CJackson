using Microsoft.AspNetCore.Mvc;

namespace WebMusicRecommendations.Controllers;

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

    [HttpGet("Get")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost("Print")]
    public IActionResult Print([FromBody] PrintRequest requestJson)
    {
        Console.WriteLine(requestJson.Message + requestJson.Message2);
        return new OkResult();
    }
}

public class PrintRequest
{
    public string Message { get; set; }
    public string Message2 { get; set; }

    public PrintRequest(string message, string message2)
    {
        Message = message;
        Message2 = message2;
    }
}

