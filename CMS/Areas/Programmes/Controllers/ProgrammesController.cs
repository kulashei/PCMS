using Microsoft.AspNetCore.Mvc;

namespace CMS.Areas.Programmes.Controllers
{
    public class ProgrammesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
