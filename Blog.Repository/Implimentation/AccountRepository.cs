using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository.Implimentation
{
    public class AccountRepository : IAccount
    {
        string IAccount.Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
