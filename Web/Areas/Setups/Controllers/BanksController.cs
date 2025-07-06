using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Setups.Controllers
{
    public class BanksController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Banks";
            ViewBag.PageTitle = "Banks";
            return View();
        }
    }
}
