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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersform = new UsersForm();
            usersform.ShowDialog();
        }

        private void postsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostsForm postform = new PostsForm();
            postform.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommentsForm commentsform = new CommentsForm();
            commentsform.ShowDialog();
        }
    }
}
