using Microsoft.AspNetCore.Mvc;
using WhiteLagon.Application.Common.Interfaces;
using WhiteLagon.Domain.Entities;
using WhiteLagon.Infrastructure.Data;

namespace WhiteLagon.web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VillaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var villas = _unitOfWork.Villa.GetAll();
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

                _unitOfWork.Villa.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Villa created successfully";
                return RedirectToAction("Index", "Villa");
            }
            TempData["error"] = "Error while creating villa";
            return View();
        }

        public IActionResult Update(int villaId)
        {
            Villa? obj = _unitOfWork.Villa.Get(u=>u.Id == villaId);
            if (obj == null)
            {
                return RedirectToAction("Error","Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Villa obj)
        {
            if (ModelState.IsValid && obj.Id > 0)
            {

                _unitOfWork.Villa.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Villa updated successfully";
                return RedirectToAction("Index", "Villa");
            }
            TempData["error"] = "Error while updating villa";
            return View();
        }

        public IActionResult Delete(int villaId)
        {
            Villa? obj = _unitOfWork.Villa.Get(u => u.Id == villaId);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Villa obj)
        {
            Villa? objFromDb = _unitOfWork.Villa.Get(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                _unitOfWork.Villa.Remove(objFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Villa deleted successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Error while deleting villa";
            return View();
        }
    }
}
