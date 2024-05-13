using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.models
{
    public class LikeHistory
    {
        public Dictionary<int, int> PostLikes { get; set; }

        public LikeHistory()
        {
            PostLikes = new Dictionary<int, int>();
        }
    }

}
