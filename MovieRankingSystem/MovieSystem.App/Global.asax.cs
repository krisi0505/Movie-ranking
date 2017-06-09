using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using MovieSystem.App.Models;
using MovieSystem.App.Migrations;

namespace MovieSystem.App
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize the product database.
            //Database.SetInitializer(new MovieDatabaseInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieContext, Configuration>());
        }
    }
}