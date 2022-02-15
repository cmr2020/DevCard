using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_Mvc.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"تاکسی","درخواست آنلاین تاکسی برای سفر های درون شهری","project-1.jpg","Snapp"),
                new Project(2,"زود فود","درخواست آنلاین غذا برای سراسر کشور","project-4.jpg","ZoodFood"),
                new Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس","project-5.jpg","MONOP"),
                new Project(4,"فضاپیما","برنامه مدیریت فضا پیما های ناسا","project-7.jpg","NASA")
            };
            return View("_Projects",projects);
        }
    }
}
