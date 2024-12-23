using InsurancePortalWeb.Data;
using InsurancePortalWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Controllers
{
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Insurance obj)
        {
            _db.Insurances.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Insurance");
        }
    }
}
