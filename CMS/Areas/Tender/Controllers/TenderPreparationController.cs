using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class TenderPreparationController : BaseController
    {
        public IActionResult TenderGeneralInfo()
        {
            ViewBag.Breadcrumb = "Tender-General Information";
            ViewBag.PageTitle = "Tender-General Information";
            return View();
        }
        public IActionResult TenderSubContractors()
        {
            ViewBag.Breadcrumb = "Tender-Nominated Sub-Contractors";
            ViewBag.PageTitle = "Tender-Nominated Sub-Contractors";
            return View();
        }
        public IActionResult TenderWeightings()
        {
            ViewBag.Breadcrumb = "Tender-Weightings/Coefficients";
            ViewBag.PageTitle = "Tender-Weightings/Coefficients";
            return View();
        }
        public IActionResult TenderContractClauses()
        {
            ViewBag.Breadcrumb = "Tender-Contract Data Clauses";
            ViewBag.PageTitle = "Tender-Contract Data Clauses";
            return View();
        }
        public IActionResult TenderLots()
        {
            ViewBag.Breadcrumb = "Tender-Lot Details";
            ViewBag.PageTitle = "Tender-Lot Details";
            return View();
        }
        public IActionResult TenderBillHeaders()
        {
            ViewBag.Breadcrumb = "Tender-Bill Headers";
            ViewBag.PageTitle = "Tender-Bill Headers";
            return View();
        }
        public IActionResult TenderBillSubHeaders()
        {
            ViewBag.Breadcrumb = "Tender-Bill Sub-Headers";
            ViewBag.PageTitle = "Tender-Bill Sub-Headers";
            return View();
        }
        public IActionResult TenderBOQ()
        {
            ViewBag.Breadcrumb = "Tender-BOQ";
            ViewBag.PageTitle = "Tender-BOQ";
            return View();
        }
        public IActionResult TenderDayWorks()
        {
            ViewBag.Breadcrumb = "Tender-Day Works";
            ViewBag.PageTitle = "Tender-Day Works";
            return View();
        }
        public IActionResult TenderBOQSummary()
        {
            ViewBag.Breadcrumb = "Tender-Tender BOQ Summary";
            ViewBag.PageTitle = "Tender-BOQ Summary";
            return View();
        }
        public IActionResult TenderSubmission()
        {
            ViewBag.Breadcrumb = "Tender Submission";
            ViewBag.PageTitle = "Tender-Submission";
            return View();
        }
        public IActionResult TenderReplication()
        {
            ViewBag.Breadcrumb = "Tender-Replication";
            ViewBag.PageTitle = "Tender-Replication";
            return View();
        }

    }
}
