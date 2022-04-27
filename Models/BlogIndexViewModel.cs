using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class BlogIndexViewModel
    {
        public IList<Article> Articles { get; set; }

        public BlogIndexViewModel()
        {
            Articles = new List<Article>();
        }
    }
}
