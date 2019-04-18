namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRates) " +
                "VALUES " +
                "(0,0,0),(30,1,10),(90,3,15),(300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
