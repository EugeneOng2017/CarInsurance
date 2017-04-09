namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlanPriceFactor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlanPriceFactors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        PriceFactor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlanPriceFactors");
        }
    }
}
