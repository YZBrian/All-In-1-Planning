using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_In_1_Planning.Models;
using Microsoft.Extensions.Logging;

namespace All_In_1_Planning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        private static readonly string[] Descriptions = new[]
        {
            "Feestje Anne-Linde.", "Venom Let There Be Carnage", "Tandarts", "Kapper", "School Meeting", "Uiteten met Rachèl", "Wintersport", "Pokemon BD & SP Release", "Life Beyond 3"
        };

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Event
            {
                Id = rng.Next(0, 11),
                DateTime = new DateTime(2021, rng.Next(1, 13), rng.Next(29), rng.Next(12), rng.Next(60), rng.Next(60)),
                Description = Descriptions[rng.Next(Descriptions.Length)]
            })
            .ToArray();
        }
    }
}