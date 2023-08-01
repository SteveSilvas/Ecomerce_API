using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AddressController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
