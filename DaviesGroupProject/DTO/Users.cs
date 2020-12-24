using System;
using System.Collections.Generic;
using System.Text;

namespace DaviesGroupProject.DTO
{
    public class Users
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Users LinkedinUser()
        {
            Email = "test.andrewau@gmail.com";
            Password = "Password1!";
            return this;
        }
    }
}
