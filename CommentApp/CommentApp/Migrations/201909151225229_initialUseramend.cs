namespace CommentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialUseramend : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "User_Id", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "User_Id" });
            RenameColumn(table: "dbo.Posts", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Posts", "UserId", c => c.Int(nullable: true));
            CreateIndex("dbo.Posts", "UserId");
            AddForeignKey("dbo.Posts", "UserId", "dbo.Users", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "UserId" });
            AlterColumn("dbo.Posts", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Posts", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Posts", "User_Id");
            AddForeignKey("dbo.Posts", "User_Id", "dbo.Users", "Id");
        }
    }
}
