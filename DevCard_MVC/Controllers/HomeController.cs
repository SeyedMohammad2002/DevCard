using System;
using System.Diagnostics;
using System.Security.AccessControl;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
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
            if (ModelState.IsValid == false)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد";
                return View("Contact", model);
            }

            ViewBag.success = "اطلاعات با موفقیت ثبت شد";
            return View("Contact");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}