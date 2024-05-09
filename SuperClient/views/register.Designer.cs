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
            SuspendLayout();
            // 
            // textBoxNickName
            // 
            textBoxNickName.Location = new Point(155, 91);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(150, 31);
            textBoxNickName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(155, 146);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(409, 111);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(112, 34);
            buttonRegistration.TabIndex = 2;
            buttonRegistration.Text = "зарегатьсч";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxNickName);
            Name = "register";
            Text = "register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNickName;
        private TextBox textBoxPassword;
        private Button buttonRegistration;
    }
}