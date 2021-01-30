namespace Ongoren.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MailContent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MailContents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MailContents");
        }
    }
}
