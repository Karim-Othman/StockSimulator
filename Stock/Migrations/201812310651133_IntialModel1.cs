namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OwnedProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Owner = c.String(),
                        OwnedProductCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OwnedProducts");
        }
    }
}
