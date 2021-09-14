using Microsoft.AspNetCore.Mvc;
using SO.Web.Helper.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SO.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IRestHelper _rest;

        public CartController(IRestHelper rest)
        {
            _rest = rest;
        }

        public IActionResult Index(string userId)
        {
            var result = _rest.Get<CartController>($"Cart?userId={userId}");
            return View(result.Data);
        }
    }
}
