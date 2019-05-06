namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenretable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy'),('Action'),('Family'),('Drama'),('Romance'),('Sci-fi'),('International')");
        }
        
        public override void Down()
        {
        }
    }
}
