using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Admin.Controllers
{
    public class SecurityController : BaseController
    {
        public IActionResult UserManagement()
        {
            ViewBag.Breadcrumb = "User Management";
            ViewBag.PageTitle = "User Management";
            return View();
        }

        public IActionResult PVReversal()
        {
            ViewBag.Breadcrumb = "Payment Voucher Approval Reversal";
            ViewBag.PageTitle = "Payment Voucher Approval Reversal";
            return View();
        }

        public IActionResult BidReversal()
        {
            ViewBag.Breadcrumb = "Tender Document Reversal";
            ViewBag.PageTitle = "Tender Document Reversal";
            return View();
        }

        public IActionResult ContractReversal()
        {
            ViewBag.Breadcrumb = "Contract Document Reversal";
            ViewBag.PageTitle = "Contract Document Reversal";
            return View();
        }


    }
}
