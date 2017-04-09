namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDrivingExperiences : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DrivingExperiences(Id, Name) VALUES(1, '<1')");
            Sql("INSERT INTO DrivingExperiences(Id, Name) VALUES(2, '1')");
            Sql("INSERT INTO DrivingExperiences(Id, Name) VALUES(3, '2')");
            Sql("INSERT INTO DrivingExperiences(Id, Name) VALUES(4, '>5')");
            Sql("INSERT INTO DrivingExperiences(Id, Name) VALUES(5, '>10')");
        }
        
        public override void Down()
        {
        }
    }
}
