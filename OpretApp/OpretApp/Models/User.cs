﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpretApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}