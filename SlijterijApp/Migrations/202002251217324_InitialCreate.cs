namespace SlijterijApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WhiskeyModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Region = c.String(),
                        AlcoholPercentage = c.Double(nullable: false),
                        Type = c.String(),
                        Label = c.Binary(),
                        AvalableAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WhiskeyModels");
        }
    }
}
