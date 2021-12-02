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
       
    }
}
