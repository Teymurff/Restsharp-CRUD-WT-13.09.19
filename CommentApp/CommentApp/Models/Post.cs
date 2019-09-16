using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentApp.Models
{
    class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int userId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
