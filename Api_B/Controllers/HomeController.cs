using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_B.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            try
            {
                return "Api B - get";
            }
            catch (Exception ex)
            {
                return "Api B - get Exception";
            }
        }

        [HttpGet("checkapi")]
        public string CheckApi()
        {
            try
            {
                return "Api B - CheckApi Running";
            }
            catch (Exception ex)
            {
                return "Api B - CheckApi Exception";
            }
        }
    }
}
