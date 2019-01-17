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
                        VehicleID = c.Int(nullable: false),
                        IncomeDate = c.DateTime(nullable: false),
                        RefundDate = c.DateTime(nullable: false),
                        AmountPerDay = c.Single(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                        Commentary = c.String(),
                        State = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IncomeID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.VehicleID);
            
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
                "dbo.WorkShifts",
                c => new
                    {
                        WorkShiftID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        WorkShiftHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkShiftID);
            
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
                    })
                .PrimaryKey(t => t.InspectionID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.FluelQuantities", t => t.FluelQuantityID, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.VehicleID)
                .Index(t => t.ClientID)
                .Index(t => t.FluelQuantityID);
            
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
                "dbo.PersonTypes",
                c => new
                    {
                        PersonTypeID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonTypeID);
            
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
                    })
                .PrimaryKey(t => t.RubberID);
            
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
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.RubberStateInspections",
                c => new
                    {
                        RubberState_RubberID = c.Int(nullable: false),
                        Inspection_InspectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RubberState_RubberID, t.Inspection_InspectionID })
                .ForeignKey("dbo.RubberStates", t => t.RubberState_RubberID, cascadeDelete: true)
                .ForeignKey("dbo.Inspections", t => t.Inspection_InspectionID, cascadeDelete: true)
                .Index(t => t.RubberState_RubberID)
                .Index(t => t.Inspection_InspectionID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Role_RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Role_RoleID })
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_RoleID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Role_RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Vehicles", "VehicleTypeID", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "ModelID", "dbo.Models");
            DropForeignKey("dbo.Inspections", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.RubberStateInspections", "Inspection_InspectionID", "dbo.Inspections");
            DropForeignKey("dbo.RubberStateInspections", "RubberState_RubberID", "dbo.RubberStates");
            DropForeignKey("dbo.Inspections", "FluelQuantityID", "dbo.FluelQuantities");
            DropForeignKey("dbo.Clients", "PersonTypeID", "dbo.PersonTypes");
            DropForeignKey("dbo.Inspections", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.IncomeAndRefunds", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.Employees", "WorkShiftID", "dbo.WorkShifts");
            DropForeignKey("dbo.IncomeAndRefunds", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Vehicles", "FluelTypeID", "dbo.FluelTypes");
            DropForeignKey("dbo.Vehicles", "BrandID", "dbo.Brands");
            DropForeignKey("dbo.Models", "BrandID", "dbo.Brands");
            DropIndex("dbo.UserRoles", new[] { "Role_RoleID" });
            DropIndex("dbo.UserRoles", new[] { "User_UserID" });
            DropIndex("dbo.RubberStateInspections", new[] { "Inspection_InspectionID" });
            DropIndex("dbo.RubberStateInspections", new[] { "RubberState_RubberID" });
            DropIndex("dbo.Users", new[] { "EmployeeID" });
            DropIndex("dbo.Clients", new[] { "PersonTypeID" });
            DropIndex("dbo.Inspections", new[] { "FluelQuantityID" });
            DropIndex("dbo.Inspections", new[] { "ClientID" });
            DropIndex("dbo.Inspections", new[] { "VehicleID" });
            DropIndex("dbo.Employees", new[] { "WorkShiftID" });
            DropIndex("dbo.IncomeAndRefunds", new[] { "VehicleID" });
            DropIndex("dbo.IncomeAndRefunds", new[] { "EmployeeID" });
            DropIndex("dbo.Vehicles", new[] { "FluelTypeID" });
            DropIndex("dbo.Vehicles", new[] { "ModelID" });
            DropIndex("dbo.Vehicles", new[] { "BrandID" });
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeID" });
            DropIndex("dbo.Models", new[] { "BrandID" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.RubberStateInspections");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.RubberStates");
            DropTable("dbo.FluelQuantities");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.Clients");
            DropTable("dbo.Inspections");
            DropTable("dbo.WorkShifts");
            DropTable("dbo.Employees");
            DropTable("dbo.IncomeAndRefunds");
            DropTable("dbo.FluelTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Models");
            DropTable("dbo.Brands");
        }
    }
}
