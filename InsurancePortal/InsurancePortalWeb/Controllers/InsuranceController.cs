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
            if (ModelState.IsValid)
            {
                _db.Insurances.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Insurance created successfully";
                return RedirectToAction("Index", "Insurance");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Insurance? insuranceFromDb = _db.Insurances.Find(id);

            if (insuranceFromDb == null)
            {
                return NotFound();
            }

            return View(insuranceFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Insurance obj)
        {
            if (ModelState.IsValid)
            {
                _db.Insurances.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Insurance updated successfully";
                return RedirectToAction("Index", "Insurance");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Insurance? categoryFromDb = _db.Insurances.Find(id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Insurance? obj = _db.Insurances.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Insurances.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Insurance");
        }
    }
}
