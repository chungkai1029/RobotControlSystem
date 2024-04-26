using Microsoft.AspNetCore.Mvc;

namespace RobotControlSystem.Controllers
{
    [Route("task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost("add")]
        public ActionResult TaskAdd(dynamic request)
        {
            try
            {
                Console.WriteLine(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception={ex}");
            }
            return Ok();
        }

        [HttpGet("getTaskChainByIds")]
        public ActionResult GetTaskChainByIds(HttpRequest request)
        {
            return Ok();
        }

        [HttpPost("cancel/{id}")]
        public ActionResult TaskCancel(HttpRequest request)
        {
            return Ok();
        }

        [HttpGet("priority")]
        public ActionResult Priority(HttpRequest request)
        {
            return Ok();
        }
    }
}
