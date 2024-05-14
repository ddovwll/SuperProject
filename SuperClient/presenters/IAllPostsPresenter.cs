using SuperClient.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal interface IAllPostsPresenter
    {
        public Task<List<Post>> AllPosts();
        public Task CreateLike(int postId);
        public Task DeleteLike(int postId);
        public string resultAuth { get; set; }
    }
}
