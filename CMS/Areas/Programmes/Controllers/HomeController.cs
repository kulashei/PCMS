using CMS.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Programmes.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Programmes Dashboard";
            ViewBag.PageTitle = "Programmes";
            return View();
        }
        public IActionResult ProgGeneralInformation()
        {
            ViewBag.Breadcrumb = "Programmes Dashboard";
            ViewBag.PageTitle = "Programmes";
            return View();
        }
    }
}
