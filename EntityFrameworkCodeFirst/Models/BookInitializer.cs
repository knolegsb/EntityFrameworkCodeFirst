using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Models
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var categories = new List<Category>
            {
                new Category { CategoryName = "WPF" },
                new Category { CategoryName = "Javascript" },
                new Category { CategoryName = "ASP.NET" }
            };

            foreach(var c in categories)
            {
                context.Categories.Add(c);
            };
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author { FirstName = "MIke", LastName = "Shore" },
                new Author { FirstName = "Ingmar", LastName = "Spingred" }
            };
            foreach(var a in authors)
            {
                context.Authors.Add(a);
            };
            context.SaveChanges();

            var book = new Book
            {
                Title = "Beginning ASP.NET Web Pages",
                Description = "Buy this book!",
                ISBN = "978012212212",
                DatePublished = new DateTime(2015, 10, 28),
                AuthorId = 1,
                CategoryId = 3
            };
            context.Books.Add(book);
            context.SaveChanges();

            categories = context.Categories.OrderBy(c => c.CategoryName).ToList();
            authors = context.Authors.OrderByDescending(a => a.FirstName).ToList();
            book = context.Books.FirstOrDefault();
        }
    }
}