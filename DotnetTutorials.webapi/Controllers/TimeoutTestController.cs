using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetTutorials.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeoutTestController : ControllerBase
    {
        [HttpGet(Name = "GetCNN")]
        public async Task<string> Get()
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3));
            Task timeoutTask = Task.Delay(TimeSpan.FromSeconds(20));
            
            return "Success";
        }
    }
}
