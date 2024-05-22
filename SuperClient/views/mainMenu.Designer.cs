namespace SuperClient;

partial class mainMenu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
        buttonAllPosts = new Button();
        buttonLikedPosts = new Button();
        buttonProfile = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // buttonAllPosts
        // 
        buttonAllPosts.Location = new Point(206, 110);
        buttonAllPosts.Margin = new Padding(2);
        buttonAllPosts.Name = "buttonAllPosts";
        buttonAllPosts.Size = new Size(230, 57);
        buttonAllPosts.TabIndex = 0;
        buttonAllPosts.Text = "Посмотреть все посты";
        buttonAllPosts.UseVisualStyleBackColor = true;
        buttonAllPosts.Click += buttonAllPosts_Click;
        // 
        // buttonLikedPosts
        // 
        buttonLikedPosts.Location = new Point(206, 184);
        buttonLikedPosts.Margin = new Padding(2);
        buttonLikedPosts.Name = "buttonLikedPosts";
        buttonLikedPosts.Size = new Size(230, 57);
        buttonLikedPosts.TabIndex = 1;
        buttonLikedPosts.Text = "Посмотреть лайкнутые посты";
        buttonLikedPosts.UseVisualStyleBackColor = true;
        buttonLikedPosts.Click += buttonLikedPosts_Click;
        // 
        // buttonProfile
        // 
        buttonProfile.Location = new Point(206, 263);
        buttonProfile.Margin = new Padding(2);
        buttonProfile.Name = "buttonProfile";
        buttonProfile.Size = new Size(230, 57);
        buttonProfile.TabIndex = 2;
        buttonProfile.Text = "Посмотреть профиль";
        buttonProfile.UseVisualStyleBackColor = true;
        buttonProfile.Click += buttonProfile_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(206, 37);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(67, 75);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 10;
        pictureBox1.TabStop = false;
        // 
        // mainMenu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.CornflowerBlue;
        ClientSize = new Size(640, 360);
        Controls.Add(pictureBox1);
        Controls.Add(buttonProfile);
        Controls.Add(buttonLikedPosts);
        Controls.Add(buttonAllPosts);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        Name = "mainMenu";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        this.Closed += OnFormClosed;
    }

    #endregion

    private Button buttonAllPosts;
    private Button buttonLikedPosts;
    private Button buttonProfile;
    private PictureBox pictureBox1;
}