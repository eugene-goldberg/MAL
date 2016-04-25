namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "ContractTermInMonth", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "ContractTermInMonth", c => c.Double(nullable: false));
        }
    }
}
