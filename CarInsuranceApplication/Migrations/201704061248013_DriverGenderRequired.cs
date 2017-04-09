namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DriverGenderRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Drivers", "Gender", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Drivers", "Gender", c => c.String(maxLength: 50));
        }
    }
}
