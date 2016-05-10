namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration20 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tools");
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        INCIDENTNUMBER = c.String(),
                        SUBMITTER = c.String(),
                        REPORTEDDATE = c.DateTime(nullable: false),
                        LASTRESOLVEDDATE = c.DateTime(nullable: false),
                        OWNERGROUP = c.String(),
                        COMPANY = c.String(),
                        CATEGORIZATIONTIER1 = c.String(),
                        VATEGORIZATIONTIER2 = c.String(),
                        CATEGORIZATIONTIER3 = c.String(),
                        RESOLUTIONCATEGORY = c.String(),
                        RESOLUTIONCATEGORYTIER2 = c.String(),
                        RESOLUTIONCATEGORYTIER3 = c.String(),
                        REPORTEDSOURCE = c.String(),
                        DESCRIPTION = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.AccountAlias", "ToolInstanceName", c => c.String());
            AddColumn("dbo.AccountAlias", "ProcessArea", c => c.String());
            AddColumn("dbo.Tools", "ToolRegisterID", c => c.String());
            AlterColumn("dbo.Tools", "ToolID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Tools", "ToolID");
            DropColumn("dbo.Tools", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tools", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Tools");
            AlterColumn("dbo.Tools", "ToolID", c => c.Int(nullable: false));
            DropColumn("dbo.Tools", "ToolRegisterID");
            DropColumn("dbo.AccountAlias", "ProcessArea");
            DropColumn("dbo.AccountAlias", "ToolInstanceName");
            DropTable("dbo.Incidents");
            AddPrimaryKey("dbo.Tools", "ID");
        }
    }
}
