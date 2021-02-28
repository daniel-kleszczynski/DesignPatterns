using BuilderDemo.BuilderPattern;
using BuilderDemo.Services;
using System;
using System.Configuration;

namespace BuilderDemo
{
    public class Bootstrapper
    {
        public IDirector GetDirector()
        {
            return new Director();
        }

        public IBuilder GetBuilder()
        {
            
            var authUrl = ConfigurationManager.AppSettings["authUrl"] ?? throw new ArgumentNullException("authUrl is not defined in config file");
            IAuthService authService = new AuthService(authUrl);

            var apiUrl = ConfigurationManager.AppSettings["apiUrl"] ?? throw new ArgumentNullException("apihUrl is not defined in config file");
            IApiService apiService = new ApiService(apiUrl);

            return new FirstBuilder(authService, apiService);
        }
    }
}
