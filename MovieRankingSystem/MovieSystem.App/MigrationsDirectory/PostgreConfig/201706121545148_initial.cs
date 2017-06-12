namespace MovieSystem.App.Migrations.PostgreConfig
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Director = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 10000),
                        BasedOnBook = c.Boolean(nullable: false),
                        BookId = c.Int(),
                        Rank_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Ranks", t => t.Rank_Id)
                .ForeignKey("public.Books", t => t.BookId)
                .Index(t => t.BookId)
                .Index(t => t.Rank_Id);
            
            CreateTable(
                "public.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Movies", t => t.Movie_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "public.Ranks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Author = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.MovieActors",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Actor_Id })
                .ForeignKey("public.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("public.Actors", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Actor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Movies", "BookId", "public.Books");
            DropForeignKey("public.Movies", "Rank_Id", "public.Ranks");
            DropForeignKey("public.Genres", "Movie_Id", "public.Movies");
            DropForeignKey("public.MovieActors", "Actor_Id", "public.Actors");
            DropForeignKey("public.MovieActors", "Movie_Id", "public.Movies");
            DropIndex("public.MovieActors", new[] { "Actor_Id" });
            DropIndex("public.MovieActors", new[] { "Movie_Id" });
            DropIndex("public.Genres", new[] { "Movie_Id" });
            DropIndex("public.Movies", new[] { "Rank_Id" });
            DropIndex("public.Movies", new[] { "BookId" });
            DropTable("public.MovieActors");
            DropTable("public.Books");
            DropTable("public.Ranks");
            DropTable("public.Genres");
            DropTable("public.Movies");
            DropTable("public.Actors");
        }
    }
}
