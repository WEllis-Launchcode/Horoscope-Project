using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HoroscopeProject.Controllers
{
    public class HoroscopeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Select()
        {
            return View();
        }


        [HttpPost]
        [Route("/Horoscope/Quote-Of-The-Day")]
        public IActionResult Result()
        {
            return View();
        }
    }
}
