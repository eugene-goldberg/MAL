namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration19 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Offerings",
                c => new
                    {
                        OfferingID = c.Int(nullable: false, identity: true),
                        OfferingName = c.String(),
                    })
                .PrimaryKey(t => t.OfferingID);
            
            CreateTable(
                "dbo.RegionAlias",
                c => new
                    {
                        RegionAliasID = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                        SourceSystem = c.String(),
                        SourceColumn = c.String(),
                        SourceValue = c.String(),
                    })
                .PrimaryKey(t => t.RegionAliasID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegionAlias");
            DropTable("dbo.Offerings");
        }
    }
}
