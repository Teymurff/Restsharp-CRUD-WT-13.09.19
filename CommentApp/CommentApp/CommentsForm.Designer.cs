namespace CommentApp
{
    partial class CommentsForm
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
            this.txtComName = new System.Windows.Forms.TextBox();
            this.txtComEmail = new System.Windows.Forms.TextBox();
            this.rtxComBody = new System.Windows.Forms.RichTextBox();
            this.cmbComPost = new System.Windows.Forms.ComboBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblComBody = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(12, 39);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(208, 20);
            this.txtComName.TabIndex = 0;
            // 
            // txtComEmail
            // 
            this.txtComEmail.Location = new System.Drawing.Point(12, 99);
            this.txtComEmail.Name = "txtComEmail";
            this.txtComEmail.Size = new System.Drawing.Size(208, 20);
            this.txtComEmail.TabIndex = 1;
            // 
            // rtxComBody
            // 
            this.rtxComBody.Location = new System.Drawing.Point(12, 155);
            this.rtxComBody.Name = "rtxComBody";
            this.rtxComBody.Size = new System.Drawing.Size(208, 147);
            this.rtxComBody.TabIndex = 2;
            this.rtxComBody.Text = "";
            // 
            // cmbComPost
            // 
            this.cmbComPost.FormattingEnabled = true;
            this.cmbComPost.Location = new System.Drawing.Point(12, 347);
            this.cmbComPost.Name = "cmbComPost";
            this.cmbComPost.Size = new System.Drawing.Size(208, 21);
            this.cmbComPost.TabIndex = 3;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(12, 9);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(35, 13);
            this.lblCom.TabIndex = 4;
            this.lblCom.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblComBody
            // 
            this.lblComBody.AutoSize = true;
            this.lblComBody.Location = new System.Drawing.Point(12, 139);
            this.lblComBody.Name = "lblComBody";
            this.lblComBody.Size = new System.Drawing.Size(31, 13);
            this.lblComBody.TabIndex = 6;
            this.lblComBody.Text = "Body";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(9, 319);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(28, 13);
            this.lblPost.TabIndex = 7;
            this.lblPost.Text = "Post";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AllowUserToResizeColumns = false;
            this.dgvComments.AllowUserToResizeRows = false;
            this.dgvComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ComName,
            this.ComEmail,
            this.ComBody,
            this.ComPost});
            this.dgvComments.Location = new System.Drawing.Point(245, 12);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.Size = new System.Drawing.Size(543, 426);
            this.dgvComments.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ComName
            // 
            this.ComName.HeaderText = "Name";
            this.ComName.Name = "ComName";
            this.ComName.ReadOnly = true;
            // 
            // ComEmail
            // 
            this.ComEmail.HeaderText = "Email";
            this.ComEmail.Name = "ComEmail";
            this.ComEmail.ReadOnly = true;
            // 
            // ComBody
            // 
            this.ComBody.HeaderText = "Body";
            this.ComBody.Name = "ComBody";
            this.ComBody.ReadOnly = true;
            // 
            // ComPost
            // 
            this.ComPost.HeaderText = "Post";
            this.ComPost.Name = "ComPost";
            this.ComPost.ReadOnly = true;
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblComBody);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.cmbComPost);
            this.Controls.Add(this.rtxComBody);
            this.Controls.Add(this.txtComEmail);
            this.Controls.Add(this.txtComName);
            this.Name = "CommentsForm";
            this.Text = "Comments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.TextBox txtComEmail;
        private System.Windows.Forms.RichTextBox rtxComBody;
        private System.Windows.Forms.ComboBox cmbComPost;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblComBody;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPost;
    }
}