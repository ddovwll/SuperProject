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
            Menu = new Button();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Location = new Point(694, 409);
            Menu.Name = "Menu";
            Menu.Size = new Size(94, 29);
            Menu.TabIndex = 0;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // LikedPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Menu);
            Name = "LikedPosts";
            Text = "LikedPosts";
            ResumeLayout(false);
        }

        #endregion

        private Button Menu;
    }
}