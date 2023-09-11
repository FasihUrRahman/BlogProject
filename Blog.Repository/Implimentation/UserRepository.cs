using Blog.Data;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository.Implimentation
{
    public class UserRepository : IUser
    {
        private readonly BlogContext _db; //This will get Values From BlogContext and have all the DB Valuess
        public UserRepository(BlogContext db)
        {
            _db = db;
        }

        public List<UserRole> GetRoles()
        {
            return _db.UsersRole.ToList();
        }
    }
}
