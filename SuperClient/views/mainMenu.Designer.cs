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
        buttonAllPosts = new Button();
        buttonLikedPosts = new Button();
        buttonProfile = new Button();
        SuspendLayout();
        // 
        // buttonAllPosts
        // 
        buttonAllPosts.Location = new Point(190, 47);
        buttonAllPosts.Margin = new Padding(2, 2, 2, 2);
        buttonAllPosts.Name = "buttonAllPosts";
        buttonAllPosts.Size = new Size(230, 57);
        buttonAllPosts.TabIndex = 0;
        buttonAllPosts.Text = "Посмотреть все посты";
        buttonAllPosts.UseVisualStyleBackColor = true;
        buttonAllPosts.Click += buttonAllPosts_Click;
        // 
        // buttonLikedPosts
        // 
        buttonLikedPosts.Location = new Point(190, 121);
        buttonLikedPosts.Margin = new Padding(2, 2, 2, 2);
        buttonLikedPosts.Name = "buttonLikedPosts";
        buttonLikedPosts.Size = new Size(230, 57);
        buttonLikedPosts.TabIndex = 1;
        buttonLikedPosts.Text = "Посмотреть лайкнутые посты";
        buttonLikedPosts.UseVisualStyleBackColor = true;
        buttonLikedPosts.Click += buttonLikedPosts_Click;
        // 
        // buttonProfile
        // 
        buttonProfile.Location = new Point(190, 200);
        buttonProfile.Margin = new Padding(2, 2, 2, 2);
        buttonProfile.Name = "buttonProfile";
        buttonProfile.Size = new Size(230, 57);
        buttonProfile.TabIndex = 2;
        buttonProfile.Text = "Посмотреть профиль";
        buttonProfile.UseVisualStyleBackColor = true;
        buttonProfile.Click += buttonProfile_Click;
        // 
        // mainMenu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(640, 360);
        Controls.Add(buttonProfile);
        Controls.Add(buttonLikedPosts);
        Controls.Add(buttonAllPosts);
        Margin = new Padding(2, 2, 2, 2);
        Name = "mainMenu";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button buttonAllPosts;
    private Button buttonLikedPosts;
    private Button buttonProfile;
}