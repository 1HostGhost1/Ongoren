namespace Ongoren.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "CompanyId", "dbo.Companies");
            DropIndex("dbo.People", new[] { "CompanyId" });
            AddColumn("dbo.MailLists", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MailLists", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "CompanyName", c => c.String());
            AddColumn("dbo.People", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "ImmigrationFree", c => c.String());
            DropColumn("dbo.People", "CompanyId");
            DropTable("dbo.Companies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "CompanyId", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "ImmigrationFree", c => c.Int(nullable: false));
            DropColumn("dbo.People", "ModifiedDate");
            DropColumn("dbo.People", "CreatedDate");
            DropColumn("dbo.People", "CompanyName");
            DropColumn("dbo.MailLists", "ModifiedDate");
            DropColumn("dbo.MailLists", "CreatedDate");
            CreateIndex("dbo.People", "CompanyId");
            AddForeignKey("dbo.People", "CompanyId", "dbo.Companies", "Id", cascadeDelete: true);
        }
    }
}
