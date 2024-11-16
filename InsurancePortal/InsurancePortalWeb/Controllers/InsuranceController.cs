using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Controllers
{
    public class InsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
