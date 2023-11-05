using System.Collections.Generic;
using System;
using OurTestApi.Models;

namespace OurTestApi.Interface
{
    public interface IUser : IDisposable
    {
        List<Users> GetAllUsers();
    }
}
