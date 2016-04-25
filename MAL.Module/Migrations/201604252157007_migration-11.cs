namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountChangeMeasures", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.AccountChangeMeasures", "ChangeMeasure_ID", "dbo.ChangeMeasures");
            DropIndex("dbo.AccountChangeMeasures", new[] { "Account_ID" });
            DropIndex("dbo.AccountChangeMeasures", new[] { "ChangeMeasure_ID" });
            AddColumn("dbo.ChangeMeasures", "Account_ID", c => c.Int());
            CreateIndex("dbo.ChangeMeasures", "Account_ID");
            AddForeignKey("dbo.ChangeMeasures", "Account_ID", "dbo.Accounts", "ID");
            DropTable("dbo.AccountChangeMeasures");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AccountChangeMeasures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account_ID = c.Int(),
                        ChangeMeasure_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.ChangeMeasures", "Account_ID", "dbo.Accounts");
            DropIndex("dbo.ChangeMeasures", new[] { "Account_ID" });
            DropColumn("dbo.ChangeMeasures", "Account_ID");
            CreateIndex("dbo.AccountChangeMeasures", "ChangeMeasure_ID");
            CreateIndex("dbo.AccountChangeMeasures", "Account_ID");
            AddForeignKey("dbo.AccountChangeMeasures", "ChangeMeasure_ID", "dbo.ChangeMeasures", "ID");
            AddForeignKey("dbo.AccountChangeMeasures", "Account_ID", "dbo.Accounts", "ID");
        }
    }
}
