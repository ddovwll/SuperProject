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
            textBoxNickName = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegistration = new Button();
            labelNickname = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // textBoxNickName
            // 
            textBoxNickName.Location = new Point(267, 114);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(254, 31);
            textBoxNickName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(267, 181);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(254, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.White;
            buttonRegistration.Location = new Point(267, 256);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(254, 47);
            buttonRegistration.TabIndex = 2;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // labelNickname
            // 
            labelNickname.AutoSize = true;
            labelNickname.Location = new Point(267, 86);
            labelNickname.Name = "labelNickname";
            labelNickname.Size = new Size(163, 25);
            labelNickname.TabIndex = 3;
            labelNickname.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(267, 153);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(74, 25);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPassword);
            Controls.Add(labelNickname);
            Controls.Add(buttonRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxNickName);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNickName;
        private TextBox textBoxPassword;
        private Button buttonRegistration;
        private Label labelNickname;
        private Label labelPassword;
    }
}