namespace SuperClient
{
    partial class ProfileView
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
            NickName = new Label();
            NameNewPost = new TextBox();
            TextNewPost = new RichTextBox();
            CreatePost = new Button();
            SuspendLayout();
            // 
            // NickName
            // 
            NickName.AutoSize = true;
            NickName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NickName.Location = new Point(12, 9);
            NickName.Name = "NickName";
            NickName.Size = new Size(117, 46);
            NickName.TabIndex = 0;
            NickName.Text = "label1";
            // 
            // NameNewPost
            // 
            NameNewPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameNewPost.Location = new Point(12, 78);
            NameNewPost.Name = "NameNewPost";
            NameNewPost.Size = new Size(125, 34);
            NameNewPost.TabIndex = 1;
            // 
            // TextNewPost
            // 
            TextNewPost.Location = new Point(12, 118);
            TextNewPost.Name = "TextNewPost";
            TextNewPost.Size = new Size(776, 120);
            TextNewPost.TabIndex = 2;
            TextNewPost.Text = "";
            // 
            // CreatePost
            // 
            CreatePost.Location = new Point(12, 244);
            CreatePost.Name = "CreatePost";
            CreatePost.Size = new Size(190, 29);
            CreatePost.TabIndex = 3;
            CreatePost.Text = "Опубликовать";
            CreatePost.UseVisualStyleBackColor = true;
            // 
            // ProfileView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(CreatePost);
            Controls.Add(TextNewPost);
            Controls.Add(NameNewPost);
            Controls.Add(NickName);
            Name = "ProfileView";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NickName;
        private TextBox NameNewPost;
        private RichTextBox TextNewPost;
        private Button CreatePost;
    }
}