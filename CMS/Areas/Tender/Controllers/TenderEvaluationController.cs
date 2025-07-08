using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Tender.Controllers
{
    public class TenderEvaluationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
