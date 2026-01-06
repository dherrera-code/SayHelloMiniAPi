using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sayHelloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpPost]
        [Route("InputName")]
        public string SayHello(string name)
        {
            return $"Hello, {name}!";
        }
    }
}