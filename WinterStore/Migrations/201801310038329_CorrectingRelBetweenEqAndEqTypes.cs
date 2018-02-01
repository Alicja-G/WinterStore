namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectingRelBetweenEqAndEqTypes : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Equipments");
            DropPrimaryKey("dbo.EquipmentTypes");
            AddColumn("dbo.Equipments", "EquipmentTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Equipments", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.EquipmentTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Equipments", "Id");
            AddPrimaryKey("dbo.EquipmentTypes", "Id");
            CreateIndex("dbo.Equipments", "EquipmentTypeId");
            AddForeignKey("dbo.Equipments", "EquipmentTypeId", "dbo.EquipmentTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "EquipmentTypeId", "dbo.EquipmentTypes");
            DropIndex("dbo.Equipments", new[] { "EquipmentTypeId" });
            DropPrimaryKey("dbo.EquipmentTypes");
            DropPrimaryKey("dbo.Equipments");
            AlterColumn("dbo.EquipmentTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Equipments", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Equipments", "EquipmentTypeId");
            AddPrimaryKey("dbo.EquipmentTypes", "Id");
            AddPrimaryKey("dbo.Equipments", "Id");
        }
    }
}
