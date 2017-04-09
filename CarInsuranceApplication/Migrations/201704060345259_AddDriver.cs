namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriver : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Gender = c.String(maxLength: 50),
                        Occupation = c.String(maxLength: 255),
                        Birthdate = c.DateTime(nullable: false),
                        DrivingExperienceId = c.Int(nullable: false),
                        Demerit = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DrivingExperiences", t => t.DrivingExperienceId, cascadeDelete: true)
                .Index(t => t.DrivingExperienceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "DrivingExperienceId", "dbo.DrivingExperiences");
            DropIndex("dbo.Drivers", new[] { "DrivingExperienceId" });
            DropTable("dbo.Drivers");
        }
    }
}
