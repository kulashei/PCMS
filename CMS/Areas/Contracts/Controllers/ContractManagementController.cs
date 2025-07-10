using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Contracts.Controllers
{
    public class ContractManagementController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
