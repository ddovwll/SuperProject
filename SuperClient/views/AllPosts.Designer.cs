﻿namespace SuperClient.views
{
    partial class AllPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPosts));
            Menu = new Button();
            label2 = new Label();
            flowLayoutPanelPosts = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Location = new Point(748, 600);
            Menu.Name = "Menu";
            Menu.Size = new Size(94, 29);
            Menu.TabIndex = 1;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 38);
            label2.TabIndex = 7;
            label2.Text = "Лента";
            // 
            // flowLayoutPanelPosts
            // 
            flowLayoutPanelPosts.AutoScroll = true;
            flowLayoutPanelPosts.Location = new Point(12, 50);
            flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            flowLayoutPanelPosts.Size = new Size(829, 544);
            flowLayoutPanelPosts.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // AllPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(853, 641);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanelPosts);
            Controls.Add(label2);
            Controls.Add(Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AllPosts";
            Text = "AllPosts";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Menu;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelPosts;
        private PictureBox pictureBox1;
    }
}