namespace RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        State = c.Boolean(nullable: false),
                        BrandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelID)
                .ForeignKey("dbo.Brands", t => t.BrandID)
                .Index(t => t.BrandID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        ChassisNumber = c.String(nullable: false, maxLength: 17),
                        EngineNumber = c.String(nullable: false, maxLength: 16),
                        LicensePlateNumber = c.String(nullable: false, maxLength: 8),
                        VehicleTypeID = c.Int(nullable: false),
                        BrandID = c.Int(nullable: false),
                        ModelID = c.Int(nullable: false),
                        FluelTypeID = c.Int(nullable: false),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleID)
                .ForeignKey("dbo.Brands", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.FluelTypes", t => t.FluelTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.ModelID, cascadeDelete: true)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleTypeID, cascadeDelete: true)
                .Index(t => t.VehicleTypeID)
                .Index(t => t.BrandID)
                .Index(t => t.ModelID)
                .Index(t => t.FluelTypeID);
            
            CreateTable(
                "dbo.FluelTypes",
                c => new
                    {
                        FluelTypeID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FluelTypeID);
            
            CreateTable(
                "dbo.IncomeAndRefunds",
                c => new
                    {
                        IncomeID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        VehicleID = c.Int(nullable: false),
                        IncomeDate = c.DateTime(nullable: false),
                        RefundDate = c.DateTime(nullable: false),
                        AmountPerDay = c.Single(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                        Commentary = c.String(),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IncomeID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.ClientID)
                .Index(t => t.VehicleID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IdentificationCard = c.String(nullable: false, maxLength: 11),
                        CreditCardNumber = c.String(nullable: false, maxLength: 12),
                        CreditLimit = c.Single(nullable: false),
                        State = c.Boolean(nullable: false),
                        PersonTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID)
                .ForeignKey("dbo.PersonTypes", t => t.PersonTypeID, cascadeDelete: true)
                .Index(t => t.PersonTypeID);
            
            CreateTable(
                "dbo.Inspections",
                c => new
                    {
                        InspectionID = c.Int(nullable: false, identity: true),
                        VehicleID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        HasGrazes = c.Boolean(nullable: false),
                        FluelQuantityID = c.Int(nullable: false),
                        HasReplacementRubber = c.Boolean(nullable: false),
                        HasLeverCat = c.Boolean(nullable: false),
                        HasGlassBreaks = c.Boolean(nullable: false),
                        Etc = c.String(),
                        InspectionDate = c.DateTime(nullable: false),
                        State = c.Boolean(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        IncomeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InspectionID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.FluelQuantities", t => t.FluelQuantityID, cascadeDelete: true)
                .ForeignKey("dbo.IncomeAndRefunds", t => t.IncomeID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.VehicleID)
                .Index(t => t.ClientID)
                .Index(t => t.FluelQuantityID)
                .Index(t => t.EmployeeID)
                .Index(t => t.IncomeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IdentificationCard = c.String(nullable: false, maxLength: 11),
                        WorkShiftID = c.Int(nullable: false),
                        CommissionPercentage = c.Int(nullable: false),
                        AdmissionDate = c.DateTime(nullable: false),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.WorkShifts", t => t.WorkShiftID, cascadeDelete: true)
                .Index(t => t.WorkShiftID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.WorkShifts",
                c => new
                    {
                        WorkShiftID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        WorkShiftHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkShiftID);
            
            CreateTable(
                "dbo.FluelQuantities",
                c => new
                    {
                        FluelQuantityID = c.Int(nullable: false, identity: true),
                        Quantity = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.FluelQuantityID);
            
            CreateTable(
                "dbo.RubberStates",
                c => new
                    {
                        RubberID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        State = c.Boolean(nullable: false),
                        InspectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RubberID)
                .ForeignKey("dbo.Inspections", t => t.InspectionID, cascadeDelete: true)
                .Index(t => t.InspectionID);
            
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        PersonTypeID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonTypeID);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        VehicleTypeID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        State = c.Boolean(nullable: false),
                        RubberQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleTypeID);
            
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_RoleID = c.Int(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_RoleID, t.User_UserID })
                .ForeignKey("dbo.Roles", t => t.Role_RoleID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Role_RoleID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleTypeID", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "ModelID", "dbo.Models");
            DropForeignKey("dbo.IncomeAndRefunds", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.Clients", "PersonTypeID", "dbo.PersonTypes");
            DropForeignKey("dbo.Inspections", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.RubberStates", "InspectionID", "dbo.Inspections");
            DropForeignKey("dbo.Inspections", "IncomeID", "dbo.IncomeAndRefunds");
            DropForeignKey("dbo.Inspections", "FluelQuantityID", "dbo.FluelQuantities");
            DropForeignKey("dbo.Employees", "WorkShiftID", "dbo.WorkShifts");
            DropForeignKey("dbo.RoleUsers", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.Users", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Inspections", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.IncomeAndRefunds", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Inspections", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.IncomeAndRefunds", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Vehicles", "FluelTypeID", "dbo.FluelTypes");
            DropForeignKey("dbo.Vehicles", "BrandID", "dbo.Brands");
            DropForeignKey("dbo.Models", "BrandID", "dbo.Brands");
            DropIndex("dbo.RoleUsers", new[] { "User_UserID" });
            DropIndex("dbo.RoleUsers", new[] { "Role_RoleID" });
            DropIndex("dbo.RubberStates", new[] { "InspectionID" });
            DropIndex("dbo.Users", new[] { "EmployeeID" });
            DropIndex("dbo.Employees", new[] { "WorkShiftID" });
            DropIndex("dbo.Inspections", new[] { "IncomeID" });
            DropIndex("dbo.Inspections", new[] { "EmployeeID" });
            DropIndex("dbo.Inspections", new[] { "FluelQuantityID" });
            DropIndex("dbo.Inspections", new[] { "ClientID" });
            DropIndex("dbo.Inspections", new[] { "VehicleID" });
            DropIndex("dbo.Clients", new[] { "PersonTypeID" });
            DropIndex("dbo.IncomeAndRefunds", new[] { "VehicleID" });
            DropIndex("dbo.IncomeAndRefunds", new[] { "ClientID" });
            DropIndex("dbo.IncomeAndRefunds", new[] { "EmployeeID" });
            DropIndex("dbo.Vehicles", new[] { "FluelTypeID" });
            DropIndex("dbo.Vehicles", new[] { "ModelID" });
            DropIndex("dbo.Vehicles", new[] { "BrandID" });
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeID" });
            DropIndex("dbo.Models", new[] { "BrandID" });
            DropTable("dbo.RoleUsers");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.RubberStates");
            DropTable("dbo.FluelQuantities");
            DropTable("dbo.WorkShifts");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Employees");
            DropTable("dbo.Inspections");
            DropTable("dbo.Clients");
            DropTable("dbo.IncomeAndRefunds");
            DropTable("dbo.FluelTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Models");
            DropTable("dbo.Brands");
        }
    }
}
