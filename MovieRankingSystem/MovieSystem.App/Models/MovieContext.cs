using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieSystem.App.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() 
            : base("MovieSystemConnection")
        {
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}