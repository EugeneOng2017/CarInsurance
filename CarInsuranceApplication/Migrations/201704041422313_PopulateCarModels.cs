namespace CarInsuranceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarModels : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarModels(Id, Make, Model, BasePrice) VALUES(1, 'Toyota', 'Altis', 1000)");
            Sql("INSERT INTO CarModels(Id, Make, Model, BasePrice) VALUES(2, 'Toyota', 'Camry', 1500)");
            Sql("INSERT INTO CarModels(Id, Make, Model, BasePrice) VALUES(3, 'Honda', 'Civic', 1000)");
            Sql("INSERT INTO CarModels(Id, Make, Model, BasePrice) VALUES(4, 'Honda', 'Fit', 800)");
            Sql("INSERT INTO CarModels(Id, Make, Model, BasePrice) VALUES(5, 'BMW', '520', 2000)");
            Sql("INSERT INTO CarModels(Id, Make, Model, BasePrice) VALUES(6, 'BMW', '630', 2500)");
        }
        
        public override void Down()
        {
        }
    }
}
