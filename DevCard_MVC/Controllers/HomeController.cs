using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Project> _projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Name = "ZoodFood",
                Description = "Et dolor eirmod et lorem sed duo et et esse suscipit imperdiet ipsum lorem kasd",
                Client = "ZoodFood"
            },
            new Project
            {
                Id = 2,
                Name = "سامانه مدارس",
                Description = "Et dolor eirmod et lorem sed duo et et esse suscipit imperdiet ipsum lorem kasd",
                Client = "آموزش و پرورش"
            },
            new Project
            {
                Id = 3,
                Name = "Scrapper",
                Description = "Et dolor eirmod et lorem sed duo et et esse suscipit imperdiet ipsum lorem kasd",
                Client = "ScrapeInc"
            },
            new Project
            {
                Id = 4,
                Name = "InteliPredict",
                Description = "Et dolor eirmod et lorem sed duo et et esse suscipit imperdiet ipsum lorem kasd",
                Client = "Finance"
            }
        };
        private readonly List<Article> _articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "Top 3 JavaScript Frameworks",
                Description =
                    "Blandit duis clita accusam et ipsum qui mazim no molestie diam ullamcorper possim ipsum accumsan"
            },
            new Article
            {
                Id = 2,
                Title = "About Remote Working",
                Description =
                    "Blandit duis clita accusam et ipsum qui mazim no molestie diam ullamcorper possim ipsum accumsan"
            },
            new Article
            {
                Id = 3,
                Title = "A Guide to Becoming a Full-Stack Developer",
                Description =
                    "Blandit duis clita accusam et ipsum qui mazim no molestie diam ullamcorper possim ipsum accumsan"
            }
        };

        public IndexModel _indexModel;

        public IActionResult Index()
        {
            _indexModel = new IndexModel { Projects = _projects, Articles = _articles };
            return View("Index", _indexModel);
        }

        public IActionResult Contact() { return View("Contact"); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        { return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); }
    }
}
