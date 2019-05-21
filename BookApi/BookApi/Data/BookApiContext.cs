using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksApi.Models;

namespace BookApi.Models
{
    public class BookApiContext : DbContext
    {
        public BookApiContext (DbContextOptions<BookApiContext> options)
            : base(options)
        {
        }

        public DbSet<BooksApi.Models.Book> Book { get; set; }
    }
}
