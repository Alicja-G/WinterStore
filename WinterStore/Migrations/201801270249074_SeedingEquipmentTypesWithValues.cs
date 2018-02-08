namespace WinterStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingEquipmentTypesWithValues : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EquipmentTypes(EquipmentTypeTypeOfSport, EquipmentTypeAdultOrJunior) VALUES ('Snowboard', 'Adult')");
            Sql("INSERT INTO EquipmentTypes(EquipmentTypeTypeOfSport, EquipmentTypeAdultOrJunior) VALUES ('Snowboard', 'Junior')");
            Sql("INSERT INTO EquipmentTypes(EquipmentTypeTypeOfSport, EquipmentTypeAdultOrJunior) VALUES ('Skiing', 'Adult')");
            Sql("INSERT INTO EquipmentTypes(EquipmentTypeTypeOfSport, EquipmentTypeAdultOrJunior) VALUES ('Skiing', 'Junior')");
            Sql("INSERT INTO EquipmentTypes(EquipmentTypeTypeOfSport, EquipmentTypeAdultOrJunior) VALUES ('Universal', 'Adult')");
            Sql("INSERT INTO EquipmentTypes(EquipmentTypeTypeOfSport, EquipmentTypeAdultOrJunior) VALUES ('Universal', 'Junior')");
        }
        
        public override void Down()
        {
        }
    }
}
