namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingPropertyEquipmentIdType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Equipments");
            AlterColumn("dbo.Equipments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Equipments", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Equipments");
            AlterColumn("dbo.Equipments", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Equipments", "Id");
        }
    }
}
