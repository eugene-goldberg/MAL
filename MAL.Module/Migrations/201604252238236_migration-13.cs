namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration13 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tools", newName: "AccountTools");
            DropColumn("dbo.AccountTools", "ToolID");
            DropColumn("dbo.AccountTools", "ToolCategoryName");
            DropColumn("dbo.AccountTools", "ToolInstanceName");
            DropColumn("dbo.AccountTools", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountTools", "Description", c => c.String());
            AddColumn("dbo.AccountTools", "ToolInstanceName", c => c.String());
            AddColumn("dbo.AccountTools", "ToolCategoryName", c => c.String());
            AddColumn("dbo.AccountTools", "ToolID", c => c.Int(nullable: false));
            RenameTable(name: "dbo.AccountTools", newName: "Tools");
        }
    }
}
