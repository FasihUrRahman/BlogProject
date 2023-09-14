using Blog.Models;
using Blog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        //Build User Controller For Getting User Values
        
        private readonly IUser _user; //Get Values From Repostory Libery
        public UserController(IUser user) //This Constructor will give all the methods to _user from IUser
        {
            _user = user;
        }
        [Admin]
        [HttpGet]
        public IActionResult Roles()
        {
            return View(_user.GetRoles());
        }
        [HttpGet]
        public IActionResult AddEditRole(int id=0)
        {
            return View(_user.GetRole(id));
        }
        [HttpPost]
        public IActionResult AddEditRole(UserRole userRole)
        {
            _user.AddEditRole(userRole);
            return RedirectToAction("Roles");
        }
        [HttpGet]
        public IActionResult DeleteRole(int id)
        {
            _user.DeleteRole(id);
            return RedirectToAction("Roles");
        }
    }
}
