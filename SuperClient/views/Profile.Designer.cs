﻿namespace SuperClient
{
    partial class Profile
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
            label1 = new Label();
            NameNewPost = new TextBox();
            TextNewPost = new RichTextBox();
            CreatePost = new Button();
            Menu = new Button();
            label2 = new Label();
            flowLayoutPanelUserPosts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 46);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // NameNewPost
            // 
            NameNewPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameNewPost.Location = new Point(12, 78);
            NameNewPost.Name = "NameNewPost";
            NameNewPost.Size = new Size(125, 34);
            NameNewPost.TabIndex = 1;
            // 
            // TextNewPost
            // 
            TextNewPost.Location = new Point(12, 118);
            TextNewPost.Name = "TextNewPost";
            TextNewPost.Size = new Size(829, 120);
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
            CreatePost.Click += CreatePost_Click;
            // 
            // Menu
            // 
            Menu.Location = new Point(730, 600);
            Menu.Name = "Menu";
            Menu.Size = new Size(111, 29);
            Menu.TabIndex = 4;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 295);
            label2.Name = "label2";
            label2.Size = new Size(165, 38);
            label2.TabIndex = 6;
            label2.Text = "Мои посты";
            // 
            // flowLayoutPanelUserPosts
            // 
            flowLayoutPanelUserPosts.AutoScroll = true;
            flowLayoutPanelUserPosts.Location = new Point(12, 336);
            flowLayoutPanelUserPosts.Name = "flowLayoutPanelUserPosts";
            flowLayoutPanelUserPosts.Size = new Size(829, 258);
            flowLayoutPanelUserPosts.TabIndex = 7;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 641);
            Controls.Add(flowLayoutPanelUserPosts);
            Controls.Add(label2);
            Controls.Add(Menu);
            Controls.Add(CreatePost);
            Controls.Add(TextNewPost);
            Controls.Add(NameNewPost);
            Controls.Add(label1);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameNewPost;
        private RichTextBox TextNewPost;
        private Button CreatePost;
        private Button Menu;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelUserPosts;
    }
}