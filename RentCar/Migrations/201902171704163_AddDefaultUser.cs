namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [Users](EmployeeID,Username,Password,RoleID)  " +
                "Values (1,'ADMIN','A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=',1)");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE [Users]");
        }
    }
}
