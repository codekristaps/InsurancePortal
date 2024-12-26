using InsurancePortal.DataAccess;
using InsurancePortal.Models;
using InsurancePortal.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePortalWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<ApplicationUser> objUsersList = _db.ApplicationUsers.ToList();

            return View(objUsersList);
        }
    }
}
