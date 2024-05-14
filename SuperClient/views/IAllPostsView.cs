using SuperClient.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.views
{
    internal interface IAllPostsView
    {
        public void DisplayPosts(List<Post> posts);
        public void LoadPosts();
        public void UpdateLikeButton(Button btnLike, Post post);
        public Image ResizeImage(Image imgToResize, int width, int height);
    }
}
