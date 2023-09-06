using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public interface IUserAccount
    {
        //string Register(User user);
        //void GetUserInfo();
        //To Get Token
        public User GetUserForLogin(string email, string password);
    }
}
