using SuperClient.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.views
{
    internal interface IProfileView
    {
        public void LoadPosts();
        public void DisplayPosts(List<Post> posts);
        public Image ResizeImage(Image imgToResize, int width, int height);
    }
}
