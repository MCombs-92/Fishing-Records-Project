namespace Fishing_Records.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fish",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Species = c.String(nullable: false, maxLength: 30),
                        Weight = c.Int(nullable: false),
                        Bait = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fish");
        }
    }
}
