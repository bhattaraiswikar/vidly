namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IssubscribedtoNewsLetter, MembershipTypeId) " +
                "VALUES " +
                "('John Smith',0,1),('Michael Jordan',1,3), ('George Williams',0,4)" );
        }
        
        public override void Down()
        {
        }
    }
}
