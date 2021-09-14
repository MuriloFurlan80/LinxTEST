using Microsoft.AspNetCore.Mvc;
using SO.Domain.Services;
using SO.ViewModel;
using System.Threading.Tasks;

namespace SO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseTotalController : ControllerBase
    {
        private readonly IExpenseTotalService _service;

        public ExpenseTotalController(IExpenseTotalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string storeId)
        {
            return Ok(await _service.GetByStoreAsync(storeId));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ExpenseTotalViewModel input)
        {
            return Ok(await _service.Update(input));
        }
    }
}
