using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public interface IUser
    {
        //To Get Roles From DB
        List<UserRole> GetRoles();
        UserRole GetRole(int id);
        void AddEditRole(UserRole userRole);
        void DeleteRole(int id);
    }
}
