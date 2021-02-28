namespace BuilderDemo.Services
{
    public interface IApiService
    {
        string GetData(string accessToken, int id);
    }

    public class ApiService : IApiService
    {
        private readonly string _url;

        public ApiService(string url)
        {
            _url = url;
        }

        public string GetData(string accessToken, int id)
        {
            //External service call with use of accessToken
            return $@"{{""Name"" : ""Some vale\"", ""Id\"" : ""{id}"", ""url"" : ""{_url}""}}";
        }
    }
}
