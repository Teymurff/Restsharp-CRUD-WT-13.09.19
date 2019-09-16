namespace CommentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablescorrected : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            RenameColumn(table: "dbo.Comments", name: "Post_Id", newName: "postId");
            AlterColumn("dbo.Comments", "postId", c => c.Int(nullable: true));
            CreateIndex("dbo.Comments", "postId");
            AddForeignKey("dbo.Comments", "postId", "dbo.Posts", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "postId", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "postId" });
            AlterColumn("dbo.Comments", "postId", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "postId", newName: "Post_Id");
            CreateIndex("dbo.Comments", "Post_Id");
            AddForeignKey("dbo.Comments", "Post_Id", "dbo.Posts", "Id");
        }
    }
}
