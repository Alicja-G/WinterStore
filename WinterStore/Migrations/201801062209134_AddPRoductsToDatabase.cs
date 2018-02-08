namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPRoductsToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        PriceFor1DayOfRent = c.Double(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        IsCurrentlyRented = c.Boolean(nullable: false),
                        DateOfRent = c.DateTime(nullable: false),
                        DateOfReturn = c.DateTime(nullable: false),
                        NumberOfDaysLeftToReturn = c.Int(nullable: false),
                        ProductType_ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_ProductTypeId, cascadeDelete: true)
                .Index(t => t.ProductType_ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            DropTable("dbo.Products");
        }
    }
}
