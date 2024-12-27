using InsurancePortal.DataAccess;
using InsurancePortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class InsuranceController : Controller
    {
        private readonly ApplicationDbContext _db;
        public InsuranceController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Insurance> objCategoryList = _db.Insurances.ToList();

            return View(objCategoryList);
        }
    }
}
