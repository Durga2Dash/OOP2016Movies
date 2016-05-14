using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
// Not needed for ASP.NET 5 MVC 6 app
//    public class MovieDBContext : DbContext
//    {
//        public DbSet<Movie> Movies { get; set; }
//    }
}
