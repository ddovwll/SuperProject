namespace SuperClient.views
{
    partial class Authorization
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
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            buttonAuthorization = new Button();
            buttonRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(240, 107);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(251, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(240, 169);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(251, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonAuthorization
            // 
            buttonAuthorization.BackColor = Color.White;
            buttonAuthorization.Location = new Point(240, 216);
            buttonAuthorization.Name = "buttonAuthorization";
            buttonAuthorization.Size = new Size(251, 42);
            buttonAuthorization.TabIndex = 2;
            buttonAuthorization.Text = "Вход";
            buttonAuthorization.UseVisualStyleBackColor = false;
            buttonAuthorization.Click += buttonAuthorization_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.White;
            buttonRegister.Location = new Point(240, 287);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(251, 42);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Регистрация";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 78);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 4;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(buttonAuthorization);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Name = "Authorization";
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Button buttonAuthorization;
        private Button buttonRegister;
        private Label label1;
        private Label label2;
    }
}