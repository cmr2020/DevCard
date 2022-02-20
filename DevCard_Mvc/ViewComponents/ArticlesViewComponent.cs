using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_Mvc.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","Course1.png"),
                new Article(2,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","Course2.png"),
                new Article(3,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","Course3.png"),
                new Article(4,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","Course4.png"),
                new Article(4,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","Course5.png"),
                new Article(4,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","Course6.png"),
            };
            return View("_Articles",articles);
        }

    }
}
