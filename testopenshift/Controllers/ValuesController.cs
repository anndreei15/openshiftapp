﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testopenshift.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]

    public class ValuesController : ControllerBase
    {
        
        // GET api/values
        [HttpGet]
        public string Get()
        { 
            return  ("Welcome!" +  
                "Please add this at the end of link:  " +  
                " /student/create  " +  " /horde/create/Fekete?prenume=Andrei           " +
                " /student/edit    "+  " /horde/edit/Fekete?prenume=Andrei              " +
                " /student/details  "+ " /horde/details/Fekete                          "+
                " /student/delete   " + " /horde/create/Fekete                     " 

           ) ;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
