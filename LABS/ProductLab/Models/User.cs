using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductLab.Models
{
    public class User
    {
        [Required(ErrorMessage = "Username is required!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password cannot be empty!")]
        [MinLength(8, ErrorMessage = "Your password is not strong. Minimum 8 characters required!")]
        public string Password { get; set; }
        public string[] Roles { get; internal set; }
    }
    public class UserOps
    {
        private readonly static List<User> _user = new List<User>();
        public List<User> GetAll()
        {
            if (_user.Count == 0)
            {
                _user.Add(new User() { Password = "nimda123", Username = "admin", Roles = new string[] { "admin" } });
                _user.Add(new User() { Password = "nimda1234", Username = "parikshitverma", Roles = new string[] { "Developer" } });
                _user.Add(new User() { Password = "nimda12345", Username = "customer", Roles = new string[] { "User" } });

            }
            return _user;
        }
        public User FindUser(string username)
        {
            GetAll();
            return _user.Find(x => x.Username == username);
        }
    }
}
