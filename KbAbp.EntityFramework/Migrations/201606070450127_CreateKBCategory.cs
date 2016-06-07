namespace KbAbp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKBCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KBCategoryItems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Code = c.String(maxLength: 100),
                        KBCategoryID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KBCategories", t => t.KBCategoryID, cascadeDelete: true)
                .Index(t => t.KBCategoryID);
            
            CreateTable(
                "dbo.KBCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KBCategoryItems", "KBCategoryID", "dbo.KBCategories");
            DropIndex("dbo.KBCategoryItems", new[] { "KBCategoryID" });
            DropTable("dbo.KBCategories");
            DropTable("dbo.KBCategoryItems");
        }
    }
}
