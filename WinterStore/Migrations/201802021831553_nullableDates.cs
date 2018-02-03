namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullableDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Equipments", "DateOfRent", c => c.DateTime());
            AlterColumn("dbo.Equipments", "DateOfReturn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipments", "DateOfReturn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Equipments", "DateOfRent", c => c.DateTime(nullable: false));
        }
    }
}
