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
            Menu = new Button();
            label2 = new Label();
            flowLayoutPanelPosts = new FlowLayoutPanel();
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
            // AllPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 641);
            Controls.Add(flowLayoutPanelPosts);
            Controls.Add(label2);
            Controls.Add(Menu);
            Name = "AllPosts";
            Text = "AllPosts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Menu;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelPosts;
    }
}