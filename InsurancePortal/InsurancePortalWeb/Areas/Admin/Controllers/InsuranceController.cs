using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
