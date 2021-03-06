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

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
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
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش بکنید";
                return View(model);
            }

            ViewBag.success = "پیغام شما با موفقیت ارسال شد. با تشکر";
            return View();
            //return RedirectToAction("Index");
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
