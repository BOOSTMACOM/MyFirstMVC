using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstMVC.Models;
using MyFirstMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace MyFirstMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            BlogIndexViewModel model = new BlogIndexViewModel
            {
                  Articles = await _context.Articles.ToListAsync()
            };

            return View(model);
        }
    }
}
