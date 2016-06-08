namespace KbAbp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 去除重复的名称 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.KBCategoryItems", newName: "KBCategoryItem");
            RenameTable(name: "dbo.KBCategories", newName: "KbCategory");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.KbCategory", newName: "KBCategories");
            RenameTable(name: "dbo.KBCategoryItem", newName: "KBCategoryItems");
        }
    }
}
