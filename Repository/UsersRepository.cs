using OurTestApi.Interface;
using OurTestApi.Models;
using System;
using System.Collections.Generic;

namespace OurTestApi.Repository
{
    public class UsersRepository : IUser
    {
        public List<Users> GetAllUsers()
        {
            List<Users> users = new List<Users>()
            {
                new Users() { UserId = 1002, UserName = "John" },
                new Users() { UserId = 1004, UserName = "Jack" }
            };

            return users;
        }

        private bool disposed = false;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
