using Blog.Data;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository.Implimentation 
{
    public class UserAccountRepository : IUserAccount
    {
        private readonly BlogContext _db;
        public UserAccountRepository(BlogContext db)
        {
            _db = db;
        }
        public User GetUserForLogin(string email, string password)
        {
            return _db.Users.Where(x => x.EmailAddress.ToLower().Equals(email.ToLower()) && x.Password.Equals(password)).FirstOrDefault();

        }
    }
}
