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
        private static PeopleViewModel peopleVM = new PeopleViewModel();
        private static PeopleListData ListData = new PeopleListData();
        public IActionResult PeopleIndex()

        {
            
            if (peopleVM.ListOfPeople.Count == 0)
            {
                peopleVM.ListOfPeople = PeopleListData.PopulatePeople();
            }
            
            return View(peopleVM);
        }
            
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePerson(CreatePersonViewModel createPersonVM)
        {
         ViewBag.errorsInModel = null;

            if (ModelState.IsValid)
            {
                ListData.Create(createPersonVM.PersonId, createPersonVM.Name, createPersonVM.Phone, createPersonVM.City);
               
                ModelState.Clear();

                return View("PeopleIndex", peopleVM);
            }
            else
            {
                ViewBag.errorsInModel = "Failed to add a new person!" + ModelState.Values;
            }
            return View("PeopleIndex", peopleVM);
        }

       
        public IActionResult DeletePerson(int personId)
        {
            
            ListData.Read().FindIndex(person => person.PersonId == personId);
            ListData.Delete(personId);

            return View("PeopleIndex", peopleVM);

        }
       

        [HttpPost]
        public IActionResult PeopleIndex(string filterString)
        {
            peopleVM.ListOfPeople.Clear();
            if (!String.IsNullOrWhiteSpace(filterString))
            {
                bool isNumber = int.TryParse(filterString, out int pId);
                foreach (Person p in ListData.Read())
                {

                    if (p.PersonId == pId                        
                        || p.City.Contains(filterString, StringComparison.CurrentCultureIgnoreCase)
                        || p.Name.Contains(filterString, StringComparison.CurrentCultureIgnoreCase)
                        || p.Phone.Contains(filterString, StringComparison.CurrentCultureIgnoreCase))
                    {
                        peopleVM.ListOfPeople.Add(p);
                    }

                }
            }

            return View("PeopleIndex", peopleVM);
        }

    }
}
