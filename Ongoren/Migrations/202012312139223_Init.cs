namespace Ongoren.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.MailLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MailTo = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WpOrRp = c.String(maxLength: 5),
                        ApplicationNo = c.String(maxLength: 10),
                        YKN = c.String(maxLength: 15),
                        Name = c.String(),
                        Surname = c.String(),
                        CompanyId = c.Int(nullable: false),
                        ApplicationDate = c.DateTime(nullable: false),
                        IssueDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        ImmigrationTrackingEndDate = c.DateTime(nullable: false),
                        MailSendDate = c.DateTime(nullable: false),
                        ImmigrationFree = c.Int(nullable: false),
                        MailStatus = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "CompanyId", "dbo.Companies");
            DropIndex("dbo.People", new[] { "CompanyId" });
            DropTable("dbo.People");
            DropTable("dbo.MailLists");
            DropTable("dbo.Companies");
        }
    }
}
