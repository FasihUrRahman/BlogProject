using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public class IUserAccount
    {
        //string Register(User user);
        //void GetUserInfo();
        //To Get Token
        public User GetUserForLogin(string password, string email);
    }
}
