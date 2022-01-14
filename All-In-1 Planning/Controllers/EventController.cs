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