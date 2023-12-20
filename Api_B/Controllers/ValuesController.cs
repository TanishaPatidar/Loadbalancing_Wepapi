﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api_B.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "From APIServiceA";
        }

        [HttpGet("tani")]
        public string Tani()
        {
            return "From Tanisha A api";
        }
       



    }
}
