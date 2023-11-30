using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;
using System.Text.Json;

namespace RobotControlSystem.Controllers
{
    [Route("task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        CheckHeaders checkHeaders;
        TaskAddResponse taskAddResponse;

        private int checkStatusCode;
        private string requestBody;
        private string responseBody;

        [HttpPost("add")]
        public IActionResult TaskAdd([FromBody] TaskAddRequest taskAddRequest)
        {
            try
            {
                // Check the request header for data proof.
                IHeaderDictionary requestHeaders = Request.Headers;

                // Initialize the Header Checker and check headers.
                checkHeaders = new CheckHeaders();
                checkStatusCode = checkHeaders.check(requestHeaders);

                if (checkStatusCode == StatusCodes.Status401Unauthorized)
                {
                    return Unauthorized();
                }

                if (checkStatusCode == StatusCodes.Status403Forbidden)
                {
                    return Forbid();
                }

                // Serialize as a json string from request body.
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

                requestBody = JsonSerializer.Serialize(taskAddRequest, options);
                Console.WriteLine($"requestBody={requestBody}");

                // Serialize response message as a json string.
                taskAddResponse = new TaskAddResponse
                {
                    errMsg = "操作成功",
                    errCode = "0",
                    state = true,
                    data = 55899
                };

                responseBody = JsonSerializer.Serialize(taskAddResponse, options);
                Console.WriteLine($"responseBody={responseBody}");

                return Ok(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception={ex}");
                return BadRequest();
            }
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
