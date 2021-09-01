﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo
{
    public class UserContextForTest : IUserContext
    {
        public string Id => Guid.NewGuid().ToString();

        public string Name => "admin";
    }
}
