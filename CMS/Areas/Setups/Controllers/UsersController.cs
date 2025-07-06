using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Setups.Controllers
{
    public class UsersController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Breadcrumb = "Users";
            ViewBag.PageTitle = "Users";
            return View();
        }
    }
}
