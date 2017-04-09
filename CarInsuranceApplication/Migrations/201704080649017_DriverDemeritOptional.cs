namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DriverDemeritOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Drivers", "Demerit", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Drivers", "Demerit", c => c.Byte(nullable: false));
        }
    }
}
