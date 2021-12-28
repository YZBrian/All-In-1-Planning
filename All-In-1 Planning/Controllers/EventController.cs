using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_In_1_Planning.Models;
using Microsoft.Extensions.Logging;
using All_In_1_Planning.Logic;
using Microsoft.AspNetCore.Http;

namespace All_In_1_Planning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        [HttpPost("CreateEvent")]
        public int CreateEvent(DateTime dateTime, string description, bool hasPriority)
        {
            EventLogic eventLogic = new EventLogic();
            if (eventLogic.CreateEvent(dateTime,description, hasPriority))
            {
                return StatusCodes.Status200OK;
            }
            else
            {
                return StatusCodes.Status500InternalServerError; //No Go!
            }

        }

        [HttpGet("GetAllEvents")]
        public async Task<EventListModel> GetAllEvents()
        {
            EventLogic eventLogic = new EventLogic();
            EventListModel eventListModel = await eventLogic.GetAllEvents();
            return eventListModel;
        }


        private static readonly string[] Descriptions = new[]
        {
            "Feestje Anne-Linde.", "Venom Let There Be Carnage", "Tandarts", "Kapper", "School Meeting", "Uiteten met Rachèl", "Wintersport", "Pokemon BD & SP Release", "Life Beyond 3"
        };

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpDelete("DeleteEvent")]
        public int DeleteEvent(int id)
        {
            EventLogic eventLogic = new EventLogic();
            if (eventLogic.DeleteEvent(id))
            {
                return StatusCodes.Status200OK;
            }
            else
            {
                return StatusCodes.Status500InternalServerError; //No Go!
            }

        }
    }
}