using CommentApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentApp.DataAccessLayer
{
    class CommentAppContext : DbContext
    {
        public CommentAppContext() : base("forappdatabase")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet <Post> Posts { get; set; }
        public DbSet <Comment> Comments { get; set; }
    }
}
