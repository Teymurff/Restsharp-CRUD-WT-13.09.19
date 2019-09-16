namespace CommentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "User_Id", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "User_Id" });
            DropTable("dbo.Posts");
        }
    }
}
