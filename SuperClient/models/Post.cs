using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.models
{
    internal class Post
    {
        public int id { get; set; }
        public string header { get; set; }
        public string text { get; set; }
        public int likesCount { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public bool IsLiked { get; set; }
    }
}
