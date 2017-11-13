namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GonnaPopulateTheseGenresFORREALTHOUGH : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");

        }
        
        public override void Down()
        {
        }
    }
}
