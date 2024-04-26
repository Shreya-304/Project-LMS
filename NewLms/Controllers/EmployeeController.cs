
using Microsoft.AspNetCore.Mvc;
using NewLms.Models;

namespace NewLms.Controllers
{
    public class EmployeeController : Controller
    {


        // GET: Employee/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Employee/Register
        [HttpPost]
        public ActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // Save employee data to the database
                // You can use Entity Framework or any other ORM here

                // For demonstration, let's just return a success message
                return RedirectToAction("SkillAssessment");
            }
            return View(employee);
        }

        public ActionResult SkillAssessment() {
            return View();
        }
    }
}
