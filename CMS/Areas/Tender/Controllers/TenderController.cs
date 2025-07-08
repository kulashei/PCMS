using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class TenderController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
