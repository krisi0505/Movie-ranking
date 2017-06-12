using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieSystem.App.Models;

namespace MovieSystem.App
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addMovieForm_InsertItem()
        {
            var item = new Movie();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (MovieContext db = new MovieContext())
                {
                    db.Movies.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default");
        }

        protected void addMovieForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Default");
        }
    }
}