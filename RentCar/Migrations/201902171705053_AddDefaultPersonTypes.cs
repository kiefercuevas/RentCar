namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultPersonTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [PersonTypes] VALUES ('FISICA')");
            Sql("INSERT INTO [PersonTypes] VALUES ('JURIDICA')");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE [PersonTypes]");
        }
    }
}
