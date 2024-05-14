namespace SuperClient.views
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            textBoxNickName = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegistration = new Button();
            labelNickname = new Label();
            labelPassword = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNickName
            // 
            textBoxNickName.Location = new Point(220, 91);
            textBoxNickName.Margin = new Padding(2);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(204, 27);
            textBoxNickName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(220, 145);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(204, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.White;
            buttonRegistration.Location = new Point(220, 205);
            buttonRegistration.Margin = new Padding(2);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(203, 38);
            buttonRegistration.TabIndex = 2;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // labelNickname
            // 
            labelNickname.AutoSize = true;
            labelNickname.Location = new Point(220, 69);
            labelNickname.Margin = new Padding(2, 0, 2, 0);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(139, 20);
            labelNickname.TabIndex = 3;
            labelNickname.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(220, 122);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(640, 360);
            Controls.Add(pictureBox1);
            Controls.Add(labelPassword);
            Controls.Add(labelNickname);
            Controls.Add(buttonRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxNickName);
            Margin = new Padding(2);
            Name = "register";
            Text = "register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNickName;
        private TextBox textBoxPassword;
        private Button buttonRegistration;
        private Label labelNickname;
        private Label labelPassword;
        private PictureBox pictureBox1;
    }
}