using SuperClient.views;

namespace SuperClient;

public partial class mainMenu : Form
{
    public mainMenu()
    {
        InitializeComponent();
    }

    private void buttonAllPosts_Click(object sender, EventArgs e)
    {
        AllPosts allPosts = new AllPosts();
        allPosts.Show();
        this.Hide();
    }

    private void buttonLikedPosts_Click(object sender, EventArgs e)
    {
        LikedPosts likedPosts = new LikedPosts();
        likedPosts.Show();
        this.Hide();
    }

    private void buttonProfile_Click(object sender, EventArgs e)
    {
        Profile profile = new Profile();
        profile.Show();
        this.Hide();
    }
}