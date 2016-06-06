namespace KbAbp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tasks", "Remark", c => c.String());
            AddColumn("dbo.Tasks", "ProjectID", c => c.Long());
            CreateIndex("dbo.Tasks", "ProjectID");
            AddForeignKey("dbo.Tasks", "ProjectID", "dbo.Projects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "ProjectID", "dbo.Projects");
            DropIndex("dbo.Tasks", new[] { "ProjectID" });
            DropColumn("dbo.Tasks", "ProjectID");
            DropColumn("dbo.Tasks", "Remark");
            DropTable("dbo.Projects");
        }
    }
}
