using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;

namespace RobotControlSystem.Controllers
{
    [Route("/")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        [HttpPost("push/taskInfo")]
        public ActionResult PushTaskInfo([FromBody] PushTaskInfoRequest pushTaskInfoRequest)
        {
            return Ok();
        }

        [HttpGet("map/getMapVertexes/{mapId}")]
        public ActionResult GetMapVertexes(HttpRequest request)
        {
            return Ok();
        }
    }
}
