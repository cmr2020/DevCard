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
                new Article(1,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","blog-post-thumb-card-2.jpg"),
                new Article(3,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","blog-post-thumb-card-3.jpg"),
                new Article(4,"آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی","blog-post-thumb-card-4.jpg"),
            };
            return View("_Articles",articles);
        }

    }
}
