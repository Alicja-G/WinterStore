namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingUnneceessaryProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Equipments", "EquipmentTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "EquipmentTypeId", c => c.Byte(nullable: false));
        }
    }
}
