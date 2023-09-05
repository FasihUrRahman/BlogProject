using Blog.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserAccount _account;
        
        public AccountController(IUserAccount account)
        {
            _account = account;
        }
        [HttpGet]
        //[Admin] if we only want to redirect to admin
        public IActionResult Login()
        {
            return View();
        }
        //These all are Actions
        [HttpPost]
        public IActionResult Login(IFormCollection data) 
        {
            //Get Data Form Users
            string email = data["EmailAddress"];
            string password = data["Password"];

            var dbUser = _account.GetUserForLogin(password, email);
            if(dbUser != null)
            {
                //Expire Session After 30 Days
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.UtcNow.AddDays(30);
                Response.Cookies.Append("user-access-token",dbUser.AccessToken,options);
                return Redirect("/Home/Index");
            }
            ViewBag.Error = "Fuck Of Bitch, This isn't You!";
            return View();
        }
    }
}
