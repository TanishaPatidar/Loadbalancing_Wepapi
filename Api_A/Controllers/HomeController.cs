using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_A.Controllers
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
                return "Api A - get Running";
            }
            catch (Exception ex)
            {
                return "Api A - get Exception";
            }
        }

        [HttpGet("checkapi")]
        public string CheckApi()
        {
            try
            {
                return "Api A - CheckApi Running";
            }
            catch (Exception ex)
            {
                return "Api A - CheckApi Exception";
            }
        }
    }
}
