using Microsoft.AspNetCore.Mvc;
using SO.ViewModel;
using SO.Web.Helper.Rest;
using System;
using System.Text.Json;

namespace SO.Web.Controllers
{
    public class StoreController : Controller
    {
        private readonly IRestHelper _rest;

        public StoreController(IRestHelper rest)
        {
            _rest = rest;
        }

        public IActionResult Index(string userId)
        {
            var result = _rest.Get<StoreViewModel>($"Store?userId={userId}");
            return View(result.Data);
        }
    }
}
