using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SO.ViewModel;
using SO.Web.Helper.Rest;
using System.Collections.Generic;

namespace SO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestHelper _rest;
        public HomeController(IRestHelper restHelper)
        {
            _rest = restHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUser()
        {
            return Json(_rest.Get<IEnumerable<UserViewModel>>("user")?.Data);
        }
    }
}
