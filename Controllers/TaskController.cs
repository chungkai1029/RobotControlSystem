using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;

namespace RobotControlSystem.Controllers
{
    [Route("task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        CheckHeaders checkHeaders;
        TaskAddResponse taskAddResponse;

        int checkStatusCode;
        string requestBody;
        string responseBody;

        [HttpPost("add")]
        public ActionResult TaskAdd(HttpRequest request)
        {
            return Ok();
        }

        [HttpGet("getTaskChainByIds")]
        public ActionResult GetTaskChainByIds([FromBody] GetTaskChainByIdsRequest getTaskChainByIdsRequest)
        {
            return Ok();
        }

        [HttpPost("cancel/{id}")]
        public ActionResult TaskCancel([FromBody] TaskCancelRequest taskCancelRequest)
        {
            return Ok();
        }

        [HttpGet("priority")]
        public ActionResult TaskPriority([FromBody] TaskPriorityRequest taskPriorityRequest)
        {
            return Ok();
        }
    }
}
