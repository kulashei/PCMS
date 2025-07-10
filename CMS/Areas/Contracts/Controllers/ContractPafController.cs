using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Contracts.Controllers
{
    public class ContractPafController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
