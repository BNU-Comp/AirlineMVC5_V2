namespace AirlineMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(nullable: false),
                        Street = c.String(),
                        Town = c.String(),
                        County = c.Int(nullable: false),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
