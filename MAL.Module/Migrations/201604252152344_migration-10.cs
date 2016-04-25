namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountChangeMeasures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account_ID = c.Int(),
                        ChangeMeasure_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .ForeignKey("dbo.ChangeMeasures", t => t.ChangeMeasure_ID)
                .Index(t => t.Account_ID)
                .Index(t => t.ChangeMeasure_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountChangeMeasures", "ChangeMeasure_ID", "dbo.ChangeMeasures");
            DropForeignKey("dbo.AccountChangeMeasures", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.AccountChangeMeasures", new[] { "ChangeMeasure_ID" });
            DropIndex("dbo.AccountChangeMeasures", new[] { "Account_ID" });
            DropTable("dbo.AccountChangeMeasures");
        }
    }
}
