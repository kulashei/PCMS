using CMS.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Admin Dashboard";
            ViewBag.PageTitle = "Admin";
            return View();
        }
    }
}
