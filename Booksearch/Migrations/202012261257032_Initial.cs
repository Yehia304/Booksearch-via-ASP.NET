namespace Booksearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Bookid = c.Int(nullable: false, identity: true),
                        Bookname = c.String(nullable: false),
                        Availability = c.Boolean(nullable: false,defaultValue:true),
                        ReleaseDate = c.DateTime(nullable: false),
                        BookType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Bookid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
