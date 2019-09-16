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
    public partial class UsersForm : Form
    {
        private readonly CommentAppContext context;
         List<User> users = new List<User>();
        User selectedUser;
        public UsersForm()
        {
            InitializeComponent();
            context = new CommentAppContext();
            UsersJson();
        }

        public void UsersJson() {
           
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("users");
            IRestResponse response = client.Execute(request);
            users = JsonConvert.DeserializeObject<List<User>>(response.Content);

            foreach (User user in users)
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
         
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            FillGridView();
        }
        public void FillGridView()
        {
            dgvUsers.Rows.Clear();
            foreach (User item in users)
            {
                dgvUsers.Rows.Add(
                      item.Id,
                      item.Fullname,
                      item.Username,
                      item.Email,
                      item.Website);
            }
        }

        private void dgvUsers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedUserId = (int)dgvUsers.Rows[e.RowIndex].Cells[0].Value;
            selectedUser = context.Users.Find(selectedUserId);

            txtUserName.Text = selectedUser.Fullname;
            txtUserUsername.Text = selectedUser.Username;
            txtUserEmail.Text = selectedUser.Email;
            txtUserWebsite.Text = selectedUser.Website;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please Fill All Inputs");
                return;
            }
            selectedUser.Fullname = txtUserName.Text;
            selectedUser.Username = txtUserUsername.Text;
            selectedUser.Email = txtUserEmail.Text;
            selectedUser.Website = txtUserWebsite.Text;

            context.SaveChanges();
            ResetForm();
            FillGridView();

        }

        public void ResetForm()
        {
            txtUserName.Text = "";
            txtUserUsername.Text = "";
            txtUserEmail.Text = "";
            txtUserWebsite.Text = "";
        }

        public bool ValidateForm()
        {

            bool isValid = false;

            if (!string.IsNullOrEmpty(txtUserName.Text) &&
                !string.IsNullOrEmpty(txtUserUsername.Text) &&
                !string.IsNullOrEmpty(txtUserEmail.Text) &&
                !string.IsNullOrEmpty(txtUserWebsite.Text))


            {
                isValid = true;
            }

            return isValid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to delete selected item?", "Deleteit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                context.Users.Remove(selectedUser);
                context.SaveChanges();

                ResetForm();
                FillGridView();

                MessageBox.Show("Deletion is successful");
            }
        }
    }
}
