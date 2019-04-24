namespace Fishing_Records.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowednullableweightinclassFish : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fish", "Weight", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fish", "Weight", c => c.Int(nullable: false));
        }
    }
}
