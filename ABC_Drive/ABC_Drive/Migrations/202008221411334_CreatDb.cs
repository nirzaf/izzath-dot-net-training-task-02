namespace ABC_Drive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriverName = c.String(nullable: false),
                        DriverCost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        RentId = c.Int(nullable: false, identity: true),
                        RentedDate = c.DateTime(nullable: false),
                        ReturnedDate = c.DateTime(nullable: false),
                        TotDays = c.Int(nullable: false),
                        TotDriverCost = c.Int(nullable: false),
                        TotDaysAmnt = c.Int(nullable: false),
                        TotWeeksAmnt = c.Int(nullable: false),
                        TotMonthsAmnt = c.Int(nullable: false),
                        TotalRent = c.Single(nullable: false),
                        Driver_Id = c.Int(),
                        Vechicle_VechicleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RentId)
                .ForeignKey("dbo.Drivers", t => t.Driver_Id)
                .ForeignKey("dbo.Vechicles", t => t.Vechicle_VechicleId, cascadeDelete: true)
                .Index(t => t.Driver_Id)
                .Index(t => t.Vechicle_VechicleId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "Vechicle_VechicleId", "dbo.Vechicles");
            DropForeignKey("dbo.Rents", "Driver_Id", "dbo.Drivers");
            DropIndex("dbo.Rents", new[] { "Vechicle_VechicleId" });
            DropIndex("dbo.Rents", new[] { "Driver_Id" });
            DropTable("dbo.Vechicles");
            DropTable("dbo.Rents");
            DropTable("dbo.Drivers");
        }
    }
}
