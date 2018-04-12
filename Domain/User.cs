﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nickname { get; set; }
        public DateTime RecentActivity { get; set; }
    }
}