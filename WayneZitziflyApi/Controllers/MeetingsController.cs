using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WayneZitziflyApi.Model;
using WayneZitziflyApi.Repositories;

namespace WayneZitziflyApi.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly IMeetingRepository _repository;

        public MeetingsController(IMeetingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("api/meeting/all")]
        public IEnumerable<Meeting> GetAllMeetings()
        {
            return new List<Meeting>();
        }

        [HttpGet, Route("api/meeting/{id}")]
        public IActionResult GetMeeting(int id)
        {
            return Ok(id);
        }

        [HttpPost, Route("api/meeting")]
        public IActionResult CreateMeeting(CreateMeetingRequest request)
        {
            return Ok("");
        }
    }
}