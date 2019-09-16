namespace CommentApp
{
    partial class PostsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPostTitle = new System.Windows.Forms.TextBox();
            this.rtbPostBody = new System.Windows.Forms.RichTextBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPostTitle
            // 
            this.txtPostTitle.Location = new System.Drawing.Point(12, 44);
            this.txtPostTitle.Name = "txtPostTitle";
            this.txtPostTitle.Size = new System.Drawing.Size(201, 20);
            this.txtPostTitle.TabIndex = 0;
            // 
            // rtbPostBody
            // 
            this.rtbPostBody.Location = new System.Drawing.Point(12, 122);
            this.rtbPostBody.Name = "rtbPostBody";
            this.rtbPostBody.Size = new System.Drawing.Size(201, 146);
            this.rtbPostBody.TabIndex = 1;
            this.rtbPostBody.Text = "";
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(15, 322);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(198, 21);
            this.cmbAuthor.TabIndex = 2;
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.AllowUserToResizeColumns = false;
            this.dgvPosts.AllowUserToResizeRows = false;
            this.dgvPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PostTitle,
            this.PostBody,
            this.PostAuthor});
            this.dgvPosts.Location = new System.Drawing.Point(236, 12);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.Size = new System.Drawing.Size(522, 426);
            this.dgvPosts.TabIndex = 3;
            this.dgvPosts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPosts_RowHeaderMouseDoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(12, 90);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 5;
            this.lblBody.Text = "Body";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 287);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // PostTitle
            // 
            this.PostTitle.HeaderText = "Title";
            this.PostTitle.Name = "PostTitle";
            this.PostTitle.ReadOnly = true;
            // 
            // PostBody
            // 
            this.PostBody.HeaderText = "Body";
            this.PostBody.Name = "PostBody";
            this.PostBody.ReadOnly = true;
            // 
            // PostAuthor
            // 
            this.PostAuthor.HeaderText = "Author";
            this.PostAuthor.Name = "PostAuthor";
            this.PostAuthor.ReadOnly = true;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.rtbPostBody);
            this.Controls.Add(this.txtPostTitle);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPostTitle;
        private System.Windows.Forms.RichTextBox rtbPostBody;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostAuthor;
    }
}