using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Admin.Controllers
{
    public class SetupController : BaseController
    {
        public IActionResult Bank()
        {
            return View();
        }
    }
}
