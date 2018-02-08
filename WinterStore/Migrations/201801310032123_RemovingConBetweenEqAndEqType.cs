namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingConBetweenEqAndEqType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Equipments", "EquipmentType_Id", "dbo.EquipmentTypes");
            DropIndex("dbo.Equipments", new[] { "EquipmentType_Id" });
            DropColumn("dbo.Equipments", "EquipmentType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "EquipmentType_Id", c => c.Int());
            CreateIndex("dbo.Equipments", "EquipmentType_Id");
            AddForeignKey("dbo.Equipments", "EquipmentType_Id", "dbo.EquipmentTypes", "Id");
        }
    }
}
