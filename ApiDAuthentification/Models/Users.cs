
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}


public class AuthService
{
    //attetion il faudra le verifier dans une base des donne plus tard 
    public User Authenticate(string username, string password)
    {
        if (username == "admin" && password == "password")
            return new User { Username = username };
        return null;
    }
}
