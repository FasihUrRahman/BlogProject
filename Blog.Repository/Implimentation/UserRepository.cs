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

        public void AddEditRole(UserRole userRole)
        {
            _db.UsersRole.Update(userRole);
            _db.SaveChanges();
        }

        public void DeleteRole(int id)
        {
            UserRole userRoleId = _db.UsersRole.Where(x => x.Id.Equals(id)).FirstOrDefault();
            _db.Remove(userRoleId);
            _db.SaveChanges();
            
        }

        public UserRole GetRole(int id)
        {
            return _db.UsersRole.Where(x=> x.Id == id).FirstOrDefault();
        }

        public List<UserRole> GetRoles()
        {
            return _db.UsersRole.ToList();
        }
    }
}
