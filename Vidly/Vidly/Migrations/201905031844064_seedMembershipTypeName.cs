namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Pay as you Go' where Id = 1");
            

            //Sql("INSERT INTO MembershipTypes (Name)" +
            //    " VALUES " +
            //    "('Pay as you Go'),('Monthly'),('Quarterly'),('Yearly')");
        }
        
        public override void Down()
        {
        }
    }
}
