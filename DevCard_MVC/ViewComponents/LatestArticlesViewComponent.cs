using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new(1, "ZoodFood", "درخواست آنلاین غذا برای سراسر کشور", "blog-post-thumb-1.jpg"),
                new(2, "سامانه مدارس", "سیستم مدیریت یکپارچه مدارس", "blog-post-thumb-2.jpg"),
                new(3, "هی تاکسی", "درخواست آنلاین سفر های درون شهری", "blog-post-thumb-3.jpg"),
                new(4, "InteliPredict", "تخمین قیمت کالا ها در بازه های زمانی مختلف", "blog-post-thumb-4.jpg")
            };
            return View("_LatestArticles", articles);
            //Return view components
            //there is no need to Mother model in the controller.
        }
    }
}