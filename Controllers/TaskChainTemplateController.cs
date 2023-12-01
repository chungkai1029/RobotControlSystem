using Microsoft.AspNetCore.Mvc;

namespace RobotControlSystem.Controllers
{
    [Route("taskChainTemplate")]
    [ApiController]
    public class TaskChainTemplateController : ControllerBase
    {
        [HttpGet("submit/{id}")]
        public ActionResult TemplateSubmit(HttpRequest request)
        {
            return Ok();
        }

        [HttpPost("list")]
        public ActionResult TemplateList(HttpRequest request)
        {
            return Ok();
        }

        [HttpPost("generic/submit")]
        public ActionResult GenericSubmit(HttpRequest request)
        {
            return Ok();
        }
    }
}
