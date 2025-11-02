namespace BookSManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        Author = c.String(nullable: false, maxLength: 200),
                        ISBN = c.String(nullable: false, maxLength: 100),
                        YearPublished = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ISBN);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Books", new[] { "ISBN" });
            DropTable("dbo.Books");
        }
    }
}
