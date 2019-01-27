namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultFluelQuantity : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [FluelQuantities] VALUES (0.25)");
            Sql("INSERT INTO [FluelQuantities] VALUES (0.50)");
            Sql("INSERT INTO [FluelQuantities] VALUES (0.75)");
            Sql("INSERT INTO [FluelQuantities] VALUES (1)");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE [FluelQuantities]");
        }
    }
}
