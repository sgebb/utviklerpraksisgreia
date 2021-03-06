﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CxApi.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET api/hello
        [HttpGet]
        public string  Get()
        {
            return "hello lol";
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return String.Format("Hello {0}", name);
        }

    }
}
