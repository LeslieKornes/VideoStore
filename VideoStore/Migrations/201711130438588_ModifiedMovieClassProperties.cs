namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedMovieClassProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
