namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountAlias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountAlilasID = c.Int(nullable: false),
                        AliasName = c.String(),
                        SourceSystem = c.String(),
                        SourceColumn = c.String(),
                        SourceValue = c.String(),
                        Account_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .Index(t => t.Account_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountAlias", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.AccountAlias", new[] { "Account_ID" });
            DropTable("dbo.AccountAlias");
        }
    }
}
