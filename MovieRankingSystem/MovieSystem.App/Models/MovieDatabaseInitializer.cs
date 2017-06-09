using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieSystem.App.Models
{
    public class MovieDatabaseInitializer : DropCreateDatabaseIfModelChanges<MovieContext>
    {

        protected override void Seed(MovieContext context)
        {
            GetMovies().ForEach(m => context.Movies.Add(m));
            GetBooks().ForEach(b => context.Books.Add(b));
            GetGenres().ForEach(g => context.Genres.Add(g));

        }

        private static List<Movie> GetMovies()
        {
            var movies = new List<Movie> {
                new Movie
                {
                    Id = 1,
                    Title = "test1",
                    Director="test2",
                    Description="test3",
                    Genre = GetGenres(),
                    BasedOnBook= false,
                    BookId = null,
                    Rank = null
                }
            };

            return movies;
        }

        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                   Id = 1,
                   Name = "test",
                   Author = "test2",
                   Movies = null
               } };

            return books;
        }

        private static List<Genre> GetGenres()
        {
            var genres = new List<Genre> {
                new Genre { Id = 1, Name = "action" },
                new Genre { Id = 2, Name = "comedy" }
            };

            return genres;
        }
    }
}