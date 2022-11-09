﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HikingBlog
{
    public class User
    {
        public string Name;
        public string Email;
        public int HikingLevel;

        public User(string name, string email, int hikingLevel)
        {
            Name = name;
            if (!email.Contains("@")) throw new Exception("Invalid email");
            Email = email;
            if(hikingLevel == 1 || hikingLevel == 2 || hikingLevel == 3)
            {
                HikingLevel = hikingLevel;
            }
            else
            {
                throw new Exception("Invalid hiking level");
            }
        }
    }
}
