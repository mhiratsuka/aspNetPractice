﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspNetPractice.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string Memo { get; set; }
    }
}