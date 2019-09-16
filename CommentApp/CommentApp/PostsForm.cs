using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommentApp.DataAccessLayer;
using CommentApp.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CommentApp
{
    public partial class PostsForm : Form
    {
        private readonly CommentAppContext context;
        List<Post> posts = new List<Post>();
        Post selectedPost;

        public PostsForm()
        {
            InitializeComponent();
            context = new CommentAppContext();
            PostsJson();
        
        }

        public void PostsJson()
        {

            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts");
            IRestResponse response = client.Execute(request);
            posts = JsonConvert.DeserializeObject<List<Post>>(response.Content);

            foreach (Post post in posts)
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }

        }

        public void ResetForm()
        {
            txtPostTitle.Text = "";
            rtbPostBody.Text = "";
            cmbAuthor.SelectedIndex = -1;

        }

        public void FillGridView()
        {

            string[] usersName = context.Users.Select(c => c.Fullname).OrderBy(c => c).ToArray();

            cmbAuthor.Items.AddRange(usersName);
            dgvPosts.Rows.Clear();
            List<Post> allPosts = context.Posts.ToList();
            foreach (Post item in allPosts)
            {

                string userOfName = "";
                if (item.User != null)
                {
                    userOfName = item.User.Fullname;
                }
                dgvPosts.Rows.Add(item.Id,
                    item.Title,
                    item.Body,
                   item.userId);
            }
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            FillGridView();
        }


        public bool ValidateForm()
        {

            bool isValid = false;

            if (!string.IsNullOrEmpty(txtPostTitle.Text) &&
                !string.IsNullOrEmpty(rtbPostBody.Text) &&
                (cmbAuthor.SelectedIndex) >= 0)
            {
                isValid = true;
            }

            return isValid;
        }

        private void dgvPosts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
      
            int selectedPostsId = (int)dgvPosts.Rows[e.RowIndex].Cells[0].Value;
            selectedPost = context.Posts.Find(selectedPostsId);

            txtPostTitle.Text = selectedPost.Title;
            rtbPostBody.Text = selectedPost.Body;

            if (selectedPost.User != null)
            {
                cmbAuthor.SelectedItem = selectedPost.User.Fullname;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please Fill All Inputs");
                return;
            }

            selectedPost.Title = txtPostTitle.Text;
            selectedPost.Body = rtbPostBody.Text;

            User User = context.Users.FirstOrDefault(c => c.Fullname == (string)cmbAuthor.SelectedItem);
            selectedPost.userId = User.Id;

            context.SaveChanges();
            ResetForm();
            FillGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to delete selected item?", "Deleteit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                context.Posts.Remove(selectedPost);
                context.SaveChanges();

                ResetForm();
                FillGridView();

                MessageBox.Show("Deletion is successful");
            }
        }
    }
}
