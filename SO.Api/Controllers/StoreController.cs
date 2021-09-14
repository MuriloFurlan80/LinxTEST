using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SO.Domain.Services;
using SO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _service;

        public StoreController(IStoreService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string userId) 
        {
            var result = await _service.Get(userId);
            return Ok(result);
        }
    }
}
