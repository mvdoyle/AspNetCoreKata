using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreKata.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreKata.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Person>
            {
                new Person { Name = "Michael Doyle", Age = 30 }
            };
            return View(list);
        }
    }
}