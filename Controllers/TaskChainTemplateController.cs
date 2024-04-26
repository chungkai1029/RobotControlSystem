using Microsoft.AspNetCore.Mvc;
using RobotControlSystem.Models;

namespace RobotControlSystem.Controllers
{
    [Route("taskChainTemplate")]
    [ApiController]
    public class TaskChainTemplateController : ControllerBase
    {
        [HttpGet("submit/{id}")]
        public ActionResult TemplateSubmit([FromBody] TemplateSubmitRequest templateSubmitRequest)
        {
            return Ok();
        }

        [HttpPost("list")]
        public ActionResult TemplateList([FromBody] TemplateListRequest templateListRequest)
        {
            return Ok();
        }

        [HttpPost("generic/submit")]
        public ActionResult GenericSubmit([FromBody] GenericSubmitRequest genericSubmitRequest)
        {
            return Ok();
        }
    }
}
