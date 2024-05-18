using SuperClient.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.views
{
    internal interface ILikedPostsView
    {
        public void DisplayPosts(List<Post> posts);
        public void LoadPosts();
        public Image ResizeImage(Image imgToResize, int width, int height);
    }
}
