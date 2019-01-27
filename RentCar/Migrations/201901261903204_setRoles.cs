namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [ROLES] VALUES ('ADMIN')");
            Sql("INSERT INTO [ROLES] VALUES ('USER')");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE [ROLES]");
        }
    }
}
