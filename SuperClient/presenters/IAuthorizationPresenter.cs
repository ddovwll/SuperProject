﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal interface IAuthorizationPresenter
    {
        public Task Authorization(string nickname, string password);
        public string resultAuth { get; set; }
    }
}
