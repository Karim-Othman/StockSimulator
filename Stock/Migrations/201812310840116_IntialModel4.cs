namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Money", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Money", c => c.String(nullable: false));
        }
    }
}
