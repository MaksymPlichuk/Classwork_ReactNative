using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDotNet.Models.Account;

namespace WebAPIDotNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginModel model)
        {
            return Ok(model);
        }
    }
}
