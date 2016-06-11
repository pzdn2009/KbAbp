namespace KbAbp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Knowledge : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.KbCategoryItem", new[] { "KBCategoryID" });
            CreateTable(
                "dbo.KnowledgeCategory",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Knowledge",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        KnowledgeCategoryId = c.Long(nullable: false),
                        Name = c.String(maxLength: 100),
                        Detail = c.String(maxLength: 4000),
                        Sort = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Knowledge_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeCategory", t => t.KnowledgeCategoryId, cascadeDelete: true)
                .Index(t => t.KnowledgeCategoryId);
            
            CreateIndex("dbo.KbCategoryItem", "KbCategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Knowledge", "KnowledgeCategoryId", "dbo.KnowledgeCategory");
            DropIndex("dbo.Knowledge", new[] { "KnowledgeCategoryId" });
            DropIndex("dbo.KbCategoryItem", new[] { "KbCategoryId" });
            DropTable("dbo.Knowledge",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Knowledge_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.KnowledgeCategory");
            CreateIndex("dbo.KbCategoryItem", "KBCategoryID");
        }
    }
}
