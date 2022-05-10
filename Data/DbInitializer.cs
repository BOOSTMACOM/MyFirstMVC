using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BlogContext context)
        {
            context.Database.EnsureCreated();

            Article[] articles = new Article[]
            {
                new Article{Title="Article n°1",Content="Lorem ipsum dolor sit amet",Author="Moi"},
                new Article{Title="Article n°2",Content="Lorem ipsum dolor sit amet",Author="Moi"},
                new Article{Title="Article n°3",Content="Lorem ipsum dolor sit amet",Author="Moi"},
                new Article{Title="Article n°4",Content="Lorem ipsum dolor sit amet",Author="Moi"},
                new Article{Title="Article n°5",Content="Lorem ipsum dolor sit amet",Author="Moi"},
                new Article{Title="Article n°6",Content="Lorem ipsum dolor sit amet",Author="Moi"},
            };

            foreach (Article a in articles)
            {
                context.Articles.Add(a);
            }

            context.SaveChanges();

        }
    }
}
