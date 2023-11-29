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
        HeaderFields headerFields;
        TaskAddResponse taskAddResponse;

        private string pathOfHeaderConfig = "./Configs/header.json";
        private string requestToken;
        private string requestName;
        private string requestBody;
        private string responseBody;

        [HttpPost("add")]
        public IActionResult TaskAdd([FromBody] TaskAddRequest taskAddRequest)
        {
            try
            {
                // Check the request header for data proof.
                IHeaderDictionary headers = Request.Headers;

                // Check if request headers contain two keys as below.
                if (!(headers.ContainsKey("token") || headers.ContainsKey("name")))
                {
                    return Unauthorized();
                }

                // Get the value of two keys as below.
                requestToken = headers["token"];
                requestName = headers["name"];

                // Check if the value of the header fields is the same as define.
                using (FileStream fs = System.IO.File.OpenRead(pathOfHeaderConfig))
                {
                    headerFields = JsonSerializer.Deserialize<HeaderFields>(fs);

                    if(requestToken != headerFields.token || requestName != headerFields.name)
                    {
                        return Forbid();
                    }
                }
                
                // Serialize as a json string from request body.
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                
                requestBody = JsonSerializer.Serialize(taskAddRequest, options);
                Console.WriteLine($"requestBody={requestBody}");

                // Serialize response message as a json string.
                taskAddResponse = new TaskAddResponse();

                taskAddResponse.errMsg = "操作成功";
                taskAddResponse.errCode = "0";
                taskAddResponse.state = true;
                taskAddResponse.data = 55899;

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
