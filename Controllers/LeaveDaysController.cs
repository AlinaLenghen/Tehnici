using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly ILogger<LeaveRequestsController> _logger;

        public LeaveRequestsController(ILogger<LeaveRequestsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLeaveRequests")]
        public IEnumerable<LeaveRequest> Get()
        {
            // Generate some sample leave requests
            return Enumerable.Range(1, 5).Select(index => new LeaveRequest
            {
                StartDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index + 5)),
                Type = (LeaveType)new Random().Next(Enum.GetValues(typeof(LeaveType)).Length)
            })
            .ToArray();
        }
    }
}
