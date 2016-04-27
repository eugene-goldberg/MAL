namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountPrograms",
                c => new
                    {
                        AccountProgramID = c.Int(nullable: false, identity: true),
                        ProgramPhase = c.String(),
                        AccountID = c.String(),
                        ProgramGoLiveDate = c.DateTime(nullable: false),
                        ProgramStabilizationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountProgramID);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramID = c.Int(nullable: false, identity: true),
                        ProgramName = c.String(),
                        AccountProgram_AccountProgramID = c.Int(),
                    })
                .PrimaryKey(t => t.ProgramID)
                .ForeignKey("dbo.AccountPrograms", t => t.AccountProgram_AccountProgramID)
                .Index(t => t.AccountProgram_AccountProgramID);
            
            AddColumn("dbo.Accounts", "AccountProgram_AccountProgramID", c => c.Int());
            CreateIndex("dbo.Accounts", "AccountProgram_AccountProgramID");
            AddForeignKey("dbo.Accounts", "AccountProgram_AccountProgramID", "dbo.AccountPrograms", "AccountProgramID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Programs", "AccountProgram_AccountProgramID", "dbo.AccountPrograms");
            DropForeignKey("dbo.Accounts", "AccountProgram_AccountProgramID", "dbo.AccountPrograms");
            DropIndex("dbo.Programs", new[] { "AccountProgram_AccountProgramID" });
            DropIndex("dbo.Accounts", new[] { "AccountProgram_AccountProgramID" });
            DropColumn("dbo.Accounts", "AccountProgram_AccountProgramID");
            DropTable("dbo.Programs");
            DropTable("dbo.AccountPrograms");
        }
    }
}
