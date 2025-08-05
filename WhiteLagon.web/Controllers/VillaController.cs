using Microsoft.AspNetCore.Mvc;
using WhiteLagon.Domain.Entities;
using WhiteLagon.Infrastructure.Data;

namespace WhiteLagon.web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();
            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj)
        {
            if(obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "The Name and Description cannot be the same.");
            }
            if (ModelState.IsValid)
            {

                _db.Villas.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Villa");
            }
            return View();
        }
    }
}
