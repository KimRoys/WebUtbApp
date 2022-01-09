using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUtbApp.Models;

namespace WebUtbApp.Controllers
{
    public class DoctorController : Controller
    {
       
        // GET: Doctor
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fever()
        {
            ViewBag.Message = DoctorModel.WriteMessage();
            return View();
        }
        [HttpPost]
        public IActionResult Fever(float temp)
        {

            DoctorModel dm = new DoctorModel();
            dm.Temp = temp;
            //dm.IsCelsius = isCelsius;
            //dm.IsFahrenheit = isFahrenheit;
            ViewBag.Message = DoctorModel.Fevercheck(temp);
            return View();
        }

        // GET: Doctor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doctor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
