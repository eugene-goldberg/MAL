namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToolAccounts", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.ToolAccounts", "Tool_ID", "dbo.Tools");
            DropIndex("dbo.ToolAccounts", new[] { "Account_ID" });
            DropIndex("dbo.ToolAccounts", new[] { "Tool_ID" });
            AddColumn("dbo.Tools", "Account_ID", c => c.Int());
            CreateIndex("dbo.Tools", "Account_ID");
            AddForeignKey("dbo.Tools", "Account_ID", "dbo.Accounts", "ID");
            DropTable("dbo.ToolAccounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ToolAccounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account_ID = c.Int(),
                        Tool_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.Tools", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.Tools", new[] { "Account_ID" });
            DropColumn("dbo.Tools", "Account_ID");
            CreateIndex("dbo.ToolAccounts", "Tool_ID");
            CreateIndex("dbo.ToolAccounts", "Account_ID");
            AddForeignKey("dbo.ToolAccounts", "Tool_ID", "dbo.Tools", "ID");
            AddForeignKey("dbo.ToolAccounts", "Account_ID", "dbo.Accounts", "ID");
        }
    }
}
