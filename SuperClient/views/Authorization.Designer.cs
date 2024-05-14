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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            buttonAuthorization = new Button();
            buttonRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(220, 159);
            textBoxName.Margin = new Padding(2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(202, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(220, 208);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(202, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonAuthorization
            // 
            buttonAuthorization.BackColor = Color.White;
            buttonAuthorization.Location = new Point(220, 246);
            buttonAuthorization.Margin = new Padding(2);
            buttonAuthorization.Name = "buttonAuthorization";
            buttonAuthorization.Size = new Size(201, 34);
            buttonAuthorization.TabIndex = 2;
            buttonAuthorization.Text = "Вход";
            buttonAuthorization.UseVisualStyleBackColor = false;
            buttonAuthorization.Click += buttonAuthorization_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.White;
            buttonRegister.Location = new Point(220, 303);
            buttonRegister.Margin = new Padding(2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(201, 34);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Регистрация";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 135);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 4;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 186);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(294, 41);
            label3.Name = "label3";
            label3.Size = new Size(147, 54);
            label3.TabIndex = 6;
            label3.Text = "Postics";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(482, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 162);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(640, 360);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(buttonAuthorization);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Authorization";
            Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}