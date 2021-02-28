using BuilderDemo.Services;

namespace BuilderDemo.Models
{
    public class ModuleX
    {
        private readonly int _x;
        private readonly int _y;
        private readonly IAuthService _authService;

        public ModuleX(int x, int y, IAuthService authService)
        {
            _x = x;
            _y = y;
            _authService = authService;
        }

        public string GetAccessToken(string clientId, string clientSecret) 
        {
            return _authService.GetAccessToken(clientId, clientSecret);
        }

        public override string ToString()
        {
            return $"ModuleX : {{ X : {_x}, Y : {_y} }}";
        }
    }
}
