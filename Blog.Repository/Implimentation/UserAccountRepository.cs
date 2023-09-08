﻿using Blog.Data;
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

        public string Register(User user)
        {
            user.UserRoleId = 2;//this will setup role of user who will register
            user.IsConfirmed = false;//this will not allow user to login without permission of admin
            user.JoinedOn = DateTime.UtcNow.AddHours(5); //This will add date of today and hour of the user when they register
            user.AccessToken = Guid.NewGuid().ToString() + DateTime.UtcNow.Ticks; //Generate AccessToken Using Ticks: It will change date time in number

            _db.Users.Add(user); //This will add data in Database
            _db.SaveChanges(); //And Then Save Changes
            return user.AccessToken + user.JoinedOn.Ticks.ToString();
        }
    }
}
