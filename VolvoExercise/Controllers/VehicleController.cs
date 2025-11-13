using Microsoft.AspNetCore.Mvc;
using VolvoExercise.Data;
using VolvoExercise.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VolvoExercise.Controllers
{
    public class VehicleController : Controller
    {
        private readonly VolvoExerciseDbContext _context;

        public VehicleController(VolvoExerciseDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult AddVehicle(Vehicle vehicle)
        {
            vehicle.ChassisId.Series = vehicle.ChassisId.Series.ToUpper();

            bool exists = _context.Vehicles.Any(v => v.ChassisId.Series == vehicle.ChassisId.Series && v.ChassisId.Number == vehicle.ChassisId.Number);
            if (exists)
            {
                TempData["ErrorMessage"] = "Vehicle already exists!";
                return RedirectToAction("Create");
            }
            if (vehicle.Type.Equals("Bus"))
            {
                vehicle.PassengerCapacity = 42;
            }
            else if (vehicle.Type.Equals("Truck"))
            {
                vehicle.PassengerCapacity = 1;
            }
            else if (vehicle.Type.Equals("Car"))
            {
                vehicle.PassengerCapacity = 4;
            }

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
            TempData["SuccessMessage"] = "Vehicle saved successfully!";
            return RedirectToAction("Create");
        }

        public IActionResult EditVehicle(Int32 vehicleId)
        {
            Vehicle vehicle = _context.Vehicles.Find(vehicleId);
            return View(vehicle);
        }
        public IActionResult SaveEditVehicle(Vehicle upToDateVehicle)
        {
            Vehicle vehicle = _context.Vehicles.FirstOrDefault(v => v.ChassisId.Series == upToDateVehicle.ChassisId.Series && 
                                                                    v.ChassisId.Number == upToDateVehicle.ChassisId.Number);
            
            vehicle.Color = upToDateVehicle.Color;
            _context.SaveChanges();
            TempData["SuccessfulUpdateMessage"] = "Changes applied!";
            return RedirectToAction("Index", "Home");
        }
    }
}
