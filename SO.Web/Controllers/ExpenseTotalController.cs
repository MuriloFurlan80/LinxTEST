using Microsoft.AspNetCore.Mvc;
using SO.ViewModel;
using SO.Web.Helper.Rest;
namespace SO.Web.Controllers
{
    public class ExpenseTotalController : Controller
    {
        private readonly IRestHelper _rest;

        public ExpenseTotalController(IRestHelper rest)
        {
            _rest = rest;
        }

        public IActionResult Index(string storeId)
        {
           var result = _rest.Get<ExpenseTotalViewModel>($"ExpenseTotal?storeId={storeId}");
            return View(result.Data);
        }

        [HttpPost]
        public IActionResult Update(ExpenseTotalViewModel expense)
        {
            var result = _rest.Post<ExpenseTotalViewModel>($"ExpenseTotal?Update", expense);
            return View("Index", result.Data);
        }
    }
}
