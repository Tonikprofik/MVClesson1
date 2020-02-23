using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()  
        {
            ViewData["movie"] = "One Flew over";
            ViewData["year"] = 1078;
            ViewBag.Movie = "Forrest Gump";
            ViewBag.Year = 1996;

            return View( ); 
        }
    }
}