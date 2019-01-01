namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Money", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Money");
        }
    }
}
