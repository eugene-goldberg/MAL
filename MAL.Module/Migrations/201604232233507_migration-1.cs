namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.String(),
                        AccountName = c.String(),
                        ParentAccountId = c.String(),
                        ParentAccountName = c.String(),
                        MasterAccountId = c.String(),
                        MasterAccountName = c.String(),
                        Customer = c.String(),
                        SnowDomainName = c.String(),
                        CapCode = c.String(),
                        AccountTcvPotential = c.Double(nullable: false),
                        AccountTcvAwarded = c.Double(nullable: false),
                        ContractStartDate = c.DateTime(nullable: false),
                        ContractExpiryDate = c.DateTime(nullable: false),
                        ContractType = c.String(),
                        ContractTermInMonth = c.Double(nullable: false),
                        CurrentContractYear = c.Int(nullable: false),
                        ContractBaseOptions = c.String(),
                        SfdcIdNumber = c.String(),
                        HasServiceLevelAgreements = c.Boolean(nullable: false),
                        HasContractualReportingRequirements = c.Boolean(nullable: false),
                        AccountFinancialsParentFamily = c.String(),
                        PaymentTerms = c.String(),
                        SecurityRestrictions = c.String(),
                        WorkScope = c.String(),
                        AccountStatus = c.String(),
                        Comments = c.String(),
                        AccountIndustry = c.String(),
                        AccountCountry = c.String(),
                        AccountRegion = c.String(),
                        PrimaryDeliveryRegion = c.String(),
                        OedRegion = c.String(),
                        LeadOffering = c.String(),
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
                "dbo.ServiceAccounts",
                c => new
                    {
                        Service_ServiceID = c.Int(nullable: false),
                        Account_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_ServiceID, t.Account_ID })
                .ForeignKey("dbo.Services", t => t.Service_ServiceID, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_ID, cascadeDelete: true)
                .Index(t => t.Service_ServiceID)
                .Index(t => t.Account_ID);
            
            CreateTable(
                "dbo.ToolAccounts",
                c => new
                    {
                        Tool_ID = c.Int(nullable: false),
                        Account_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tool_ID, t.Account_ID })
                .ForeignKey("dbo.Tools", t => t.Tool_ID, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_ID, cascadeDelete: true)
                .Index(t => t.Tool_ID)
                .Index(t => t.Account_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToolAccounts", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.ToolAccounts", "Tool_ID", "dbo.Tools");
            DropForeignKey("dbo.ServiceAccounts", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.ServiceAccounts", "Service_ServiceID", "dbo.Services");
            DropIndex("dbo.ToolAccounts", new[] { "Account_ID" });
            DropIndex("dbo.ToolAccounts", new[] { "Tool_ID" });
            DropIndex("dbo.ServiceAccounts", new[] { "Account_ID" });
            DropIndex("dbo.ServiceAccounts", new[] { "Service_ServiceID" });
            DropTable("dbo.ToolAccounts");
            DropTable("dbo.ServiceAccounts");
            DropTable("dbo.Tools");
            DropTable("dbo.Services");
            DropTable("dbo.Accounts");
        }
    }
}
