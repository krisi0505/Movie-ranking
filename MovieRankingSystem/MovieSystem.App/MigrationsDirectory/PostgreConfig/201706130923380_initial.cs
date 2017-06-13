namespace MovieSystem.App.Migrations.PostgreConfig
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Genres", "Movie_Id", "public.Movies");
            DropIndex("public.Genres", new[] { "Movie_Id" });
            CreateTable(
                "public.GenreMovies",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Movie_Id })
                .ForeignKey("public.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("public.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Movie_Id);
            
            DropColumn("public.Genres", "Movie_Id");
        }
        
        public override void Down()
        {
            AddColumn("public.Genres", "Movie_Id", c => c.Int());
            DropForeignKey("public.GenreMovies", "Movie_Id", "public.Movies");
            DropForeignKey("public.GenreMovies", "Genre_Id", "public.Genres");
            DropIndex("public.GenreMovies", new[] { "Movie_Id" });
            DropIndex("public.GenreMovies", new[] { "Genre_Id" });
            DropTable("public.GenreMovies");
            CreateIndex("public.Genres", "Movie_Id");
            AddForeignKey("public.Genres", "Movie_Id", "public.Movies", "Id");
        }
    }
}
