namespace KbAbp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KnowledgeCategoryAndKbCategoryItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KnowledgeCategory", "KbCategoryItemId", c => c.Long(nullable: false));
            CreateIndex("dbo.KnowledgeCategory", "KbCategoryItemId");
            AddForeignKey("dbo.KnowledgeCategory", "KbCategoryItemId", "dbo.KbCategoryItem", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KnowledgeCategory", "KbCategoryItemId", "dbo.KbCategoryItem");
            DropIndex("dbo.KnowledgeCategory", new[] { "KbCategoryItemId" });
            DropColumn("dbo.KnowledgeCategory", "KbCategoryItemId");
        }
    }
}
