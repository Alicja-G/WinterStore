namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingUnnecessaryProductTypeProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "PriceFor1HourOfRent", c => c.Double(nullable: false));
            AddColumn("dbo.ProductTypes", "ProductTypeTypeOfSport", c => c.String(nullable: false));
            AddColumn("dbo.ProductTypes", "ProductTypeAdultOrJunior", c => c.String(nullable: false));
            DropColumn("dbo.Products", "PriceFor1DayOfRent");
            DropColumn("dbo.ProductTypes", "ProductTypeName");
            DropColumn("dbo.ProductTypes", "MinimumHeightRequiredInCm");
            DropColumn("dbo.ProductTypes", "MaximumHeightInCm");
            DropColumn("dbo.ProductTypes", "MinimumWeightRequiredInKg");
            DropColumn("dbo.ProductTypes", "MaximumWeightInKg");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductTypes", "MaximumWeightInKg", c => c.Double(nullable: false));
            AddColumn("dbo.ProductTypes", "MinimumWeightRequiredInKg", c => c.Double(nullable: false));
            AddColumn("dbo.ProductTypes", "MaximumHeightInCm", c => c.Double(nullable: false));
            AddColumn("dbo.ProductTypes", "MinimumHeightRequiredInCm", c => c.Double(nullable: false));
            AddColumn("dbo.ProductTypes", "ProductTypeName", c => c.String(nullable: false));
            AddColumn("dbo.Products", "PriceFor1DayOfRent", c => c.Double(nullable: false));
            DropColumn("dbo.ProductTypes", "ProductTypeAdultOrJunior");
            DropColumn("dbo.ProductTypes", "ProductTypeTypeOfSport");
            DropColumn("dbo.Products", "PriceFor1HourOfRent");
        }
    }
}
