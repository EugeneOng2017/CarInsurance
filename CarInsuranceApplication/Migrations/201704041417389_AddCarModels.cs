namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        BasePrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarModels");
        }
    }
}
