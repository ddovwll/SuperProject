namespace SuperClient.views
{
    partial class LikedPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LikedPosts));
            Menu = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            flowLayoutPanelLickedPost = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Location = new Point(654, 450);
            Menu.Margin = new Padding(3, 2, 3, 2);
            Menu.Name = "Menu";
            Menu.Size = new Size(82, 22);
            Menu.TabIndex = 0;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(610, 444);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(685, 96);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(27, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "лайк";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelLickedPost
            // 
            flowLayoutPanelLickedPost.Location = new Point(12, 12);
            flowLayoutPanelLickedPost.Name = "flowLayoutPanelLickedPost";
            flowLayoutPanelLickedPost.Size = new Size(722, 427);
            flowLayoutPanelLickedPost.TabIndex = 15;
            // 
            // LikedPosts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(746, 481);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(Menu);
            Controls.Add(flowLayoutPanelLickedPost);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LikedPosts";
            Text = "LikedPosts";
            Load += LikedPosts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Menu;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanelLickedPost;
    }
}