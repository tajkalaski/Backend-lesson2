using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Some bruh idk");
            Movie forrestGump = new Movie("Forrest Gump", 129.50m, "forrest-gump.jpg", "Another bruh probably");
            Movie gladiator = new Movie("Gladiator", 134.50m, "gladiator.jpg", "Surprisingly yet another dude");


            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Gladiator = gladiator;
            ViewBag.ForrestGump = forrestGump;
            return View();
        }
    }
}