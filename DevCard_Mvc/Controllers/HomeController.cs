using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        {
            
        }

        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        //[HttpPost]
        //public IActionResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        /* در واقه به این روش میگن مدل بایندینگ 
         که اسم پرورپرتی های مدل ما باید با نام انپوت های ویو یکی باشه
        که به صورت اتوماتیک بایند بشه با مدل ما
        */

        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
