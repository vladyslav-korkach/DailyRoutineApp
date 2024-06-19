using System.Collections.Generic;
using System.Threading.Tasks;
using DailyRoutineApp.Models;

namespace DailyRoutineApp.Services
{
    public interface IUserService
    {
        Task<User?> Authenticate(string username, string password);
        Task<User> Register(User user, string password);
        Task<User?> GetById(int id);
        
    }
}