using Microsoft.AspNetCore.Mvc;
using Survey.Models;

namespace Survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult Submission(Surveys yourSurvey)
        {
            Surveys result = new Surveys()
            {
                Name = yourSurvey.Name.ToUpper(),
                Location = yourSurvey.Location,
                Language = yourSurvey.Language,
                Comment = yourSurvey.Comment
            };
            return View ("Result", result);
        }
    }
}