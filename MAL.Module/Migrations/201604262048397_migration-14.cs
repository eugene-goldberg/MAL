namespace MAL.Module.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountRolePersons",
                c => new
                    {
                        AccountRolePersonID = c.Int(nullable: false, identity: true),
                        AccountID = c.String(),
                        PersonID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountRolePersonID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MI = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        AccountRolePerson_AccountRolePersonID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.AccountRolePersons", t => t.AccountRolePerson_AccountRolePersonID)
                .Index(t => t.AccountRolePerson_AccountRolePersonID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleDescription = c.String(),
                        AccountRolePerson_AccountRolePersonID = c.Int(),
                    })
                .PrimaryKey(t => t.RoleID)
                .ForeignKey("dbo.AccountRolePersons", t => t.AccountRolePerson_AccountRolePersonID)
                .Index(t => t.AccountRolePerson_AccountRolePersonID);
            
            AddColumn("dbo.Accounts", "AccountRolePerson_AccountRolePersonID", c => c.Int());
            CreateIndex("dbo.Accounts", "AccountRolePerson_AccountRolePersonID");
            AddForeignKey("dbo.Accounts", "AccountRolePerson_AccountRolePersonID", "dbo.AccountRolePersons", "AccountRolePersonID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "AccountRolePerson_AccountRolePersonID", "dbo.AccountRolePersons");
            DropForeignKey("dbo.People", "AccountRolePerson_AccountRolePersonID", "dbo.AccountRolePersons");
            DropForeignKey("dbo.Accounts", "AccountRolePerson_AccountRolePersonID", "dbo.AccountRolePersons");
            DropIndex("dbo.Roles", new[] { "AccountRolePerson_AccountRolePersonID" });
            DropIndex("dbo.People", new[] { "AccountRolePerson_AccountRolePersonID" });
            DropIndex("dbo.Accounts", new[] { "AccountRolePerson_AccountRolePersonID" });
            DropColumn("dbo.Accounts", "AccountRolePerson_AccountRolePersonID");
            DropTable("dbo.Roles");
            DropTable("dbo.People");
            DropTable("dbo.AccountRolePersons");
        }
    }
}
