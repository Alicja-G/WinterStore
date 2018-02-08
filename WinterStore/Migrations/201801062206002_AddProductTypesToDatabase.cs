namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductTypesToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        ProductTypeName = c.String(nullable: false),
                        MinimumHeightRequiredInCm = c.Double(nullable: false),
                        MaximumHeightInCm = c.Double(nullable: false),
                        MinimumWeightRequiredInKg = c.Double(nullable: false),
                        MaximumWeightInKg = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductTypes");
        }
    }
}
