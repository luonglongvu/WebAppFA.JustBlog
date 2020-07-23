using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models
{
    public class DbInitializer
    {
        public static void Seed(JustBlogContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categories.Any())
            {
                return;
            }
            // add categories
            var categories = new Category[]
            {
                new Category()
                {
                    Name = "Working",
                    UrlSlug = "https://www.msn.com/vi-vn/?ocid=wispr&pc=u477&AR=4",
                    Description = "Home",
                },
                new Category()
                {
                    Name = "Learning",
                    UrlSlug = "https://www.youtube.com/",
                    Description = "Home",
                },
                new Category()
                {
                    Name = "Relaxing",
                    UrlSlug = "https://www.youtube.com/",
                    Description = "Trending",
                },
            };
            context.Categories.AddRange(categories);

            // add post
            var posts = new Post[]
            {

            };
            context.Posts.AddRange(posts);
            // add Tag
            var tags = new Tag[]
            {

            };
            context.Tags.AddRange(tags);

            context.SaveChanges();
        }
    }
}
