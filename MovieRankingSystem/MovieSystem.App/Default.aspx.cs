using MovieSystem.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieSystem.App
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Movie> moviesGrid_GetData()
        {
            MovieContext db = new MovieContext();
            var query = db.Movies;
            return query;
        }
    }
}