using Microsoft.AspNetCore.Mvc;

namespace RobotControlSystem.Controllers
{
    [Route("amr")]
    [ApiController]
    public class AmrController : ControllerBase
    {
        [HttpGet("onlineAmr")]
        public ActionResult OnlineAmr(HttpRequest request)
        {
            return Ok();
        }

        [HttpPost("taskCommand/pause/{amrId}")]
        public ActionResult TaskCommandPause(HttpRequest request)
        {
            return Ok();
        }

        [HttpPost("taskCommand/resume/{amrId}")]
        public ActionResult TaskCommandResume(HttpRequest request)
        {
            return Ok();
        }
    }
}
