namespace CDUNSA.API.Models
{
    public class User
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string StudentId {get; set;}
        public string Gender {get; set;}
        public string DateOfBiirth {get; set;}
        public string Added {get; set;}
    }
}