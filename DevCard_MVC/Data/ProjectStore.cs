using System.Collections.Generic;
using DevCard_MVC.Models;

namespace DevCard_MVC.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new(1, "ZoodFood", "درخواست آنلاین غذا برای سراسر کشور", "ZoodFood", "project-1.jpg"),
                new(2, "سامانه مدارس", "سیستم مدیریت یکپارچه مدارس", "وزارت آموزش و پرورش", "project-2.jpg"),
                new(3, "هی تاکسی", "درخواست آنلاین سفر های درون شهری", "Taxi.Co", "project-3.jpg"),
                new(4, "InteliPredict", "تخمین قیمت کالا ها در بازه های زمانی مختلف", "Finance", "project4.jpg")
            };
        }
    }
}