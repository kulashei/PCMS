using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class TenderEvaluationController : BaseController
    {
        public IActionResult TenderBidders()
        {
            ViewBag.Breadcrumb = "Tender-General Information";
            ViewBag.PageTitle = "Tender-General Information";
            return View();
        }
        public IActionResult TenderReadout()
        {
            ViewBag.Breadcrumb = "Tender-General Information";
            ViewBag.PageTitle = "Tender-General Information";
            return View();
        }
        public IActionResult TenderEngineerEstimate()
        {
            ViewBag.Breadcrumb = "Tender-General Information";
            ViewBag.PageTitle = "Tender-General Information";
            return View();
        }
    }
}
