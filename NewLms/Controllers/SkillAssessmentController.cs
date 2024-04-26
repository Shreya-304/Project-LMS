using NewLms.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace NewLms.Controllers
{
    public class SkillAssessmentController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new SkillAssessmentViewModel
            {
                Ratings = new Dictionary<string, int>
                {
                    { "Basic Understanding", 0 },
                    { "Working Experience", 0 },
                    { "Extensive Experience", 0 },
                    { "Subject Matter Experience", 0 }
                },
                TechnicalSkills = new Dictionary<string, bool>
                {
                    { "Database", false },
                    { "Programming", false },
                    { "Java", false },
                    { "C#", false },
                    { "Python", false },
                    { "Web Programming", false },
                    { "Other", false }
                },
                SoftSkills = new Dictionary<string, bool>
                {
                    { "Verbal Communication", false },
                    { "Written Communication", false },
                    { "Any other Foreign Language", false },
                    { "Teamwork", false },
                    { "Problem Solving", false },
                    { "Decision making", false },
                    { "Leadership", false }
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SubmitSkillAssessment(SkillAssessmentViewModel viewModel)
        {
            // Process submitted data
            // You can access the viewModel object here to get the submitted ratings and skills

            return RedirectToAction("Login"); // Redirect to the Skill Assessment form
        }
    }
}
