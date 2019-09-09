using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {

            Customer one = new Customer("Natalia", "Laski", "Norregade 16B", "8000", "Aarhus C", "91444166");
            Customer two = new Customer("Karolina", "Laski", "Mollehatten 6", "8240", "Risskov", "91444166");
            Customer three = new Customer("Patrik", "Melis", "Snogebæksvej 11", "8210", "Aarhus V", "91444166");

            List<Customer> customers = new List<Customer>();

            // customers.Add("one");

            ViewBag.CustomerOne = one;
            ViewBag.CustomerTwo = two;
            ViewBag.CustomerThree = three;

            return View();
        }
    }
}