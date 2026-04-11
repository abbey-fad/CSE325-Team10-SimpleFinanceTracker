using System.Collections.Generic;
using System.Linq;
using CSE325_Team10_SimpleFinanceTracker.Models;

namespace CSE325_Team10_SimpleFinanceTracker.Services
{
    public class UserService
    {
        private List<User> Users = new List<User>();

        public User? CurrentUser { get; private set; } // Track logged-in user

        public bool Register(User newUser)
        {
            if (Users.Any(u => u.Email == newUser.Email))
                return false; // Email already exists
            Users.Add(newUser);
            return true;
        }

        public User? Login(string email, string password)
        {
            var user = Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
                CurrentUser = user; // set the logged-in user
            return user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        // Optional: for debugging to see registered users
        public List<User> GetAllUsers() => Users;
    }
}