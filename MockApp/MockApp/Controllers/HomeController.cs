using Microsoft.AspNetCore.Mvc;
using MockApp.Models;
using MockApp.Services;
using MockApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockApp.Controllers
{
    public class HomeController : Controller
    {
        private IBorrowerData _borrowerData;

        public HomeController(IBorrowerData borrowerData)
        {
            _borrowerData = borrowerData;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Borrowers = _borrowerData.GetAll();

            return View(model);
        }

        public IActionResult Details(string name)
        {
            return Content(name);
        }
    }
}
