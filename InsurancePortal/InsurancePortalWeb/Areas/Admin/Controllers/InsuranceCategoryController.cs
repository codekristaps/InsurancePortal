using InsurancePortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InsuranceCategory? categoryFromDb = _db.InsuranceCategories.FirstOrDefault(x => x.Id == id.Value);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(InsuranceCategory category)
        {
            if (ModelState.IsValid)
            {
                _db.InsuranceCategories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

    }
}
