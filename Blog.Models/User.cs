using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string IsConfirmed { get; set; }
        public string AccessToken { get; set; }
        public virtual UserRole Role { get; set; }
        public int UserRoleId { get; set; } 

    }
}
