using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using VolvoExercise.Data;
using VolvoExercise.Models;

namespace VolvoExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly VolvoExerciseDbContext _context;

        public HomeController(VolvoExerciseDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            var savedVehicles = _context.Vehicles.ToList();
            return View(savedVehicles);
        }

        [HttpPost]
        public IActionResult Index(String series, UInt32 number)
        {
            if(series != null && !series.Trim().Equals("")) 
            {
                series = series.ToUpper();
                return View(_context.Vehicles.Where(v => v.ChassisId.Series == series && v.ChassisId.Number == number).ToList());
            }
            else if (series == null && number == 0)
            {
                var savedVehicles = _context.Vehicles.ToList();
                return View(savedVehicles);
            }
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
