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
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(143, 103);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(143, 165);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonAuthorization
            // 
            buttonAuthorization.Location = new Point(421, 100);
            buttonAuthorization.Name = "buttonAuthorization";
            buttonAuthorization.Size = new Size(112, 34);
            buttonAuthorization.TabIndex = 2;
            buttonAuthorization.Text = "войти";
            buttonAuthorization.UseVisualStyleBackColor = true;
            buttonAuthorization.Click += buttonAuthorization_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(421, 162);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(112, 34);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "регистрация";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}