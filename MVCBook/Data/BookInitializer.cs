using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using MVCBook.Models;

namespace MVCBook.Data
{
    public class BookInitializer : DropCreateDatabaseAlways<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            var books = new List<Book>();

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
        }
    }
}