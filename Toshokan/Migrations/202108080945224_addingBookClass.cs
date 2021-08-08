namespace Toshokan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingBookClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.String(nullable: false, maxLength: 128),
                        Image = c.String(),
                        Title = c.String(),
                        Author = c.String(),
                        Published = c.DateTime(nullable: false),
                        Publisher = c.String(),
                        PageCount = c.Int(nullable: false),
                        Language = c.String(),
                    })
                .PrimaryKey(t => t.ISBN);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
