namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultEmployee : DbMigration
    {
        public override void Up()
        {
            var date = DateTime.Today.Date;
            Sql("INSERT INTO [Employees] (Name,IdentificationCard,AdmissionDate,WorkShiftID,CommissionPercentage,State) " +
                "VALUES ('kiefer','40225413133','" + date + "',1,0,1)");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE [Employees]");
        }
    }
}
