﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal interface IAllPostsPresenter
    {
        public Task AllPosts();

        public string resultAuth { get; set; }
    }
}