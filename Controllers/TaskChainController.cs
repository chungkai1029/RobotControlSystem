using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;

namespace RobotControlSystem.Controllers
{
    [Route("taskChain")]
    [ApiController]
    public class TaskChainController : ControllerBase
    {
        [HttpPut("reassignByAmrId/{amrId}")]
        public ActionResult ReassignByAmrId([FromBody] ReassignByAmrIdRequest reassignByAmrIdRequest)
        {
            return Ok();
        }

        [HttpPut("reassignByTaskChainId/{taskChainId}")]
        public ActionResult ReassignByTaskChainId([FromBody] ReassignByTaskChainIdRequest reassignByTaskChainIdRequest)
        {
            return Ok();
        }

        [HttpGet("endFinishPauseIsFalseTask/{taskChainId}")]
        public ActionResult EndFinishPauseIsFalseTask([FromBody] EndFinishPauseIsFalseTaskRequest endFinishPauseIsFalseTaskRequest)
        {
            return Ok();
        }
    }
}
