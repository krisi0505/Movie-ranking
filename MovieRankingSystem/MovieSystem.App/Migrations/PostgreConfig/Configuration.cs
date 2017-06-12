using MovieSystem.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MovieSystem.App.Migrations.PostgreConfig
{
    public class Configuration : DbMigrationsConfiguration<MovieSystem.App.Models.MovieContextPostgre>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.MigrationsDirectory = @"MigrationsDirectory\PostgreConfig";
        }

        protected override void Seed(MovieContextPostgre context)
        {
            
        }
    }
}