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
        public ActionResult AmrTaskCommandPause(HttpRequest request)
        {
            return Ok();
        }

        [HttpPost("taskCommand/resume/{amrId}")]
        public ActionResult AmrTaskCommandResume(HttpRequest request)
        {
            return Ok();
        }
    }
}
