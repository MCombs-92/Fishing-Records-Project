namespace Fishing_Records.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Databasetableconstruction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fish",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Species = c.String(nullable: false, maxLength: 50),
                        SubSpecies = c.String(nullable: false, maxLength: 50),
                        Weight = c.Int(),
                        BaitStyle = c.String(nullable: false, maxLength: 50),
                        BaitDesc = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fish");
        }
    }
}
