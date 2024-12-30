using System.Collections.Generic;
using System.Diagnostics;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new()
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس")
        };

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                services = new SelectList(_services, "Id", "Name")
            };
            return View("Contact", model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    return Json(Ok()); // Ok() is a helper method that returns a 200 OK status code
        //}
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.services = new SelectList(_services, "Id", "Name");
            if (ModelState.IsValid == false)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد";
                return View("Contact", model);
            }

            ModelState.Clear();
            model = new Contact
            {
                services = new SelectList(_services, "Id", "Name")
            };

            ViewBag.success = "اطلاعات با موفقیت ثبت شد";
            return View("Contact", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}