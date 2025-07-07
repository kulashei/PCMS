using CMS.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Setups Dashboard";
            ViewBag.PageTitle = "Setups";
            return View();
        }
    }
}
