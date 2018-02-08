namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamingProductToEquipment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentName = c.String(nullable: false),
                        PriceFor1HourOfRent = c.Double(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        IsCurrentlyRented = c.Boolean(nullable: false),
                        DateOfRent = c.DateTime(nullable: false),
                        DateOfReturn = c.DateTime(nullable: false),
                        NumberOfDaysLeftToReturn = c.Int(nullable: false),
                        EquipmentTypeId = c.Byte(nullable: false),
                        EquipmentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentType_Id)
                .Index(t => t.EquipmentType_Id);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentTypeTypeOfSport = c.String(nullable: false),
                        EquipmentTypeAdultOrJunior = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Products");
            DropTable("dbo.ProductTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        ProductTypeTypeOfSport = c.String(nullable: false),
                        ProductTypeAdultOrJunior = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        PriceFor1HourOfRent = c.Double(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        IsCurrentlyRented = c.Boolean(nullable: false),
                        DateOfRent = c.DateTime(nullable: false),
                        DateOfReturn = c.DateTime(nullable: false),
                        NumberOfDaysLeftToReturn = c.Int(nullable: false),
                        ProductType_ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            DropForeignKey("dbo.Equipments", "EquipmentType_Id", "dbo.EquipmentTypes");
            DropIndex("dbo.Equipments", new[] { "EquipmentType_Id" });
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Equipments");
            CreateIndex("dbo.Products", "ProductType_ProductTypeId");
            AddForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes", "ProductTypeId", cascadeDelete: true);
        }
    }
}
