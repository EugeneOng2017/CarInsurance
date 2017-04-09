namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrivingExperiences : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DrivingExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DrivingExperiences");
        }
    }
}
