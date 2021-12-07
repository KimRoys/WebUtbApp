using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUtbApp.Models;
using WebUtbApp.Models.Data;

namespace WebUtbApp.Controllers
{
    public class PeopleController : Controller
    {
        

        public IActionResult PeopleIndex()

        {
            PeopleViewModel peopleVM = new PeopleViewModel
            {
                ListOfPeople = PeopleListData.PopulatePeople()
            };
            return View(peopleVM);
        }
            
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePerson(CreatePersonViewModel CreatePersonVM)
        {
         PeopleViewModel peopleVM = new PeopleViewModel();
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
            PeopleViewModel peopleVM = new PeopleViewModel();
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
            PeopleViewModel peopleVM = new PeopleViewModel();
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
