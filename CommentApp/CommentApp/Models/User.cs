using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentApp.Models
{
    class User
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public List<Post> Posts { get; set; }
    }
}
