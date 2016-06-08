namespace KbAbp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_KbQueue_Tag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KbQueue",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Url = c.String(maxLength: 1000),
                        Status = c.Byte(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        UsedCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tag");
            DropTable("dbo.KbQueue");
        }
    }
}
