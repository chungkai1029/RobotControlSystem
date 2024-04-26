using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;

namespace RobotControlSystem.Controllers
{
    [Route("amr")]
    [ApiController]
    public class AmrController : ControllerBase
    {
        [HttpGet("onlineAmr")]
        public ActionResult OnlineAmr()
        {
            return Ok();
        }

        [HttpPost("taskCommand/pause/{amrId}")]
        public ActionResult AmrTaskCommandPause([FromBody] AmrTaskCommandPauseRequest amrTaskCommandPauseRequest)
        {
            return Ok();
        }

        [HttpPost("taskCommand/resume/{amrId}")]
        public ActionResult AmrTaskCommandResume([FromBody] AmrTaskCommandResumeReqeust amrTaskCommandResumeReqeust)
        {
            return Ok();
        }
    }
}
