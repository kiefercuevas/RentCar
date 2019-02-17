namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkShifts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [WorkShifts] VALUES ('MATUTINA',8)");
            Sql("INSERT INTO [WorkShifts] VALUES ('VESPERTINA',8)");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE [WorkShifts]");
        }
    }
}
