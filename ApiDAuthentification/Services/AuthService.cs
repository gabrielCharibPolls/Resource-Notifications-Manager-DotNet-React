using System;
using ApiDAuthentification.Models;

namespace ApiDAuthentification.Services
{
    public class AuthService
    {
        // Ceci est juste un exemple. Dans un vrai scénario, vous vérifierez dans une base de données.
        public Users Authenticate(string username, string password)
        {
            if (username == "admin" && password == "password")
                return new Users { Username = username };
            return null;
        }
    }

}
