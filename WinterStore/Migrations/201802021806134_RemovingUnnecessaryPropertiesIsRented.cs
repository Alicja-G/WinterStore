namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingUnnecessaryPropertiesIsRented : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Equipments", "IsCurrentlyRented");
            DropColumn("dbo.Equipments", "NumberOfDaysLeftToReturn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "NumberOfDaysLeftToReturn", c => c.Int(nullable: false));
            AddColumn("dbo.Equipments", "IsCurrentlyRented", c => c.Boolean(nullable: false));
        }
    }
}
