using CMS.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Tender Dashboard";
            ViewBag.PageTitle = "Tender";
            return View();
        }
    }
}
