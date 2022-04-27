using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class BlogController : Controller
    {
        private IList<Article> Articles { get; set; }

        public BlogController()
        {
            Articles = new List<Article>
            {
                new Article
                {
                    Title = "Mon article",
                    Content = "Lorem ipsum dolor sit amet",
                    Auhtor = "John DOE"
                },
                new Article
                {
                    Title = "Mon article",
                    Content = "Lorem ipsum dolor sit amet",
                    Auhtor = "John DOE"
                },
                new Article
                {
                    Title = "Mon article",
                    Content = "Lorem ipsum dolor sit amet",
                    Auhtor = "John DOE"
                },
                new Article
                {
                    Title = "Mon article",
                    Content = "Lorem ipsum dolor sit amet",
                    Auhtor = "John DOE"
                },
            };
        }

        public IActionResult Index()
        {
            BlogIndexViewModel model = new BlogIndexViewModel
            {
                  Articles = Articles
            };

            return View(model);
        }
    }
}
