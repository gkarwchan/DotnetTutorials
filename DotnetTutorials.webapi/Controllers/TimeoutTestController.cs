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
    }
}
