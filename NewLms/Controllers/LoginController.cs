using Microsoft.AspNetCore.Mvc;
using NewLms.Models;

namespace NewLms.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateCredentials(LoginModel model)
        {
            // Your validation logic here
            if (ModelState.IsValid)
            {
                // Example validation logic, replace it with your actual implementation
                if (model.Username == "admin" && model.Password == "admin")
                {
                    // Assuming the role is determined based on some logic
                    string role = "Admin";

                    return Json(new { isSuccess = true, userRole = role });
                }
                else if (model.Username == "user" && model.Password == "user")
                {
                    // Assuming the role is determined based on some logic
                    string role = "User";

                    return Json(new { isSuccess = true, userRole = role });
                }
                else
                {
                    return Json(new { isSuccess = false, errorMessage = "Invalid credentials" });
                }
            }
            else
            {
                // Model validation failed
                return Json(new { isSuccess = false, errorMessage = "Invalid model" });
            }
        }

    }
}
