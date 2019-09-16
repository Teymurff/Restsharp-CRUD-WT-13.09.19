using CommentApp.DataAccessLayer;
using CommentApp.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentApp
{
    public partial class CommentsForm : Form
    {
        private readonly CommentAppContext context;
        List<Comment> comments = new List<Comment>();
        public CommentsForm()
        {
            InitializeComponent();
            context = new CommentAppContext();
            CommentsJson();
        }

        public void CommentsJson() {

            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("comments");
            IRestResponse response = client.Execute(request);
            comments = JsonConvert.DeserializeObject<List<Comment>>(response.Content);

            foreach (Comment comment in comments)
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }


        }
    }
}
