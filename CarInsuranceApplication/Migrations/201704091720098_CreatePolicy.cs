namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePolicy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriverId = c.Int(nullable: false),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PlanName = c.String(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: true)
                .Index(t => t.DriverId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Policies", "DriverId", "dbo.Drivers");
            DropIndex("dbo.Policies", new[] { "DriverId" });
            DropTable("dbo.Policies");
        }
    }
}
