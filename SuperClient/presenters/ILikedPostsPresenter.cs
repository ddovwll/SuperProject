using SuperClient.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal interface ILikedPostsPresenter
    {
        public Task<List<Post>> LikedPosts();
        public Task DeleteLike(int postId);
        public string resultAuth { get; set; }
    }
}
