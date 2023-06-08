using Microsoft.AspNetCore.Mvc;

namespace DotnetTutorials.webapi.Controllers;
[ApiController]
[Route("[controller]")]
public class TimoutTest : ControllerBase
{
    [HttpGet(Name = "GetTimeout")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

}