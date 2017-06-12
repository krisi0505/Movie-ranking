namespace MovieSystem.App.Migrations
{
    using MovieSystem.App.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieSystem.App.Models.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieContext context)
        {
            context.Genres.Add(new Genre { Id = 1, Name = "Action" });
            context.Genres.Add(new Genre { Id = 2, Name = "Fantasy" });
            context.Genres.Add(new Genre { Id = 3, Name = "Adventure" });
            context.Genres.Add(new Genre { Id = 4, Name = "Drama" });
            context.Genres.Add(new Genre { Id = 5, Name = "Sci-Fi" });
            context.Genres.Add(new Genre { Id = 6, Name = "Science" });

            for (int i = 1; i < 11; i++)
            {
                context.Ranks.Add(new Rank { Id = i, Name = (i - 1).ToString() });
            }

            context.Actors.Add(new Actor { Id = 1, Name = "Johnny Depp" });
            context.Actors.Add(new Actor { Id = 2, Name = "Geoffrey Rush" });
            context.Actors.Add(new Actor { Id = 3, Name = " Hugh Jackman" });
            context.Actors.Add(new Actor { Id = 4, Name = "Patrick Stewart" });
            context.Actors.Add(new Actor { Id = 5, Name = "Gal Gadot" });
            context.Actors.Add(new Actor { Id = 6, Name = "Chris Pinek" });


            context.Movies.Add(
                new Movie
                {
                    Id = 3,
                    Title = "Wonder Woman",
                    Director = "Patty Jenkins",
                    Description = "Before she was Wonder Woman she was Diana, princess of the Amazons, trained warrior.When a pilot crashes and tells of conflict in the outside world, she leaves home to fight a war to end all wars, discovering her full powers and true destiny.",
                    BasedOnBook = false,
                    BookId = null,
                    Rank = new Rank { Id = 12, Name = "Super" }
                });

            context.SaveChanges();



        }
    }
}
