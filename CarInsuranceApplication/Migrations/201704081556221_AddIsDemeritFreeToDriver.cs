namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDemeritFreeToDriver : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "IsDemeritFree", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "IsDemeritFree");
        }
    }
}
