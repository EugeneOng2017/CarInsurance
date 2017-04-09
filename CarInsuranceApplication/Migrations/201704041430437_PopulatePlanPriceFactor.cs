namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePlanPriceFactor : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PlanPriceFactors(Id, Name, PriceFactor) VALUES(1, 'Plan 1', '1')");
            Sql("INSERT INTO PlanPriceFactors(Id, Name, PriceFactor) VALUES(2, 'Plan 2', '.7')");
            Sql("INSERT INTO PlanPriceFactors(Id, Name, PriceFactor) VALUES(3, 'Plan 3', '.5')");
        }
        
        public override void Down()
        {
        }
    }
}
