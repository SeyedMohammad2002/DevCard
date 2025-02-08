using System.Collections.Generic;
using DevCard_MVC.Data;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = ProjectStore.GetProjects();
            return View("_Projects", projects);
            //Return view components
            //there is no need to Mother model in the controller.
        }
    }
}