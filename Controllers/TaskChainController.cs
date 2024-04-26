using Microsoft.AspNetCore.Mvc;

namespace RobotControlSystem.Controllers
{
    [Route("taskChain")]
    [ApiController]
    public class TaskChainController : ControllerBase
    {
        [HttpPut("reassignByAmrId/{amrId}")]
        public ActionResult ReAssignByAmrId(HttpRequest request)
        {
            return Ok();
        }

        [HttpPut("reassignByTaskChainId/{taskChainId}")]
        public ActionResult ReAssignByTaskChainId(HttpRequest request)
        {
            return Ok();
        }

        [HttpGet("endFinishPauseIsFalseTask/{taskChainId}")]
        public ActionResult EndFinishPauseIsFalseTask(HttpRequest request)
        {
            return Ok();
        }
    }
}
