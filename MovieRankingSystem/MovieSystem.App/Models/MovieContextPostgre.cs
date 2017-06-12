using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieSystem.App.Models
{
    public class MovieContextPostgre : DbContext
    {
        public MovieContextPostgre() 
            : base("MovieSystemPostgre")
        {
        }

        public IDbSet<Actor> Actors { get; set; }
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Book> Books { get; set; }
        public IDbSet<Rank> Ranks { get; set; }
        public IDbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

    }
}