using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AzureVaultSampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SampleController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetSecret()
        {
            var secretValue = _configuration["YourSecretName"];
            return Ok(new { Secret = secretValue });
        }
    }
}