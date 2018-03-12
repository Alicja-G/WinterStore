namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertExampleData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Equipments] ON");
            Sql("INSERT INTO[dbo].[Equipments] ([Id], [EquipmentName], [PriceFor1HourOfRent], [NumberInStock], [DateOfRent], [DateOfReturn], [EquipmentTypeId], [NumberAvailable]) VALUES(81, N'SALOMON XDR 807i SKIS', 10, 2, NULL, NULL, 3, 2)");
            Sql("INSERT INTO[dbo].[Equipments] ([Id], [EquipmentName], [PriceFor1HourOfRent], [NumberInStock], [DateOfRent], [DateOfReturn], [EquipmentTypeId], [NumberAvailable]) VALUES(42, N'FLOW VIPER 2016-2017 SNOWBOARD', 50, 5, NULL, NULL, 1, 5)");
            Sql("INSERT INTO[dbo].[Equipments] ([Id], [EquipmentName], [PriceFor1HourOfRent], [NumberInStock], [DateOfRent], [DateOfReturn], [EquipmentTypeId], [NumberAvailable]) VALUES(32, N'HEAD THE STELLA 2018 SNOWBOARD', 35, 7, NULL, NULL, 2, 6)");
            Sql("INSERT INTO[dbo].[Equipments] ([Id], [EquipmentName], [PriceFor1HourOfRent], [NumberInStock], [DateOfRent], [DateOfReturn], [EquipmentTypeId], [NumberAvailable]) VALUES(52, N' HELMET ROSSIGNOL', 5, 7, NULL, NULL, 5, 4)");
            Sql("INSERT INTO[dbo].[Equipments] ([Id], [EquipmentName], [PriceFor1HourOfRent], [NumberInStock], [DateOfRent], [DateOfReturn], [EquipmentTypeId], [NumberAvailable]) VALUES(62, N'RASSIGNOL SMASH 7 SKIS', 34, 10, NULL, NULL, 4, 10)");
            Sql("INSERT INTO[dbo].[Equipments] ([Id], [EquipmentName], [PriceFor1HourOfRent], [NumberInStock], [DateOfRent], [DateOfReturn], [EquipmentTypeId], [NumberAvailable]) VALUES(72, N'XXX Snowborard', 56, 45, NULL, NULL, 1, 45)");
            Sql(" SET IDENTITY_INSERT[dbo].[Equipments]   OFF");

    }

    public override void Down()
        {
        }
    }
}
