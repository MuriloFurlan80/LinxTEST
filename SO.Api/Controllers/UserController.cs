using Microsoft.AspNetCore.Mvc;
using SO.Domain.Services;
using System.Threading.Tasks;

namespace SO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _userService.Get();
            return Ok(result);
        }
    }
}
