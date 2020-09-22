using System.Threading.Tasks;
using CDUNSA.API.Models;

namespace CDUNSA.API.Data
{
    public interface IAuthRepository
    {
       Task<User> Register(User user, string password);  
       Task<User> Login(string user, string password);
       Task<bool> UserExists(string name);
    }
}