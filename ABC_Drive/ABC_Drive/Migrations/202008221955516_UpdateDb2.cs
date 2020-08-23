namespace ABC_Drive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDb2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rents", "Vechicle_VechicleId", "dbo.Vechicles");
            DropIndex("dbo.Rents", new[] { "Vechicle_VechicleId" });
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        VehicleNo = c.String(nullable: false),
                        VehicleName = c.String(nullable: false),
                        RatePerDay = c.Int(nullable: false),
                        RatePerWeek = c.Int(nullable: false),
                        RatePerMonth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId);
            
            AddColumn("dbo.Rents", "Vehicle_VehicleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rents", "Vehicle_VehicleId");
            AddForeignKey("dbo.Rents", "Vehicle_VehicleId", "dbo.Vehicles", "VehicleId", cascadeDelete: true);
            DropColumn("dbo.Rents", "Vechicle_VechicleId");
            DropTable("dbo.Vechicles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Vechicles",
                c => new
                    {
                        VechicleId = c.Int(nullable: false, identity: true),
                        VechicleNo = c.String(nullable: false),
                        VechicleName = c.String(nullable: false),
                        RatePerDay = c.Int(nullable: false),
                        RatePerWeek = c.Int(nullable: false),
                        RatePerMonth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VechicleId);
            
            AddColumn("dbo.Rents", "Vechicle_VechicleId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rents", "Vehicle_VehicleId", "dbo.Vehicles");
            DropIndex("dbo.Rents", new[] { "Vehicle_VehicleId" });
            DropColumn("dbo.Rents", "Vehicle_VehicleId");
            DropTable("dbo.Vehicles");
            CreateIndex("dbo.Rents", "Vechicle_VechicleId");
            AddForeignKey("dbo.Rents", "Vechicle_VechicleId", "dbo.Vechicles", "VechicleId", cascadeDelete: true);
        }
    }
}
