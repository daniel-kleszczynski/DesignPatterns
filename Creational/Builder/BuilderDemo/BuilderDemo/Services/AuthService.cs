using System;
using System.Text.RegularExpressions;

namespace BuilderDemo.Services
{
    public interface IAuthService
    {
        string GetAccessToken(string clientId, string clientSecret);
    }

    public class AuthService : IAuthService
    {
        private readonly string _url;

        public AuthService(string url)
        {
            _url = url;
        }

        public string GetAccessToken(string clientId, string clientSecret)
        {
            const string ErrorMessage = "Incorrect url for AuthService";
            return Regex.IsMatch(_url, @"^https://.+\.com$") ? "affe46ersde" : throw new InvalidOperationException(ErrorMessage);
        }
    }
}
