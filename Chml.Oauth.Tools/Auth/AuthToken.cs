﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Auth
{
    public class AuthToken
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
    }
}
