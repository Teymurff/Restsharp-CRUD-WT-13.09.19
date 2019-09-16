namespace CommentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialidmatter : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Posts", new[] { "UserId" });
            CreateIndex("dbo.Posts", "userId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "userId" });
            CreateIndex("dbo.Posts", "UserId");
        }
    }
}
