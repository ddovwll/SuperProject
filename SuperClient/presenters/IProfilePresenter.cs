using SuperClient.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal interface IProfilePresenter
    {
        public Task CreatePost(string header, string text, int userId);

        public Task<List<Post>> UserPosts(string nickname);

        public Task DeletePost(int id);
        public Task UpdatePost(int id, string header, string text);

        public string resultAuth { get; set; }
    }
}
