using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;

namespace RobotControlSystem.Controllers
{
    [Route("/")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        CheckHeaders checkHeaders;
        PushTaskInfoResponse pushTaskInfoResponse;

        int checkStatusCode;
        string requestBody;
        string responseBody;

        [HttpPost("push/taskInfo")]
        public IActionResult PushTaskInfo([FromBody] PushTaskInfoRequest pushTaskInfoRequest)
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

            requestBody = JsonSerializer.Serialize(pushTaskInfoRequest, options);
            //Console.WriteLine($"requestBody={requestBody}");

            // Serialize response message as a json string.
            pushTaskInfoResponse = new PushTaskInfoResponse { receive = "1" };
            responseBody = JsonSerializer.Serialize(pushTaskInfoResponse, options);
            //Console.WriteLine($"responseBody={responseBody}");

            return Ok(responseBody);
        }

        [HttpGet("map/getMapVertexes/{mapId}")]
        public ActionResult GetMapVertexes([FromBody] GetMapVertexesRequest getMapVertexesRequest)
        {
            return Ok();
        }
    }
}
