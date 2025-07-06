using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Setups.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Setups Dashboard";
            return View();
        }
    }
}
