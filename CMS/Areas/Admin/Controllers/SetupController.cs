using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Admin.Controllers
{
    public class SetupController : BaseController
    {
        public IActionResult LibraryItems()
        {
            ViewBag.Breadcrumb = "Library Items";
            ViewBag.PageTitle = "Library Items";
            return View();
        }

        public IActionResult ProvSumsMarkups()
        {
            ViewBag.Breadcrumb = "Provisional Sums Markups";
            ViewBag.PageTitle = "Provisional Sums Markups";
            return View();
        }

        public IActionResult StandardBills()
        {
            ViewBag.Breadcrumb = "Standard Bills and Sub-Bills";
            ViewBag.PageTitle = "Standard Bills and Sub-Bills";
            return View();
        }

        public IActionResult TenderBidders()
        {
            ViewBag.Breadcrumb = "Tender-General Information";
            ViewBag.PageTitle = "Tender-General Information";
            return View();
        }

        public IActionResult Units()
        {
            ViewBag.Breadcrumb = "Units of measurement";
            ViewBag.PageTitle = "Units of measurement";
            return View();
        }

        public IActionResult ProgressItemsChart()
        {
            ViewBag.Breadcrumb = "Progress Items Chart";
            ViewBag.PageTitle = "Progress Items Chart";
            return View();
        }

        public IActionResult ProgressItemsAuto()
        {
            ViewBag.Breadcrumb = "WORKS VS PROGRESS ITEMS";
            ViewBag.PageTitle = "WORKS VS PROGRESS ITEMSn";
            return View();
        }

        public IActionResult Bank()
        {
            ViewBag.Breadcrumb = "Banks and Branches";
            ViewBag.PageTitle = "Banks and Branches";
            return View();
        }

        public IActionResult Contractors()
        {
            ViewBag.Breadcrumb = "Contractors Information Management";
            ViewBag.PageTitle = "Tender-General Information";
            return View();
        }

        public IActionResult Roads()
        {
            ViewBag.Breadcrumb = "Road Register";
            ViewBag.PageTitle = "Road Register";
            return View();
        }

        public IActionResult BidType()
        {
            ViewBag.Breadcrumb = "Bid Types / Categories";
            ViewBag.PageTitle = "Bid Types / Categories";
            return View();
        }

        public IActionResult ContractCategories()
        {
            ViewBag.Breadcrumb = "Contract Categories";
            ViewBag.PageTitle = "Contract Categories";
            return View();
        }

        public IActionResult Departments()
        {
            ViewBag.Breadcrumb = "Departments Management";
            ViewBag.PageTitle = "Departments Management";
            return View();
        }

        public IActionResult DocumentsCategory()
        {
            ViewBag.Breadcrumb = "Contract Documents Categories";
            ViewBag.PageTitle = "Contract Documents Categories";
            return View();
        }

        public IActionResult DayWorksSetup()
        {
            ViewBag.Breadcrumb = "Day Work Setup";
            ViewBag.PageTitle = "Day Work Setup";
            return View();
        }

        public IActionResult Districts()
        {
            ViewBag.Breadcrumb = "Districts Management";
            ViewBag.PageTitle = "Districts Management";
            return View();
        }

        public IActionResult WeightingsSetup()
        {
            ViewBag.Breadcrumb = "Work Sections Weightings";
            ViewBag.PageTitle = "Work Sections Weightings";
            return View();
        }


    }
}
