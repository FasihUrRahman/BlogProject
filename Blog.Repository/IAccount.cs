using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public interface IAccount
    {
        string Register(User user);
        //void GetUserInfo();
    }
}
