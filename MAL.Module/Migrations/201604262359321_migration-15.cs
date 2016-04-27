namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            AddColumn("dbo.Accounts", "Service_ServiceID", c => c.Int());
            CreateIndex("dbo.Accounts", "Service_ServiceID");
            AddForeignKey("dbo.Accounts", "Service_ServiceID", "dbo.Services", "ServiceID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "Service_ServiceID", "dbo.Services");
            DropIndex("dbo.Accounts", new[] { "Service_ServiceID" });
            DropColumn("dbo.Accounts", "Service_ServiceID");
            DropTable("dbo.Services");
        }
    }
}
