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

        public string resultAuth { get; set; }
    }
}
