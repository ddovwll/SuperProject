﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.models
{
    internal class headers
    {
        public int userId { get; set; }
        public string sessionId { get; set;}
        public string NickName { get; set; }

        public static headers header = new headers();
    }
}
