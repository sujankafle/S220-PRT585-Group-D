using System;
using System.Threading.Tasks;
using CDUNSA.API.Models;

namespace CDUNSA.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<User> Login(string user, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatPasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
    
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }   

        private void CreatPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
           using(var hmac =new System.Security.Cryptography.HMACSHA512())
           {
               passwordSalt = hmac.Key;
               passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
           }
        }

        public Task<bool> UserExists(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}