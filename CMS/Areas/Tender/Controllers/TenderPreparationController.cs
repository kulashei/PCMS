using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class TenderPreparationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
