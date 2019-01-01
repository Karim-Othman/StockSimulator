namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OwnedProducts", "OwnedProductName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OwnedProducts", "OwnedProductName");
        }
    }
}
