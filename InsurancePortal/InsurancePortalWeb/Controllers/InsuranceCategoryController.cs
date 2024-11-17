using InsurancePortalWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Controllers
{
    public class InsuranceCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public InsuranceCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<InsuranceCategory> objInsuranceCategoryList = _db.InsuranceCategories.ToList();
            return View(objInsuranceCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InsuranceCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.InsuranceCategories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "InsuranceCategory");
            }

            return View();
        }
    }
}
