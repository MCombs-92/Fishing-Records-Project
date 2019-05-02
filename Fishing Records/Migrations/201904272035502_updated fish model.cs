namespace Fishing_Records.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedfishmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fish", "Markedforremoval", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fish", "Markedforremoval");
        }
    }
}
