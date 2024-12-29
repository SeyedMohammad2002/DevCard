using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new(1, "ZoodFood", "درخواست آنلاین غذا برای سراسر کشور", "ZoodFood", "project-1.jpg"),
                new(2, "سامانه مدارس", "سیستم مدیریت یکپارچه مدارس", "وزارت آموزش و پرورش", "project-2.jpg"),
                new(3, "هی تاکسی", "درخواست آنلاین سفر های درون شهری", "Taxi.Co", "project-3.jpg"),
                new(4, "InteliPredict", "تخمین قیمت کالا ها در بازه های زمانی مختلف", "Finance", "project4.jpg")
            };
            return View("_Projects", projects);
            //Return view components
            //there is no need to Mother model in the controller.
        }
    }
}