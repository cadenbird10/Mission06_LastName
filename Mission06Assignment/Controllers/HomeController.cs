using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06Assignment.Models;
//using Mission06Assignment.Models;

namespace Mission06Assignment.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _context;
        
        public HomeController(NewMovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult AddMovie(NewMovie response)
        {
            _context.NewMovies.Add(response);
            _context.SaveChanges();

            return View("Confirmation",  response);
        }
    }
}
