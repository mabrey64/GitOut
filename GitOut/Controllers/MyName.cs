using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        private readonly ILogger<MyNameController> _logger;

        public MyNameController(ILogger<MyNameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personName = new Name { PersonName = "Devon Mabrey" };
            return Ok(personName);
        }
    }
}
