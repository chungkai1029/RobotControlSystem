using Microsoft.AspNetCore.Mvc;

namespace RobotControlSystem.Controllers
{
    [Route("/")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        [HttpPost("push/taskInfo")]
        public ActionResult TaskInfo(HttpRequest request)
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
