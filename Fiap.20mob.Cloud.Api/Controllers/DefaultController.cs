using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap._20mob.Cloud.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return ViewResult(@"
<!doctype html>
<html>
<head>
  <meta charset='utf-8'>
  <title>FIAP</title>
  <meta name='viewport' content='width=device-width, initial-scale=1'>
</head>
<body>
                
</body>
</html>
            ");
        }
    }
}