using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUtbApp.Models;

namespace WebUtbApp.Controllers
{
    public class PeopleController : Controller
    {
        private static readonly PeopleViewModel peopleVM = new PeopleViewModel();
        private static bool isPopulated = false;


        public IActionResult PeopleIndex()

        {
            if (!isPopulated)
            {
                _ = peopleVM.PopulatePeople();
                isPopulated = true;
            }

            return View(peopleVM);
        }
            
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePerson(CreatePersonViewModel CreatePersonVM)
        {
            ViewBag.errorsInModel = null;

            if (ModelState.IsValid)
            {
                peopleVM.ListOfPeople.Add(new Person(CreatePersonVM.Name, CreatePersonVM.Phone, CreatePersonVM.City));
                ModelState.Clear();
            }

            return View("PeopleIndex", peopleVM);
        }

       
        public IActionResult DeletePerson(int personId)
        {

            int personInd = peopleVM.ListOfPeople.FindIndex(person => person.PersonId == personId);
                if (personInd >= 0)
                {
                    peopleVM.ListOfPeople.RemoveAt(personInd);
                }
                return View("PeopleIndex", peopleVM);            
        }

        [HttpPost]
        public IActionResult SearchPersons(string filterString)
        {
            if (string.IsNullOrWhiteSpace(filterString))
            {
                peopleVM.FilterString = null;
            }
            else
            {
                peopleVM.FilterString = filterString;
            }

            return View("PeopleIndex", peopleVM);
        }

    }
}
