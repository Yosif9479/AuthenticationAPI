namespace AuthenticationAPI.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserModel() 
        {
            Username = "Unnamed";
            Password = "Unpassworded";
        }
        public UserModel(string username, string password) 
        { 
            Username = username;
            Password = password;
        }
    }
}
