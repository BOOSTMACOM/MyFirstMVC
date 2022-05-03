using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any articles.
            if (context.Articles.Any())
            {
                return;   // DB has been seeded
            }

            var articles = new Article[]
            {
                new Article{Title="Article n°1",Auhtor="BOOSTMACOM",Content="Lorem ipsum dolor sit amet"},
                new Article{Title="Article n°2",Auhtor="BOOSTMACOM",Content="Lorem ipsum dolor sit amet"},
                new Article{Title="Article n°3",Auhtor="BOOSTMACOM",Content="Lorem ipsum dolor sit amet"},
                new Article{Title="Article n°4",Auhtor="BOOSTMACOM",Content="Lorem ipsum dolor sit amet"},
                new Article{Title="Article n°5",Auhtor="BOOSTMACOM",Content="Lorem ipsum dolor sit amet"},
            };
            foreach (Article a in articles)
            {
                context.Articles.Add(a);
            }
            context.SaveChanges();
        }
    }
}
