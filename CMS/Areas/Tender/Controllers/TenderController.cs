using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class TenderController : BaseController
    {

        public IActionResult TenderGeneralInfo()
        {
            ViewBag.Breadcrumb = "General Dashboard";
            ViewBag.PageTitle = "Tender";
            return View();
        }
    }
}
