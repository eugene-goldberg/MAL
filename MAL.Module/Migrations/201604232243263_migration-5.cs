namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "HasServiceLevelAgreements", c => c.Boolean());
            AlterColumn("dbo.Accounts", "HasContractualReportingRequirements", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "HasContractualReportingRequirements", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Accounts", "HasServiceLevelAgreements", c => c.Boolean(nullable: false));
        }
    }
}
