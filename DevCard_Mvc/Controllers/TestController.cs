using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace DevCard_Mvc.Controllers
{
    public class TestController : Controller
    {

        //این کد هیچ فرقی ابا کد پایین نداره چون همه این ها از اکشن ریزالت ایمپلیمنت ردن
        //public IActionResult Test()
        //{
        //    return PartialView();
        //}

        //یک تیکه از ویو رو برمیگردونه
        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //در واقع با استفاده از کانتنت دیگه نیاز به ویو نیست و میتونیم کد اچ  تی  ام ال خودمون رو همین جا بنویسیم 

        //public ContentResult Index()
        //{
        //    return Content("<h1 style='color:red'>Hello asp.net core mvc student.</h1>", "text/html");
        //}

        //public FileResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);

        //}

        //

        /* 
         در بعضی از مواقع نیازه از جیسان استفاده بکنیم
        تا دیتا رو به صورت تکست به کاربر نمایش بدیم
        مثلا ت موبایل اچ تی ام ال متوجه نمیشه  باید از جیسان استفاده بکنیم        
         */

        //public JsonResult Index()
        //{
        //    //خود دات نت این دیتا ما رو تبدیل به جیسان میکنه
        //    return Json(new
        //    {
        //        id = 12,
        //        name = "reza",
        //        job = "programmer",
        //        site = "toplearn.com"
        //    });
        //}


        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('Salam salam dostan')");
        //}
    
        //public RedirectResult Index()
        //{
        //    return Redirect("http://toplearn.com");
        //}


        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}

        public IActionResult Index()
        {
            //return new OkResult();
            //return new NotFoundResult();
            return new StatusCodeResult(510);
        }

    }

    //public class JavascriptResult:ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}


}
