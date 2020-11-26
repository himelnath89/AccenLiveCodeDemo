using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunFridayAPI.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunFridayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public readonly FunFridayDBContext funfridaydbContext;
        public EventsController(FunFridayDBContext db)
        {
        funfridaydbContext = db;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var events = funfridaydbContext.Events.Select(e => e.Name);
            //return events.ToList();
            return new string[] { "Hello", "Hai" };
        }
     }
}
