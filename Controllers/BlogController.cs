using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstMVC.Models;
using MyFirstMVC.Data;

namespace MyFirstMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _context;
        public BlogController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            BlogIndexViewModel model = new()
            {
                  Articles = _context.Articles.ToList()
            };

            return View(model);
        }
    }
}
