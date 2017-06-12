using MovieSystem.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace MovieSystem.App
{
    public partial class _Default : Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Movie> moviesGrid_GetData()
        {
            MovieContext context = new MovieContext();

            //var actors = context.Actors;
            var movies = context.Movies;
            return movies;

        }

        public IQueryable<Actor> actors_GetData(int MovieId)
        {
            MovieContext context = new MovieContext();

            var movie = context.Movies.Where(m => m.Id == MovieId);
            var movieActors = context.Actors
                .Where(a => a.Movies.Contains(movie as Movie));

            return movieActors;

        }

        public void moviesGrid_UpdateItem(int id)
        {
            Movie item = null;

            using (MovieContext context = new MovieContext())
            {
                item = context.Movies.Find(id);

                if (item == null)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                    return;
                }
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    context.SaveChanges();
                }
            }
        }

        public void moviesGrid_DeleteItem(int id)
        {
            using (MovieContext context = new MovieContext())
            {
                var item = context.Movies.Find(id);
                context.Entry(item).State = EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} no longer exists in the database.", id));
                }
            }
        }
    }
}