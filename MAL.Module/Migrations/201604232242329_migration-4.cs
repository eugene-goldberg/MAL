namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "CurrentContractYear", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "CurrentContractYear", c => c.Int(nullable: false));
        }
    }
}
