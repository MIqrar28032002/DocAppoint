using DocAppoint.Data;
using DocAppoint.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DocAppoint.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext context;

        public AppointmentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                context.Appointments.Add(appointment);
                await context.SaveChangesAsync();
                TempData["Success"] = "Appointment booked successfully!";
                return RedirectToAction("Index", "Dashboard");
            }
            TempData["Error"] = "Please check all fields and try again.";
            return View(appointment);
        }

        public IActionResult Index()
        {
            var loggedEmail = User.Identity?.Name;
            var appointments = context.Appointments
              .Where(a => a.PatientEmail == loggedEmail)
              .OrderByDescending(a => a.AppointmentDate)
              .ToList();
            return View(appointments);
        }
    }
}