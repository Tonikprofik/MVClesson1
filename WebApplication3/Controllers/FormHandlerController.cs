using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplication3.Controllers
{
    public class FormHandlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            ViewBag.Firstname = formCollection["FirstName"];
            ViewBag.Lastname = formCollection["LastName"];
            return View();
        }
    }
}