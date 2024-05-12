namespace SuperClient.views
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
            richTextBox = new RichTextBox();
            Menu = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 12);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(830, 131);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // Menu
            // 
            Menu.Location = new Point(748, 149);
            Menu.Name = "Menu";
            Menu.Size = new Size(94, 29);
            Menu.TabIndex = 1;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // AllPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 641);
            Controls.Add(Menu);
            Controls.Add(richTextBox);
            Name = "AllPosts";
            Text = "AllPosts";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
        private Button Menu;
    }
}