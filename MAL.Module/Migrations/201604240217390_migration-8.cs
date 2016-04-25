namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChangeMeasures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.String(),
                        MeasureName = c.String(),
                        Value = c.Int(nullable: false),
                        Justification = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChangeMeasures");
        }
    }
}
