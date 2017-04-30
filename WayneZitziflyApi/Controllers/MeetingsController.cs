using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WayneZitziflyApi.Model;

namespace WayneZitziflyApi.Controllers
{
    [Route("api/[controller]")]
    public class MeetingsController : Controller
    {
        [HttpGet]
        public IEnumerable<Meeting> GetAllMeetings()
        {
            return new List<Meeting>();
        }

        [HttpGet]
        public IActionResult GetMeeting()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateMeeting()
        {
            return Ok("");
        }
    }
}