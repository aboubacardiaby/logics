using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web.Models;

namespace web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        
       
        
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var pers = new Person(); 
            var persons= pers.CreatePersons();
            return persons;
            
        }
    }
}
