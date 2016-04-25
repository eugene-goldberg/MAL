namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToolAccounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account_ID = c.Int(),
                        Tool_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .ForeignKey("dbo.Tools", t => t.Tool_ID)
                .Index(t => t.Account_ID)
                .Index(t => t.Tool_ID);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ToolID = c.Int(nullable: false),
                        ToolCategoryName = c.String(),
                        ToolInstanceName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToolAccounts", "Tool_ID", "dbo.Tools");
            DropForeignKey("dbo.ToolAccounts", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.ToolAccounts", new[] { "Tool_ID" });
            DropIndex("dbo.ToolAccounts", new[] { "Account_ID" });
            DropTable("dbo.Tools");
            DropTable("dbo.ToolAccounts");
        }
    }
}
