using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal interface IregisterPresenter
    {
        public Task Register(string name, string pass);
    }
}
