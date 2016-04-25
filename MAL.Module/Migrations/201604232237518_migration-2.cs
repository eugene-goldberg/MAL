namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceAccounts", "Service_ServiceID", "dbo.Services");
            DropForeignKey("dbo.ServiceAccounts", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.ToolAccounts", "Tool_ID", "dbo.Tools");
            DropForeignKey("dbo.ToolAccounts", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.ServiceAccounts", new[] { "Service_ServiceID" });
            DropIndex("dbo.ServiceAccounts", new[] { "Account_ID" });
            DropIndex("dbo.ToolAccounts", new[] { "Tool_ID" });
            DropIndex("dbo.ToolAccounts", new[] { "Account_ID" });
            AlterColumn("dbo.Accounts", "AccountTcvPotential", c => c.Double());
            AlterColumn("dbo.Accounts", "AccountTcvAwarded", c => c.Double());
            AlterColumn("dbo.Accounts", "ContractStartDate", c => c.DateTime());
            AlterColumn("dbo.Accounts", "ContractExpiryDate", c => c.DateTime());
            DropTable("dbo.Services");
            DropTable("dbo.Tools");
            DropTable("dbo.ServiceAccounts");
            DropTable("dbo.ToolAccounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ToolAccounts",
                c => new
                    {
                        Tool_ID = c.Int(nullable: false),
                        Account_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tool_ID, t.Account_ID });
            
            CreateTable(
                "dbo.ServiceAccounts",
                c => new
                    {
                        Service_ServiceID = c.Int(nullable: false),
                        Account_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_ServiceID, t.Account_ID });
            
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
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            AlterColumn("dbo.Accounts", "ContractExpiryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Accounts", "ContractStartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Accounts", "AccountTcvAwarded", c => c.Double(nullable: false));
            AlterColumn("dbo.Accounts", "AccountTcvPotential", c => c.Double(nullable: false));
            CreateIndex("dbo.ToolAccounts", "Account_ID");
            CreateIndex("dbo.ToolAccounts", "Tool_ID");
            CreateIndex("dbo.ServiceAccounts", "Account_ID");
            CreateIndex("dbo.ServiceAccounts", "Service_ServiceID");
            AddForeignKey("dbo.ToolAccounts", "Account_ID", "dbo.Accounts", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ToolAccounts", "Tool_ID", "dbo.Tools", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ServiceAccounts", "Account_ID", "dbo.Accounts", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ServiceAccounts", "Service_ServiceID", "dbo.Services", "ServiceID", cascadeDelete: true);
        }
    }
}
