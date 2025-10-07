using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhiteLagon.Application.Common.Interfaces;
using WhiteLagon.Domain.Entities;
using WhiteLagon.Infrastructure.Data;
using WhiteLagon.web.ViewModel;


namespace WhiteLagon.web.Controllers
{
    public class AmenityController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public AmenityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var amenitys = _unitOfWork.Amenity.GetAll(includeProperties:"Villa");
            return View(amenitys);
        }

        public IActionResult Create()
        {
            AmenityVM amenityVM = new()
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                })
            };
            return View(amenityVM);
        }

        [HttpPost]
        public IActionResult Create(AmenityVM obj)
        {
            //ModelState.Remove("Villa");


            if (ModelState.IsValid)
            {

                _unitOfWork.Amenity.Add(obj.Amenity);
                _unitOfWork.Save();
                TempData["success"] = "Amenity created successfully";
                return RedirectToAction(nameof(Index));
            }


            obj.VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(obj);
        }

        public IActionResult Update(int amenityId)
        {
            AmenityVM amenityVM = new()
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Amenity = _unitOfWork.Amenity.Get(u => u.Id == amenityId)!
            };

            if (amenityVM.Amenity == null)
            {
                return RedirectToAction("Error","Home");
            }
            return View(amenityVM);
        }

        [HttpPost]
        public IActionResult Update(AmenityVM amenityVM)
        {

            if (ModelState.IsValid)
            {

                _unitOfWork.Amenity.Update(amenityVM.Amenity);
                _unitOfWork.Save();
                TempData["success"] = "Amenity updated successfully";
                return RedirectToAction(nameof(Index));
            }

            amenityVM.VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            });

            return View(amenityVM);

        }

        public IActionResult Delete(int amenityId)
        {
            AmenityVM amenityVM = new()
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Amenity = _unitOfWork.Amenity.Get(u => u.Id == amenityId)!
            };

            if (amenityVM.Amenity == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(amenityVM);
        }

        [HttpPost]
        public IActionResult Delete(AmenityVM amenityVM)
        {
            Amenity? objFromDb = _unitOfWork.Amenity.Get(u => u.Id == amenityVM.Amenity.Id);
            if (objFromDb is not null)
            {
                _unitOfWork.Amenity.Remove(objFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Amenity deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Error while deleting villa";
            return View();
        }
    }
}
