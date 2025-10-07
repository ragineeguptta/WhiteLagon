using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WhiteLagon.Application.Common.Interfaces;
using WhiteLagon.web.Models;
using WhiteLagon.web.ViewModel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;

namespace WhiteLagon.web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                VillaList = _unitOfWork.Villa.GetAll(includeProperties: "VillaAmenity"),
                CheckInDate = DateOnly.FromDateTime(DateTime.Now),
                Nights = 1
            };
            return View(homeVM);
        }


        public IActionResult Privacy()
        {
            return View();
        }

       public IActionResult Error()
        {
            return View();
        }

    }
}
