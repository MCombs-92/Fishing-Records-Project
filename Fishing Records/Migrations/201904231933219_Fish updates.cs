namespace Fishing_Records.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fishupdates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fish", "Bait", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fish", "Bait", c => c.String(nullable: false));
        }
    }
}
