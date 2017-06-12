using MovieSystem.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using System.Linq;
using System.Web;

namespace MovieSystem.App.Migrations.SQLiteConfig
{
    public class SQLiteConfiguration : DbMigrationsConfiguration<MovieSystem.App.Models.MovieContextSQLite>
    {
        public SQLiteConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            this.MigrationsDirectory = @"MigrationsDirectory\SQLiteConfig";
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
            SetSqlGenerator("System.Data.SQLite.EF6", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(MovieContextSQLite context)
        {

        }
    }
}