using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Token.Security;


namespace Token.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Security.Token token = TokenHandler.CreateToken(_configuration);
            return Ok(token);
        }
    }
}
